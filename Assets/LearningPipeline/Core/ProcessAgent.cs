using Unity.MLAgents;
using Unity.MLAgents.Sensors;
using Unity.MLAgents.Actuators;
using UnityEngine;

namespace LearningPipeline.Core
{
    /// <summary>
    /// Generic agent for process-based learning.
    /// Delegates task-specific logic to ITask implementations.
    ///
    /// ARCHITECTURE:
    /// - Agent handles ML-Agents lifecycle (observations, actions, episodes)
    /// - AgentBody handles physical embodiment (joints, sensors, actuators)
    /// - ITask handles problem definition (reward, termination, environment setup)
    /// - TaskManager handles curriculum (which task is active)
    ///
    /// This separation allows:
    /// - Same agent to learn multiple tasks
    /// - Same body to solve different problems
    /// - Curriculum learning by progressively unlocking tasks
    /// </summary>
    public class ProcessAgent : Agent
    {
        [Header("Components")]
        [SerializeField] private TaskManager taskManager;
        [SerializeField] private AgentBody agentBody;

        [Header("Environment")]
        [SerializeField] private Transform environmentRoot;

        [Header("Debug")]
        [SerializeField] private bool logTaskChanges = true;
        [SerializeField] private bool logRewards = false;

        private ITask currentTask;
        private TaskContext taskContext;

        public override void Initialize()
        {
            base.Initialize();

            // Setup body
            if (agentBody != null)
            {
                agentBody.Initialize();
            }
            else
            {
                Debug.LogError($"[ProcessAgent] No AgentBody assigned to {gameObject.name}!");
            }

            // Setup environment root
            if (environmentRoot == null)
            {
                environmentRoot = transform;
            }

            // Initialize task context
            taskContext = new TaskContext
            {
                Agent = this,
                Body = agentBody,
                EnvironmentRoot = environmentRoot,
                ElapsedTime = 0f,
                StepCount = 0
            };

            // Verify task manager
            if (taskManager == null)
            {
                Debug.LogError($"[ProcessAgent] No TaskManager assigned to {gameObject.name}!");
            }

            Debug.Log($"[ProcessAgent] Initialized on {gameObject.name}");
        }

        public override void OnEpisodeBegin()
        {
            // Get active task from curriculum
            currentTask = taskManager.GetActiveTask();

            if (currentTask == null)
            {
                Debug.LogError("[ProcessAgent] No active task from TaskManager!");
                return;
            }

            if (logTaskChanges)
            {
                Debug.Log($"[ProcessAgent] Episode starting with task: {currentTask.Id}");
            }

            // Reset context
            taskContext.ElapsedTime = 0f;
            taskContext.StepCount = 0;

            // Reset body
            if (agentBody != null)
            {
                agentBody.ResetBodyPose();
            }

            // Let task setup environment
            currentTask.OnEpisodeBegin(taskContext);
        }

        public override void CollectObservations(VectorSensor sensor)
        {
            if (currentTask == null) return;

            // 1) Core body observations
            if (agentBody != null)
            {
                agentBody.CollectBodyObservations(sensor);
            }

            // 2) Task-specific observations
            currentTask.CollectObservations(taskContext, sensor);
        }

        public override void OnActionReceived(ActionBuffers actions)
        {
            if (currentTask == null) return;

            // Update context timing
            taskContext.ElapsedTime += Time.fixedDeltaTime;
            taskContext.StepCount++;

            // Apply actions to body
            if (agentBody != null)
            {
                // Convert ActionBuffers to float array for body
                // (You can modify this to support discrete/continuous separately)
                var cont = actions.ContinuousActions;
                float[] actionArray = cont.Length > 0 ? new float[cont.Length] : new float[0];
                if (cont.Length > 0)
                {
                    System.Array.Copy(cont.Array, cont.Offset, actionArray, 0, cont.Length);
                }

                agentBody.ApplyActions(actionArray);
            }

            // Let task compute reward
            float reward = currentTask.ComputeReward(taskContext);
            AddReward(reward);

            if (logRewards && reward != 0)
            {
                Debug.Log($"[ProcessAgent] Reward: {reward:F3} (Total: {GetCumulativeReward():F3})");
            }

            // Check termination
            if (currentTask.CheckTermination(taskContext, out bool success))
            {
                currentTask.OnEpisodeEnd(taskContext, success);

                // Report to task manager for curriculum progression
                taskManager.ReportEpisodeResult(success);

                if (logTaskChanges)
                {
                    Debug.Log($"[ProcessAgent] Episode ended. Success: {success}, Reward: {GetCumulativeReward():F3}");
                }

                EndEpisode();
            }
        }

        /// <summary>
        /// Optional: Support for heuristic control.
        /// Tasks can implement their own heuristic logic if needed.
        /// </summary>
        public override void Heuristic(in ActionBuffers actionsOut)
        {
            // Default: no heuristic
            // Subclasses or tasks can override this
        }

        /// <summary>
        /// Get the current active task (useful for debugging/UI)
        /// </summary>
        public ITask GetCurrentTask()
        {
            return currentTask;
        }

        /// <summary>
        /// Get the task context (useful for external systems)
        /// </summary>
        public TaskContext GetTaskContext()
        {
            return taskContext;
        }

        /// <summary>
        /// Visualize debug info
        /// </summary>
        private void OnDrawGizmos()
        {
            // Draw environment root
            if (environmentRoot != null)
            {
                Gizmos.color = Color.cyan;
                Gizmos.DrawWireSphere(environmentRoot.position, 0.5f);
            }
        }
    }
}
