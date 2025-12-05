using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Demonstrations;
using LearningPipeline.Core;

namespace LearningPipeline.Imitation
{
    /// <summary>
    /// Generic keyboard controller for recording human demonstrations.
    /// Works with any task that implements IInputMapper.
    ///
    /// SETUP:
    /// 1. Attach to same GameObject as your LearningAgent
    /// 2. Add DemonstrationRecorder component (from ML-Agents)
    /// 3. Assign IInputMapper implementation
    /// 4. Press 'D' to start/stop recording
    /// 5. Use task-specific controls defined in InputMapper
    ///
    /// USAGE:
    /// - D key: Toggle recording on/off
    /// - ESC key: Clear current episode without saving
    /// - Demonstration saved automatically when episode ends
    /// </summary>
    [RequireComponent(typeof(LearningAgent))]
    public class KeyboardController : MonoBehaviour
    {
        [Header("Recording Settings")]
        [SerializeField] private KeyCode toggleRecordingKey = KeyCode.D;
        [SerializeField] private KeyCode cancelEpisodeKey = KeyCode.Escape;
        [SerializeField] private bool showInputHints = true;

        [Header("Status (Read-Only)")]
        [SerializeField] private bool isRecording = false;
        [SerializeField] private int actionsRecorded = 0;

        private IInputMapper inputMapper;
        private LearningAgent agent;
        private DemonstrationRecorder demoRecorder;

        private void Awake()
        {
            agent = GetComponent<LearningAgent>();

            // Automatically find IInputMapper component on this GameObject
            // No manual assignment needed - just add an IInputMapper component (e.g. BinPackingInputMapper)
            MonoBehaviour[] components = GetComponents<MonoBehaviour>();
            foreach (MonoBehaviour component in components)
            {
                if (component is IInputMapper)
                {
                    inputMapper = component as IInputMapper;
                    Debug.Log($"[KeyboardController] Found IInputMapper: {component.GetType().Name}");
                    break;
                }
            }

            if (inputMapper == null)
            {
                Debug.LogError("[KeyboardController] No IInputMapper component found on this GameObject! Add BinPackingInputMapper or similar.");
            }

            // Try to get DemonstrationRecorder
            demoRecorder = GetComponent<DemonstrationRecorder>();
            if (demoRecorder == null)
            {
                Debug.LogWarning("[KeyboardController] No DemonstrationRecorder found. Add one to record demos.");
            }
        }

        private void Start()
        {
            if (inputMapper != null)
            {
                inputMapper.ResetInput();
            }

            DisplayControls();
        }

        private void Update()
        {
            if (inputMapper == null) return;

            // Toggle recording
            if (Input.GetKeyDown(toggleRecordingKey))
            {
                ToggleRecording();
            }

            // Cancel episode
            if (Input.GetKeyDown(cancelEpisodeKey) && isRecording)
            {
                CancelCurrentEpisode();
            }

            // CRITICAL: Only request decision when action is confirmed (space bar pressed)
            // This prevents automatic box placement every frame
            if (inputMapper.IsActionConfirmed())
            {
                agent.RequestDecision();
            }

            // Display input hints if enabled
            if (showInputHints)
            {
                inputMapper.DisplayInputHints();
            }
        }

        /// <summary>
        /// Called by agent's Heuristic() method to get keyboard input
        /// </summary>
        public void GetHeuristicActions(ActionBuffers actionBuffers)
        {
            if (inputMapper == null)
            {
                Debug.LogWarning("[KeyboardController] InputMapper not assigned!");
                return;
            }

            // Map keyboard input to actions
            ActionBuffers mappedActions = inputMapper.MapInput();

            // Copy to output buffers
            if (mappedActions.DiscreteActions.Length > 0)
            {
                for (int i = 0; i < mappedActions.DiscreteActions.Length; i++)
                {
                    actionBuffers.DiscreteActions.Array[i] = mappedActions.DiscreteActions[i];
                }
            }

            if (mappedActions.ContinuousActions.Length > 0)
            {
                for (int i = 0; i < mappedActions.ContinuousActions.Length; i++)
                {
                    actionBuffers.ContinuousActions.Array[i] = mappedActions.ContinuousActions[i];
                }
            }

            // Count actions if recording
            if (isRecording && inputMapper.IsActionConfirmed())
            {
                actionsRecorded++;
            }
        }

        private void ToggleRecording()
        {
            isRecording = !isRecording;

            if (isRecording)
            {
                actionsRecorded = 0;
                agent.SetDemonstrationMode(true);
                Debug.Log($"<color=green>[RECORDING STARTED]</color> Press {toggleRecordingKey} to stop");
            }
            else
            {
                agent.SetDemonstrationMode(false);
                Debug.Log($"<color=yellow>[RECORDING STOPPED]</color> {actionsRecorded} actions recorded");
            }
        }

        private void CancelCurrentEpisode()
        {
            Debug.Log("<color=red>[EPISODE CANCELLED]</color> Resetting without saving...");
            agent.EndEpisode();
            actionsRecorded = 0;
        }

        private void DisplayControls()
        {
            Debug.Log("=== KEYBOARD CONTROLLER ACTIVE ===");
            Debug.Log($"Toggle Recording: {toggleRecordingKey}");
            Debug.Log($"Cancel Episode: {cancelEpisodeKey}");
            if (inputMapper != null)
            {
                Debug.Log($"Current Input State: {inputMapper.GetInputStateString()}");
            }
            Debug.Log("=================================");
        }

        private void OnGUI()
        {
            // Display recording status in top-right corner
            if (isRecording)
            {
                GUIStyle style = new GUIStyle();
                style.fontSize = 24;
                style.normal.textColor = Color.red;
                GUI.Label(new Rect(Screen.width - 250, 10, 240, 30), "● RECORDING", style);
                GUI.Label(new Rect(Screen.width - 250, 40, 240, 30),
                    $"Actions: {actionsRecorded}", style);

                // Display episode count (from ML-Agents Agent.CompletedEpisodes)
                if (agent != null)
                {
                    GUI.Label(new Rect(Screen.width - 250, 70, 240, 30),
                        $"Episodes: {agent.CompletedEpisodes}", style);
                }
            }
            else
            {
                // Show episode count even when not recording (in corner, smaller)
                if (agent != null && agent.CompletedEpisodes > 0)
                {
                    GUIStyle smallStyle = new GUIStyle();
                    smallStyle.fontSize = 16;
                    smallStyle.normal.textColor = Color.yellow;
                    GUI.Label(new Rect(Screen.width - 200, 10, 190, 25),
                        $"Episodes Completed: {agent.CompletedEpisodes}", smallStyle);
                }
            }

            // Display input state
            if (showInputHints && inputMapper != null)
            {
                GUIStyle hintStyle = new GUIStyle();
                hintStyle.fontSize = 16;
                hintStyle.normal.textColor = Color.white;
                GUI.Label(new Rect(10, Screen.height - 60, 600, 50),
                    inputMapper.GetInputStateString(), hintStyle);
            }
        }
    }
}
