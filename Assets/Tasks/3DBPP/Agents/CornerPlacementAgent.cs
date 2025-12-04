using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;
using LearningPipeline.Core;
using LearningPipeline.Imitation;
using Tasks._3DBPP.Curriculum;
using BoxPacking.MLAgents;  // Access existing components

namespace Tasks._3DBPP.Agents
{
    /// <summary>
    /// Simple agent for corner placement task.
    /// Demonstrates how to use the Learning Pipeline framework with existing 3DBPP components.
    ///
    /// SETUP IN UNITY:
    /// 1. Create GameObject with this component
    /// 2. Add CornerPlacementTask component
    /// 3. Add BinPackingInputMapper component
    /// 4. Add KeyboardController component
    /// 5. Add DemonstrationRecorder component (ML-Agents)
    /// 6. Assign references to existing PalletManager, BoxSpawner
    /// 7. Press Play and record demos!
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

        private Box currentBox;
        private int boxesAttempted = 0;

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
        }

        protected override void ResetAgent()
        {
            // Reset pallet
            if (palletManager != null)
            {
                palletManager.Reset();
            }

            boxesAttempted = 0;

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
                    reward = task.EvaluatePlacement(placement.position);
                }

                AddReward(reward);

                // Record metrics
                RecordMetric("boxes_placed", boxesAttempted);
                RecordMetric("corners_occupied", task != null ? task.GetCornersOccupied() : 0);

                boxesAttempted++;

                // Check if task complete or max boxes reached
                if ((task != null && task.IsLessonComplete()) || boxesAttempted >= maxBoxes)
                {
                    Debug.Log($"<color=green>EPISODE COMPLETE!</color> Boxes: {boxesAttempted}, Corners: {task.GetCornersOccupied()}, Reward: {GetCumulativeReward()}");
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
        }

        public override void Heuristic(in ActionBuffers actionsOut)
        {
            // Let KeyboardController handle input for demonstrations
            var keyboard = GetComponent<KeyboardController>();
            if (keyboard != null)
            {
                keyboard.GetHeuristicActions(actionsOut);
            }
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
            // For corner placement, use fixed box size
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
            int gridResolution = 8;  // Match InputMapper
            int numRotations = 4;
            int totalGridPositions = gridResolution * gridResolution;

            int rotationIndex = action / totalGridPositions;
            int gridPos = action % totalGridPositions;
            int gridX = gridPos / gridResolution;
            int gridZ = gridPos % gridResolution;

            // Convert grid to world position
            float xPos = (gridX + 0.5f) / gridResolution * palletManager.palletSize.x;
            float zPos = (gridZ + 0.5f) / gridResolution * palletManager.palletSize.z;
            float yPos = palletManager.GetHeightAt(xPos, zPos);

            Vector3 position = new Vector3(xPos, yPos, zPos);
            int rotation = rotationIndex * 90;

            return new PlacementAction(position, rotation);
        }
    }
}
