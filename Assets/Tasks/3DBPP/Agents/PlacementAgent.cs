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
    /// General placement agent for configurable grid patterns.
    /// Uses 3 discrete action branches:
    ///   Branch 0: Grid X position (0 to gridResolution-1)
    ///   Branch 1: Grid Z position (0 to gridResolution-1)
    ///   Branch 2: Rotation (0=0°, 1=90°, 2=180°, 3=270°)
    ///
    /// BOX SIZE:
    /// - By default, box size is auto-calculated to match grid cell size
    /// - Set autoCalculateBoxSize = false to use fixedBoxSize instead
    /// - This ensures the box cursor matches the grid visualization
    ///
    /// SETUP IN UNITY:
    /// 1. Create GameObject with this component
    /// 2. Add PlacementTask component
    /// 3. Configure target pattern in PlacementTask inspector (checkboxes)
    /// 4. Add DemonstrationRecorder component (ML-Agents)
    /// 5. Set Behavior Type to "Heuristic Only" for recording
    /// 6. Assign references to existing PalletManager
    /// 7. Configure Behavior Parameters:
    ///    - Vector Observation Space Size: 3 + (gridResolution^2) + 2 = 69 for 8x8
    ///    - Discrete Branches: 3
    ///    - Branch 0 Size: gridResolution (default 8)
    ///    - Branch 1 Size: gridResolution (default 8)
    ///    - Branch 2 Size: 4 (rotations)
    /// 8. Press Play and use keyboard to record demos!
    ///
    /// CONTROLS (built-in):
    /// - Arrow Keys: Move grid cursor
    /// - R: Rotate box
    /// - Space: Place box (triggers action)
    /// </summary>
    public class PlacementAgent : LearningAgent
    {
        [Header("Existing 3DBPP Components")]
        [SerializeField] private PalletManager palletManager;
        [SerializeField] private BoxSpawner boxSpawner;
        [SerializeField] private PlacementValidator validator;

        [Header("Task")]
        [SerializeField] private PlacementTask task;

        [Header("Settings")]
        [SerializeField] private bool autoCalculateBoxSize = true;
        [SerializeField] private Vector3 fixedBoxSize = new Vector3(20, 20, 20);
        [SerializeField] private float boxHeight = 20f;
        [SerializeField] private int maxBoxes = 10;
        [SerializeField] private int gridResolution = 8;

        [Header("Validation")]
        [Tooltip("Enable placement validation (physics constraints). Disable for simple grid placement tasks.")]
        [SerializeField] private bool enableValidation = false;

        private Vector3 actualBoxSize;

        [Header("Heuristic Input State")]
        [SerializeField] private int currentGridX = 4;
        [SerializeField] private int currentGridZ = 4;
        [SerializeField] private int currentRotation = 0;

        [Header("Debug")]
        [SerializeField] private bool showDebugGUI = true;
        [SerializeField] private int heuristicCallCount = 0;
        [SerializeField] private int actionsRecordedCount = 0;

        private Box currentBox;
        private int boxesAttempted = 0;
        private float lastMoveTime = 0f;
        private float moveRepeatRate = 0.15f;
        private bool actionPending = false;
        private bool spacePressed = false;

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

            // Calculate box size to match grid cells
            if (autoCalculateBoxSize && palletManager != null)
            {
                float cellWidth = palletManager.palletSize.x / gridResolution;
                float cellDepth = palletManager.palletSize.z / gridResolution;
                actualBoxSize = new Vector3(cellWidth, boxHeight, cellDepth);
                Debug.Log($"Auto-calculated box size: {actualBoxSize} (cell size: {cellWidth}x{cellDepth})");
            }
            else
            {
                actualBoxSize = fixedBoxSize;
                Debug.Log($"Using fixed box size: {actualBoxSize}");
            }

            // Start at center of grid
            currentGridX = gridResolution / 2;
            currentGridZ = gridResolution / 2;
            currentRotation = 0;

            Debug.Log("=== PLACEMENT AGENT ===");
            Debug.Log("Arrow Keys: Move cursor");
            Debug.Log("R: Rotate box");
            Debug.Log("Space: Place box");
            Debug.Log($"Target Pattern: {task?.GetTargetCellsCount() ?? 0} cells");
            Debug.Log("=======================");
        }

        private void Update()
        {
            // Handle keyboard input for heuristic mode
            HandleKeyboardInput();
        }

        /// <summary>
        /// FixedUpdate is used for ML-Agents decision timing.
        /// This ensures proper synchronization with DemonstrationRecorder.
        /// </summary>
        private void FixedUpdate()
        {
            // Process pending actions on ML-Agents decision cycle
            if (spacePressed)
            {
                spacePressed = false;
                actionPending = true;
                RequestDecision();
            }
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

            // Handle action confirmation (prevent multiple rapid presses)
            if (Input.GetKeyDown(KeyCode.Space) && !actionPending && !spacePressed)
            {
                spacePressed = true;
                Debug.Log($"<color=cyan>ACTION REQUESTED:</color> Grid({currentGridX},{currentGridZ}) Rot={currentRotation}°");
            }
        }

        protected override void ResetAgent()
        {
            // Reset pallet
            if (palletManager != null)
            {
                palletManager.Reset();
            }

            // Reset task metrics
            if (task != null)
            {
                task.ResetTask();
            }

            boxesAttempted = 0;

            // Reset input state
            currentGridX = gridResolution / 2;
            currentGridZ = gridResolution / 2;
            currentRotation = 0;

            // Reset action flags (critical for episode transitions!)
            actionPending = false;
            spacePressed = false;

            // Spawn first box
            SpawnNextBox();
        }

        public override void CollectObservations(VectorSensor sensor)
        {
            // Observations for general placement task
            if (currentBox != null)
            {
                // Current box size (normalized) - 3 values
                sensor.AddObservation(currentBox.size / 100f);

                // Grid state (flattened) - gridResolution * gridResolution values
                // For each cell: 0 if not target, 1 if target and not occupied, 0.5 if target and occupied
                if (task != null)
                {
                    for (int z = 0; z < gridResolution; z++)
                    {
                        for (int x = 0; x < gridResolution; x++)
                        {
                            bool isTarget = task.IsTargetCell(x, z);
                            if (isTarget)
                            {
                                sensor.AddObservation(1f); // Target cell
                            }
                            else
                            {
                                sensor.AddObservation(0f); // Non-target cell
                            }
                        }
                    }
                }
                else
                {
                    // No task - add zeros
                    for (int i = 0; i < gridResolution * gridResolution; i++)
                    {
                        sensor.AddObservation(0f);
                    }
                }

                // Task progress - 2 values
                if (task != null)
                {
                    sensor.AddObservation(task.GetTargetCellsOccupied() / (float)task.GetTargetCellsCount());
                    sensor.AddObservation(boxesAttempted / (float)maxBoxes);
                }
                else
                {
                    sensor.AddObservation(0f);
                    sensor.AddObservation(0f);
                }
            }
            else
            {
                // No current box - add zeros
                int totalObs = 3 + (gridResolution * gridResolution) + 2;
                for (int i = 0; i < totalObs; i++)
                {
                    sensor.AddObservation(0f);
                }
            }

            // Total observations: 3 (box size) + gridRes^2 (grid state) + 2 (progress) = 69 for 8x8 grid
        }

        public override void OnActionReceived(ActionBuffers actions)
        {
            if (currentBox == null)
            {
                Debug.LogWarning("OnActionReceived called but currentBox is null!");
                return;
            }

            // Read from 3 discrete branches
            int gridX = actions.DiscreteActions[0];
            int gridZ = actions.DiscreteActions[1];
            int rotationIndex = actions.DiscreteActions[2];
            int rotation = rotationIndex * 90;

            Debug.Log($"<color=magenta>ACTION RECEIVED:</color> Grid({gridX},{gridZ}) Rot={rotation}° BoxSize={actualBoxSize}");

            // Convert grid to world position and create placement
            PlacementAction placement = GridToPlacement(gridX, gridZ, rotation);
            Debug.Log($"Placement position: {placement.position}, rotation: {placement.rotation}");

            // Validate placement
            bool isValid = true;

            if (enableValidation && validator != null)
            {
                Debug.Log($"<color=yellow>Validation enabled. Checking placement...</color>");
                isValid = validator.ValidatePlacement(currentBox, placement, palletManager);

                if (!isValid)
                {
                    // Detailed validation debugging
                    Debug.LogWarning($"<color=orange>VALIDATION FAILED for Grid({gridX},{gridZ})</color>");
                    Debug.Log($"  - Box size: {currentBox.size}");
                    Debug.Log($"  - Placement pos: {placement.position}");
                    Debug.Log($"  - Pallet bounds: {palletManager.palletSize}");
                    Debug.Log($"  TIP: Disable 'Enable Validation' in PlacementAgent, or configure PlacementValidator: Allow Floating=true, Check Stability=false");
                }
                else
                {
                    Debug.Log($"<color=green>Placement valid: true</color>");
                }
            }
            else if (!enableValidation)
            {
                Debug.Log($"<color=cyan>Validation disabled - placement automatically valid</color>");
            }
            else
            {
                Debug.Log($"<color=cyan>No validator assigned - placement automatically valid</color>");
            }

            if (isValid)
            {
                // Place box
                if (palletManager != null)
                {
                    var placedBox = palletManager.PlaceBox(currentBox, placement);
                    if (placedBox != null && placedBox.gameObject != null)
                    {
                        Debug.Log($"<color=green>BOX PLACED:</color> {placedBox.gameObject.name} at {placedBox.gameObject.transform.position}");
                    }
                    else
                    {
                        Debug.LogError("PlaceBox returned null or null GameObject!");
                    }
                }
                else
                {
                    Debug.LogError("PalletManager is null!");
                }

                // Get reward from task
                float reward = 0f;
                if (task != null)
                {
                    Vector3 boxCenter = placement.position + new Vector3(actualBoxSize.x / 2f, 0, actualBoxSize.z / 2f);
                    Debug.Log($"<color=cyan>Evaluating placement at box center: {boxCenter}</color>");
                    Debug.Log($"<color=cyan>Expected: Grid({gridX},{gridZ}) should be target={task.IsTargetCell(gridX, gridZ)}</color>");
                    reward = task.EvaluatePlacement(boxCenter);
                    Debug.Log($"<color=cyan>Reward received: {reward}</color>");
                }

                AddReward(reward);

                // Record metrics
                RecordMetric("boxes_placed", boxesAttempted);
                if (task != null)
                {
                    RecordMetric("target_cells_occupied", task.GetTargetCellsOccupied());
                    RecordMetric("target_cells_total", task.GetTargetCellsCount());
                }

                boxesAttempted++;
                actionsRecordedCount++;

                // Check if task complete or max boxes reached
                if ((task != null && task.IsLessonComplete()) || boxesAttempted >= maxBoxes)
                {
                    Debug.Log($"<color=green>EPISODE COMPLETE!</color> Boxes: {boxesAttempted}, " +
                             $"Target Cells: {task?.GetTargetCellsOccupied() ?? 0}/{task?.GetTargetCellsCount() ?? 0}, " +
                             $"Reward: {GetCumulativeReward()}");
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
        /// Heuristic for keyboard control - outputs to 3 discrete branches.
        /// </summary>
        public override void Heuristic(in ActionBuffers actionsOut)
        {
            heuristicCallCount++;

            var discreteActionsOut = actionsOut.DiscreteActions;

            // Safety check
            if (discreteActionsOut.Length < 3)
            {
                Debug.LogError($"<color=red>BEHAVIOR PARAMETERS NOT CONFIGURED!</color>\n" +
                    $"Please configure the Behavior Parameters component:\n" +
                    $"- Vector Observation Space Size: {3 + (gridResolution * gridResolution) + 2}\n" +
                    $"- Discrete Branches: 3\n" +
                    $"- Branch 0 Size: {gridResolution}\n" +
                    $"- Branch 1 Size: {gridResolution}\n" +
                    $"- Branch 2 Size: 4");
                return;
            }

            // Write to 3 separate branches
            discreteActionsOut[0] = currentGridX;
            discreteActionsOut[1] = currentGridZ;
            discreteActionsOut[2] = currentRotation / 90;

            Debug.Log($"<color=yellow>HEURISTIC #{heuristicCallCount}:</color> X={currentGridX}, Z={currentGridZ}, Rot={currentRotation}°");
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
                size = actualBoxSize,
                weight = 10f,
                color = Color.cyan,
                canBeRotated = true
            };

            Debug.Log($"Box {boxesAttempted + 1}/{maxBoxes} ready");
        }

        /// <summary>
        /// Convert grid coordinates to a PlacementAction
        /// NOTE: Uses cell-based positioning to match the visualization in PlacementTask gizmos
        /// </summary>
        private PlacementAction GridToPlacement(int gridX, int gridZ, int rotation)
        {
            // Calculate cell size to match visualization
            float cellWidth = palletManager.palletSize.x / gridResolution;
            float cellDepth = palletManager.palletSize.z / gridResolution;

            // Calculate center of cell (matching PlacementTask.OnDrawGizmos)
            float centerX = (gridX + 0.5f) * cellWidth;
            float centerZ = (gridZ + 0.5f) * cellDepth;

            // Convert from center to corner (box placement position)
            float halfBoxX = actualBoxSize.x / 2f;
            float halfBoxZ = actualBoxSize.z / 2f;
            float cornerX = centerX - halfBoxX;
            float cornerZ = centerZ - halfBoxZ;

            float yPos = palletManager.GetHeightAt(centerX, centerZ);

            Vector3 cornerPosition = new Vector3(cornerX, yPos, cornerZ);

            Debug.Log($"Grid({gridX},{gridZ}) -> Cell center({centerX:F1},{centerZ:F1}) -> Corner({cornerX:F1},{cornerZ:F1})");

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

            // Box and task info
            string taskInfo = task != null ?
                $"{task.GetTargetCellsOccupied()}/{task.GetTargetCellsCount()}" :
                "No Task";
            GUI.Label(new Rect(10, 60, 400, 25),
                $"Box: {boxesAttempted + 1}/{maxBoxes} | Target Cells: {taskInfo}", style);

            // Target cell indicator
            if (task != null && task.IsTargetCell(currentGridX, currentGridZ))
            {
                style.normal.textColor = Color.green;
                GUI.Label(new Rect(10, 85, 400, 25),
                    "Current cell is TARGET", style);
            }

            // Instructions
            style.normal.textColor = Color.cyan;
            GUI.Label(new Rect(10, Screen.height - 30, 600, 25),
                "Arrow Keys: Move | R: Rotate | Space: Place", style);
        }

        /// <summary>
        /// Visualize cursor position in Scene view
        /// </summary>
        private void OnDrawGizmos()
        {
            // Don't draw if not properly initialized
            if (palletManager == null) return;
            if (!Application.isPlaying) return;
            if (actualBoxSize == Vector3.zero) return; // Not yet initialized

            Vector3 worldPos = GridToWorldPosition(currentGridX, currentGridZ);
            worldPos.y = actualBoxSize.y / 2f;

            // Check if on target cell
            bool isTargetCell = task != null && task.IsTargetCell(currentGridX, currentGridZ);

            // SUPER THICK outline with VERY distinct colors
            if (isTargetCell)
            {
                // TARGET CELL - BRIGHT LIME GREEN with thick outline
                Color greenColor = new Color(0.5f, 1f, 0f, 1f); // Lime green (very bright)

                // Draw 8 layers for ultra-thick outline
                for (int i = 0; i < 8; i++)
                {
                    float offset = i * 0.15f;
                    Gizmos.color = greenColor;
                    Gizmos.DrawWireCube(worldPos, actualBoxSize + Vector3.one * offset);
                }

                // Draw filled semi-transparent green cube
                Gizmos.color = new Color(0.5f, 1f, 0f, 0.3f);
                Gizmos.DrawCube(worldPos, actualBoxSize);

                // Draw the edges even thicker by drawing lines
                DrawThickBoxEdges(worldPos, actualBoxSize, greenColor);
            }
            else
            {
                // NON-TARGET CELL - CYAN (regular)
                Color cyanColor = new Color(0f, 1f, 1f, 1f);

                // Draw 5 layers for thick outline
                for (int i = 0; i < 5; i++)
                {
                    float offset = i * 0.12f;
                    Gizmos.color = cyanColor;
                    Gizmos.DrawWireCube(worldPos, actualBoxSize + Vector3.one * offset);
                }

                // Draw filled semi-transparent cyan cube
                Gizmos.color = new Color(0f, 1f, 1f, 0.2f);
                Gizmos.DrawCube(worldPos, actualBoxSize);
            }

            // Draw rotation indicator with VERY thick line
            Vector3 arrowStart = worldPos;
            arrowStart.y = actualBoxSize.y;
            Vector3 forward = Quaternion.Euler(0, currentRotation, 0) * Vector3.forward;
            Vector3 arrowEnd = arrowStart + forward * (actualBoxSize.x / 2f);

            // Draw ultra-thick red arrow
            Gizmos.color = Color.red;
            for (int i = 0; i < 5; i++)
            {
                Vector3 offset = Vector3.up * (i - 2) * 0.3f;
                Gizmos.DrawLine(arrowStart + offset, arrowEnd + offset);
            }
            for (int i = 0; i < 5; i++)
            {
                Vector3 offset = Vector3.right * (i - 2) * 0.3f;
                Gizmos.DrawLine(arrowStart + offset, arrowEnd + offset);
            }
        }

        /// <summary>
        /// Draw extra thick box edges for better visibility
        /// </summary>
        private void DrawThickBoxEdges(Vector3 center, Vector3 size, Color color)
        {
            Gizmos.color = color;
            Vector3 halfSize = size / 2f;

            // Define the 8 corners of the box
            Vector3[] corners = new Vector3[8];
            corners[0] = center + new Vector3(-halfSize.x, -halfSize.y, -halfSize.z);
            corners[1] = center + new Vector3(halfSize.x, -halfSize.y, -halfSize.z);
            corners[2] = center + new Vector3(halfSize.x, -halfSize.y, halfSize.z);
            corners[3] = center + new Vector3(-halfSize.x, -halfSize.y, halfSize.z);
            corners[4] = center + new Vector3(-halfSize.x, halfSize.y, -halfSize.z);
            corners[5] = center + new Vector3(halfSize.x, halfSize.y, -halfSize.z);
            corners[6] = center + new Vector3(halfSize.x, halfSize.y, halfSize.z);
            corners[7] = center + new Vector3(-halfSize.x, halfSize.y, halfSize.z);

            // Draw bottom face edges with thickness
            for (int layer = 0; layer < 3; layer++)
            {
                float offset = layer * 0.2f;
                Gizmos.DrawLine(corners[0] + Vector3.up * offset, corners[1] + Vector3.up * offset);
                Gizmos.DrawLine(corners[1] + Vector3.up * offset, corners[2] + Vector3.up * offset);
                Gizmos.DrawLine(corners[2] + Vector3.up * offset, corners[3] + Vector3.up * offset);
                Gizmos.DrawLine(corners[3] + Vector3.up * offset, corners[0] + Vector3.up * offset);

                // Draw top face edges
                Gizmos.DrawLine(corners[4] - Vector3.up * offset, corners[5] - Vector3.up * offset);
                Gizmos.DrawLine(corners[5] - Vector3.up * offset, corners[6] - Vector3.up * offset);
                Gizmos.DrawLine(corners[6] - Vector3.up * offset, corners[7] - Vector3.up * offset);
                Gizmos.DrawLine(corners[7] - Vector3.up * offset, corners[4] - Vector3.up * offset);

                // Draw vertical edges
                Gizmos.DrawLine(corners[0], corners[4]);
                Gizmos.DrawLine(corners[1], corners[5]);
                Gizmos.DrawLine(corners[2], corners[6]);
                Gizmos.DrawLine(corners[3], corners[7]);
            }
        }

        private Vector3 GridToWorldPosition(int x, int z)
        {
            // Use same cell-based calculation as GridToPlacement
            float cellWidth = palletManager.palletSize.x / gridResolution;
            float cellDepth = palletManager.palletSize.z / gridResolution;

            // Center of cell
            float xPos = (x + 0.5f) * cellWidth;
            float zPos = (z + 0.5f) * cellDepth;

            return new Vector3(xPos, 0, zPos);
        }
    }
}
