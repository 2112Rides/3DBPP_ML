using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;
using LearningPipeline.Core;
using Tasks._3DBPP.Curriculum;
using BoxPacking.MLAgents;

namespace Tasks._3DBPP.Agents
{
    /// <summary>
    /// Simple agent for corner placement task.
    /// FIXED: Follows standard ML-Agents Heuristic pattern for proper demo recording.
    ///
    /// SETUP IN UNITY:
    /// 1. Create GameObject with this component
    /// 2. Add CornerPlacementTask component  
    /// 3. Add DemonstrationRecorder component (ML-Agents)
    /// 4. Set Behavior Type to "Heuristic Only" for recording
    /// 5. Assign references to existing PalletManager
    /// 6. Press Play and use keyboard to record demos!
    ///
    /// CONTROLS (built-in):
    /// - Arrow Keys: Move grid cursor
    /// - R: Rotate box
    /// - Space: Place box (triggers action)
    /// - D: Toggle recording display
    /// </summary>
    public class CornerPlacementAgent : LearningAgent
    {
        [Header("Existing 3DBPP Components")]
        [SerializeField] private PalletManager palletManager;
        [SerializeField] private BoxSpawner boxSpawner;
        [SerializeField] private PlacementValidator validator;

        [Header("Task")]
        [SerializeField] private CornerPlacementTask task;

        [Header("Settings")]
        [SerializeField] private Vector3 fixedBoxSize = new Vector3(20, 20, 20);
        [SerializeField] private int maxBoxes = 4;
        [SerializeField] private int gridResolution = 8;

        [Header("Heuristic Input State")]
        [SerializeField] private int currentGridX = 0;
        [SerializeField] private int currentGridZ = 0;
        [SerializeField] private int currentRotation = 0;  // 0, 90, 180, 270

        [Header("Debug")]
        [SerializeField] private bool showDebugGUI = true;
        [SerializeField] private int heuristicCallCount = 0;
        [SerializeField] private int actionsRecordedCount = 0;

        private Box currentBox;
        private int boxesAttempted = 0;
        private float lastMoveTime = 0f;
        private float moveRepeatRate = 0.15f;
        private bool actionPending = false;

        public override void Initialize()
        {
            // Setup task
            if (task != null)
            {
                SetupTask(task);
            }

            // Initialize existing components
            if (palletManager != null)
            {
                palletManager.Initialize();
            }
            if (boxSpawner != null)
            {
                boxSpawner.Initialize();
            }

            // Start at center of grid
            currentGridX = gridResolution / 2;
            currentGridZ = gridResolution / 2;
            currentRotation = 0;

            Debug.Log("=== CORNER PLACEMENT AGENT ===");
            Debug.Log("Arrow Keys: Move cursor");
            Debug.Log("R: Rotate box");
            Debug.Log("Space: Place box");
            Debug.Log("==============================");
        }

        private void Update()
        {
            // Handle keyboard input for heuristic mode
            HandleKeyboardInput();
        }

        private void HandleKeyboardInput()
        {
            // Handle movement with repeat rate
            if (Time.time - lastMoveTime >= moveRepeatRate)
            {
                bool moved = false;

                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    currentGridX = Mathf.Max(0, currentGridX - 1);
                    moved = true;
                }
                else if (Input.GetKey(KeyCode.RightArrow))
                {
                    currentGridX = Mathf.Min(gridResolution - 1, currentGridX + 1);
                    moved = true;
                }

                if (Input.GetKey(KeyCode.UpArrow))
                {
                    currentGridZ = Mathf.Min(gridResolution - 1, currentGridZ + 1);
                    moved = true;
                }
                else if (Input.GetKey(KeyCode.DownArrow))
                {
                    currentGridZ = Mathf.Max(0, currentGridZ - 1);
                    moved = true;
                }

                if (moved)
                {
                    lastMoveTime = Time.time;
                }
            }

            // Handle rotation
            if (Input.GetKeyDown(KeyCode.R))
            {
                currentRotation = (currentRotation + 90) % 360;
                Debug.Log($"Rotation: {currentRotation}°");
            }

            // Handle action confirmation - THIS IS KEY!
            // When space is pressed, we request a decision which triggers Heuristic()
            if (Input.GetKeyDown(KeyCode.Space))
            {
                actionPending = true;
                Debug.Log($"<color=cyan>ACTION REQUESTED:</color> Grid({currentGridX},{currentGridZ}) Rot={currentRotation}°");
                RequestDecision();  // This triggers Heuristic() -> OnActionReceived()
            }
        }

        protected override void ResetAgent()
        {
            // Reset pallet
            if (palletManager != null)
            {
                palletManager.Reset();
            }

            boxesAttempted = 0;

            // Reset input state
            currentGridX = gridResolution / 2;
            currentGridZ = gridResolution / 2;
            currentRotation = 0;

            // Spawn first box
            SpawnNextBox();
        }

        public override void CollectObservations(VectorSensor sensor)
        {
            // Simple observations for corner placement task
            if (currentBox != null)
            {
                // Current box size (normalized)
                sensor.AddObservation(currentBox.size / 100f);

                // Number of corners occupied (one-hot encoding)
                if (task != null)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        sensor.AddObservation(task.GetCornersOccupied() > i ? 1f : 0f);
                    }
                }
            }
            else
            {
                // No current box
                sensor.AddObservation(Vector3.zero);
                sensor.AddObservation(new float[4]); // 4 corner flags
            }

            // Boxes placed
            sensor.AddObservation(boxesAttempted / (float)maxBoxes);
        }

        public override void OnActionReceived(ActionBuffers actions)
        {
            if (currentBox == null) return;

            int action = actions.DiscreteActions[0];

            // Decode action into placement
            PlacementAction placement = DecodeAction(action);

            // Validate placement
            bool isValid = validator != null ?
                validator.ValidatePlacement(currentBox, placement, palletManager) :
                true;

            if (isValid)
            {
                // Place box
                if (palletManager != null)
                {
                    palletManager.PlaceBox(currentBox, placement);
                }

                // Get reward from task
                float reward = 0f;
                if (task != null)
                {
                    Vector3 boxCenter = placement.position + new Vector3(fixedBoxSize.x / 2f, 0, fixedBoxSize.z / 2f);
                    reward = task.EvaluatePlacement(boxCenter);
                }

                AddReward(reward);

                // Record metrics
                RecordMetric("boxes_placed", boxesAttempted);
                RecordMetric("corners_occupied", task != null ? task.GetCornersOccupied() : 0);

                boxesAttempted++;
                actionsRecordedCount++;

                // Check if task complete or max boxes reached
                if ((task != null && task.IsLessonComplete()) || boxesAttempted >= maxBoxes)
                {
                    Debug.Log($"<color=green>EPISODE COMPLETE!</color> Boxes: {boxesAttempted}, Corners: {task?.GetCornersOccupied() ?? 0}, Reward: {GetCumulativeReward()}");
                    EndEpisode();
                    return;
                }

                // Spawn next box
                SpawnNextBox();
            }
            else
            {
                // Invalid placement - small penalty
                AddReward(-1f);
                Debug.LogWarning("Invalid placement attempted");
            }

            actionPending = false;
        }

        /// <summary>
        /// CRITICAL: This is the standard ML-Agents Heuristic pattern.
        /// Directly writes action to the output buffer - no intermediate objects!
        /// </summary>
        public override void Heuristic(in ActionBuffers actionsOut)
        {
            heuristicCallCount++;

            // Get the discrete actions segment
            var discreteActionsOut = actionsOut.DiscreteActions;

            // Encode current input state directly into action
            // Action = rotation_index * grid_size^2 + gridX * grid_size + gridZ
            int totalGridPositions = gridResolution * gridResolution;
            int rotationIndex = currentRotation / 90;
            int action = rotationIndex * totalGridPositions + currentGridX * gridResolution + currentGridZ;

            // Write directly to the output buffer using indexer (NOT .Array[])
            discreteActionsOut[0] = action;

            Debug.Log($"<color=yellow>HEURISTIC CALLED #{heuristicCallCount}:</color> Action={action} (Grid:{currentGridX},{currentGridZ} Rot:{currentRotation}°)");
        }

        protected override bool IsEpisodeComplete()
        {
            if (task != null && task.IsLessonComplete())
            {
                return true;
            }
            return boxesAttempted >= maxBoxes;
        }

        private void SpawnNextBox()
        {
            currentBox = new Box
            {
                id = boxesAttempted,
                size = fixedBoxSize,
                weight = 10f,
                color = Color.cyan,
                canBeRotated = true
            };

            Debug.Log($"Box {boxesAttempted + 1}/{maxBoxes} ready");
        }

        private PlacementAction DecodeAction(int action)
        {
            int totalGridPositions = gridResolution * gridResolution;

            int rotationIndex = action / totalGridPositions;
            int gridPos = action % totalGridPositions;
            int gridX = gridPos / gridResolution;
            int gridZ = gridPos % gridResolution;

            // Convert grid to world position
            float halfBoxX = fixedBoxSize.x / 2f;
            float halfBoxZ = fixedBoxSize.z / 2f;
            float usableWidth = palletManager.palletSize.x - fixedBoxSize.x;
            float usableDepth = palletManager.palletSize.z - fixedBoxSize.z;

            float centerX = halfBoxX + (gridX / (float)(gridResolution - 1)) * usableWidth;
            float centerZ = halfBoxZ + (gridZ / (float)(gridResolution - 1)) * usableDepth;

            float cornerX = centerX - halfBoxX;
            float cornerZ = centerZ - halfBoxZ;
            float yPos = palletManager.GetHeightAt(centerX, centerZ);

            Vector3 cornerPosition = new Vector3(cornerX, yPos, cornerZ);
            int rotation = rotationIndex * 90;

            return new PlacementAction(cornerPosition, rotation);
        }

        /// <summary>
        /// Display debug info on screen
        /// </summary>
        private void OnGUI()
        {
            if (!showDebugGUI) return;

            GUIStyle style = new GUIStyle();
            style.fontSize = 18;
            style.normal.textColor = Color.white;

            // Current position
            GUI.Label(new Rect(10, 10, 400, 25),
                $"Grid: ({currentGridX}, {currentGridZ}) | Rotation: {currentRotation}°", style);

            // Action counts
            GUI.Label(new Rect(10, 35, 400, 25),
                $"Heuristic Calls: {heuristicCallCount} | Actions: {actionsRecordedCount}", style);

            // Box info
            GUI.Label(new Rect(10, 60, 400, 25),
                $"Box: {boxesAttempted + 1}/{maxBoxes} | Corners: {task?.GetCornersOccupied() ?? 0}/4", style);

            // Instructions
            style.normal.textColor = Color.cyan;
            GUI.Label(new Rect(10, Screen.height - 30, 600, 25),
                "Arrow Keys: Move | R: Rotate | Space: Place", style);
        }

        /// <summary>
        /// Visualize cursor position
        /// </summary>
        private void OnDrawGizmos()
        {
            if (palletManager == null) return;

            Vector3 worldPos = GridToWorldPosition(currentGridX, currentGridZ);
            worldPos.y = fixedBoxSize.y / 2f;

            // Draw cursor box
            Gizmos.color = Color.cyan;
            Gizmos.DrawWireCube(worldPos, fixedBoxSize);

            // Draw rotation indicator
            Vector3 arrowStart = worldPos;
            arrowStart.y = fixedBoxSize.y;
            Vector3 forward = Quaternion.Euler(0, currentRotation, 0) * Vector3.forward;
            Gizmos.color = Color.red;
            Gizmos.DrawLine(arrowStart, arrowStart + forward * (fixedBoxSize.x / 2f));
        }

        private Vector3 GridToWorldPosition(int x, int z)
        {
            float halfBoxX = fixedBoxSize.x / 2f;
            float halfBoxZ = fixedBoxSize.z / 2f;
            float usableWidth = palletManager.palletSize.x - fixedBoxSize.x;
            float usableDepth = palletManager.palletSize.z - fixedBoxSize.z;

            float xPos = halfBoxX + (x / (float)(gridResolution - 1)) * usableWidth;
            float zPos = halfBoxZ + (z / (float)(gridResolution - 1)) * usableDepth;

            return new Vector3(xPos, 0, zPos);
        }
    }
}
