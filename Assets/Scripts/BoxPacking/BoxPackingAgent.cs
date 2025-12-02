using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;
using System.Collections.Generic;
using System.Linq;

namespace BoxPacking.MLAgents
{
    /// <summary>
    /// Main ML-Agents agent for learning 3D box packing/palletization
    /// </summary>
    public class BoxPackingAgent : Agent
    {
        #region Serialized Fields
        
        [Header("Environment References")]
        [SerializeField] private PalletManager palletManager;
        [SerializeField] private BoxSpawner boxSpawner;
        [SerializeField] private PlacementValidator placementValidator;
        [SerializeField] private RewardCalculator rewardCalculator;
        [SerializeField] private VisualizationManager visualizationManager;
        
        [Header("Agent Configuration")]
        [Tooltip("Maximum number of boxes to pack per episode")]
        [SerializeField] private int maxBoxesPerEpisode = 20;
        
        [Tooltip("Grid resolution for discretizing placement positions")]
        [SerializeField] private int gridResolution = 10;
        
        [Tooltip("Small penalty per step to encourage efficiency")]
        [SerializeField] private float stepPenalty = -0.01f;
        
        [Tooltip("End episode immediately on invalid placement")]
        [SerializeField] private bool endOnInvalidPlacement = true;
        
        [Tooltip("Maximum steps per episode")]
        [SerializeField] private int maxSteps = 100;
        
        [Header("Observation Settings")]
        [Tooltip("Number of upcoming boxes to preview")]
        [SerializeField] private int boxPreviewCount = 5;
        
        [Tooltip("Include height map in observations")]
        [SerializeField] private bool includeHeightMap = true;
        
        [Tooltip("Resolution of height map observations")]
        [SerializeField] private int heightMapResolution = 10;
        
        [Header("Debug")]
        [SerializeField] private bool debugMode = false;
        [SerializeField] private bool visualizeActions = true;
        
        #endregion
        
        #region Private Fields
        
        private Box currentBox;
        private List<Box> remainingBoxes;
        private int boxesPackedThisEpisode;
        private int stepCount;
        private float episodeStartTime;
        
        // Cache for valid placements
        private List<PlacementAction> validPlacements;

        // Cache for action masking (to avoid duplicate validation checks)
        private bool hasAnyValidAction;
        private bool actionMaskCacheValid;

        // Statistics for curriculum learning
        private float averagePackingEfficiency;
        private int totalEpisodesCompleted;
        
        #endregion
        
        #region Unity Lifecycle
        
        private void Awake()
        {
            // Validate references
            ValidateReferences();
        }
        
        private void ValidateReferences()
        {
            if (palletManager == null)
                Debug.LogError($"[{gameObject.name}] PalletManager reference is missing!");
            if (boxSpawner == null)
                Debug.LogError($"[{gameObject.name}] BoxSpawner reference is missing!");
            if (placementValidator == null)
                Debug.LogError($"[{gameObject.name}] PlacementValidator reference is missing!");
            if (rewardCalculator == null)
                Debug.LogError($"[{gameObject.name}] RewardCalculator reference is missing!");
        }
        
        #endregion
        
        #region ML-Agents Overrides
        
        /// <summary>
        /// Initialize the agent
        /// </summary>
        public override void Initialize()
        {
            base.Initialize();
            
            // Initialize components
            palletManager?.Initialize();
            boxSpawner?.Initialize();
            
            if (debugMode)
                Debug.Log($"[{gameObject.name}] Agent initialized");
        }
        
        /// <summary>
        /// Reset the environment for a new episode
        /// </summary>
        public override void OnEpisodeBegin()
        {
            episodeStartTime = Time.time;
            stepCount = 0;
            boxesPackedThisEpisode = 0;

            // Invalidate action mask cache
            actionMaskCacheValid = false;

            // Reset pallet to empty state
            palletManager.Reset();

            // Generate new box set based on curriculum
            int numBoxes = GetCurrentBoxCount();
            remainingBoxes = boxSpawner.GenerateBoxSet(numBoxes);

            // Get first box
            currentBox = GetNextBox();
            
            // Clear visualization
            if (visualizationManager != null)
            {
                visualizationManager.ClearVisualizations();
            }
            
            if (debugMode)
            {
                Debug.Log($"[{gameObject.name}] Episode started with {numBoxes} boxes");
            }
        }
        
        /// <summary>
        /// Collect observations for the agent
        /// </summary>
        public override void CollectObservations(VectorSensor sensor)
        {
            // === PALLET STATE OBSERVATIONS ===
            
            // Overall pallet statistics (4 values)
            sensor.AddObservation(palletManager.GetFillPercentage());        // 0-1
            sensor.AddObservation(palletManager.GetAvailableVolume() / 
                                palletManager.GetTotalVolume());             // 0-1
            sensor.AddObservation(palletManager.GetMaxHeight() / 
                                palletManager.palletSize.y);                 // 0-1
            sensor.AddObservation(palletManager.GetAverageHeight() / 
                                palletManager.palletSize.y);                 // 0-1
            
            // Surface quality metrics (3 values)
            sensor.AddObservation(palletManager.GetSurfaceFlatness());       // 0-1
            sensor.AddObservation(palletManager.GetSurfaceFragmentation());  // 0-1
            sensor.AddObservation(palletManager.GetStabilityScore());        // 0-1
            
            // === CURRENT BOX OBSERVATIONS ===
            
            if (currentBox != null)
            {
                // Normalized dimensions (3 values)
                Vector3 normalizedSize = new Vector3(
                    currentBox.size.x / palletManager.palletSize.x,
                    currentBox.size.y / palletManager.palletSize.y,
                    currentBox.size.z / palletManager.palletSize.z
                );
                sensor.AddObservation(normalizedSize);
                
                // Volume ratio (1 value)
                float volumeRatio = currentBox.GetVolume() / palletManager.GetTotalVolume();
                sensor.AddObservation(volumeRatio);
                
                // Weight ratio (1 value)
                sensor.AddObservation(currentBox.weight / palletManager.maxWeight);
                
                // Aspect ratios (2 values) - helps understand box shape
                sensor.AddObservation(currentBox.size.x / currentBox.size.y);
                sensor.AddObservation(currentBox.size.x / currentBox.size.z);
            }
            else
            {
                // No current box - pad with zeros (7 values)
                sensor.AddObservation(Vector3.zero);
                sensor.AddObservation(0f);
                sensor.AddObservation(0f);
                sensor.AddObservation(0f);
                sensor.AddObservation(0f);
            }
            
            // === UPCOMING BOXES PREVIEW ===
            
            // Preview next N boxes (helps with planning)
            for (int i = 0; i < boxPreviewCount; i++)
            {
                if (i < remainingBoxes.Count)
                {
                    Box nextBox = remainingBoxes[i];
                    Vector3 normalizedSize = new Vector3(
                        nextBox.size.x / palletManager.palletSize.x,
                        nextBox.size.y / palletManager.palletSize.y,
                        nextBox.size.z / palletManager.palletSize.z
                    );
                    sensor.AddObservation(normalizedSize);
                    sensor.AddObservation(nextBox.GetVolume() / palletManager.GetTotalVolume());
                }
                else
                {
                    // No more boxes - pad with zeros (4 values per box)
                    sensor.AddObservation(Vector3.zero);
                    sensor.AddObservation(0f);
                }
            }
            
            // === EPISODE CONTEXT ===
            
            // Remaining boxes count (normalized) (1 value)
            sensor.AddObservation(remainingBoxes.Count / (float)maxBoxesPerEpisode);
            
            // Progress through episode (1 value)
            sensor.AddObservation(boxesPackedThisEpisode / (float)maxBoxesPerEpisode);
            
            // Step efficiency (1 value)
            sensor.AddObservation(stepCount / (float)maxSteps);
            
            // === HEIGHT MAP (OPTIONAL) ===
            
            if (includeHeightMap)
            {
                // Add simplified height map as observations
                float[,] heightMap = palletManager.GetHeightMap(heightMapResolution);
                for (int x = 0; x < heightMapResolution; x++)
                {
                    for (int z = 0; z < heightMapResolution; z++)
                    {
                        sensor.AddObservation(heightMap[x, z] / palletManager.palletSize.y);
                    }
                }
            }
            
            // Total observations:
            // - Pallet: 7
            // - Current box: 7
            // - Preview boxes: boxPreviewCount * 4 (default 5 * 4 = 20)
            // - Context: 3
            // - Height map: heightMapResolution^2 (optional, default 10*10 = 100)
            // Total: 37 + 100 = 137 (with height map) or 37 (without)
        }
        
        /// <summary>
        /// Mask out invalid actions to improve learning efficiency
        /// This prevents the agent from wasting exploration on impossible placements
        /// </summary>
        public override void WriteDiscreteActionMask(IDiscreteActionMask actionMask)
        {
            // If no current box, don't mask anything (episode should end naturally)
            if (currentBox == null)
            {
                actionMaskCacheValid = false;
                return;
            }

            // Check each possible action and mask invalid ones
            int numRotations = 4;
            int totalGridPositions = gridResolution * gridResolution;
            hasAnyValidAction = false;  // Cache this result for use in OnActionReceived

            for (int rotation = 0; rotation < numRotations; rotation++)
            {
                for (int x = 0; x < gridResolution; x++)
                {
                    for (int z = 0; z < gridResolution; z++)
                    {
                        // Calculate action index
                        int actionIndex = rotation * totalGridPositions + x * gridResolution + z;

                        // Decode action to placement
                        PlacementAction placement = DecodeAction(actionIndex);

                        // Validate placement
                        bool isValid = placementValidator.ValidatePlacement(
                            currentBox, placement, palletManager
                        );

                        // Track if we have at least one valid action
                        if (isValid)
                        {
                            hasAnyValidAction = true;
                        }

                        // Mask invalid actions (disable them)
                        actionMask.SetActionEnabled(0, actionIndex, isValid);
                    }
                }
            }

            // Mark cache as valid (so we don't recheck in OnActionReceived)
            actionMaskCacheValid = true;

            // If NO valid actions exist, unmask action 0 and handle in OnActionReceived
            // This prevents ML-Agents from throwing an exception
            if (!hasAnyValidAction)
            {
                // Unmask first action as a "failure signal"
                actionMask.SetActionEnabled(0, 0, true);

                if (debugMode)
                {
                    Debug.LogWarning($"[{gameObject.name}] No valid placements for current box! " +
                                   $"Box size: {currentBox.size}, Pallet fill: {palletManager.GetFillPercentage():P}");
                }
            }
        }

        /// <summary>
        /// Execute the action chosen by the agent
        /// </summary>
        public override void OnActionReceived(ActionBuffers actions)
        {
            stepCount++;
            
            // Check if episode should end
            if (currentBox == null)
            {
                // No more boxes - successful completion
                EndEpisodeSuccess();
                return;
            }
            
            if (stepCount >= maxSteps)
            {
                // Timeout
                AddReward(-5.0f);
                EndEpisode();
                return;
            }
            
            // Decode action into placement
            int actionIndex = actions.DiscreteActions[0];
            PlacementAction placement = DecodeAction(actionIndex);

            // Check if we're in a "no valid actions" state using cached result from action masking
            // This avoids re-validating all 400 actions (huge performance improvement!)
            bool noValidPlacements = actionMaskCacheValid && !hasAnyValidAction;

            if (noValidPlacements)
            {
                // No valid placements possible for this box - end episode
                float penalty = -5.0f;
                AddReward(penalty);

                if (debugMode)
                {
                    Debug.Log($"[{gameObject.name}] Episode ended - no valid placements for box. " +
                             $"Boxes packed: {boxesPackedThisEpisode}/{maxBoxesPerEpisode}, Penalty: {penalty}");
                }

                EndEpisode();
                return;
            }

            // Visualize proposed placement
            if (visualizeActions && visualizationManager != null)
            {
                visualizationManager.VisualizeProposedPlacement(currentBox, placement);
            }

            // Validate placement
            bool isValid = placementValidator.ValidatePlacement(
                currentBox, placement, palletManager
            );

            if (isValid)
            {
                // Valid placement - place the box
                palletManager.PlaceBox(currentBox, placement);
                boxesPackedThisEpisode++;
                
                // Calculate reward
                float reward = rewardCalculator.CalculatePlacementReward(
                    currentBox, placement, palletManager
                );
                AddReward(reward);
                
                // Update visualization
                if (visualizationManager != null)
                {
                    visualizationManager.UpdatePalletVisualization(palletManager);
                }
                
                // Check for completion
                if (remainingBoxes.Count == 0)
                {
                    EndEpisodeSuccess();
                    return;
                }
                
                // Get next box
                currentBox = GetNextBox();

                // Invalidate action mask cache for new box
                actionMaskCacheValid = false;

                if (debugMode)
                {
                    Debug.Log($"[{gameObject.name}] Box placed successfully. " +
                             $"Reward: {reward:F3}, Packed: {boxesPackedThisEpisode}/{maxBoxesPerEpisode}");
                }
            }
            else
            {
                // Invalid placement
                float penalty = rewardCalculator.GetInvalidPlacementPenalty();
                AddReward(penalty);
                
                if (debugMode)
                {
                    Debug.Log($"[{gameObject.name}] Invalid placement. Penalty: {penalty:F3}");
                }
                
                if (endOnInvalidPlacement)
                {
                    // End episode on invalid placement (harder training)
                    EndEpisode();
                    return;
                }
                // Otherwise continue to next step
            }
            
            // Small step penalty to encourage efficiency
            AddReward(stepPenalty);
        }
        
        /// <summary>
        /// For manual control/testing
        /// </summary>
        public override void Heuristic(in ActionBuffers actionsOut)
        {
            var discreteActions = actionsOut.DiscreteActions;
            
            // Simple heuristic: try to place box at lowest available position
            // This is useful for:
            // 1. Testing the environment
            // 2. Generating demonstration data
            // 3. Debugging
            
            if (currentBox == null)
            {
                discreteActions[0] = 0;
                return;
            }
            
            // Find best placement using heuristic
            int bestAction = GetHeuristicAction();
            discreteActions[0] = bestAction;
        }
        
        #endregion
        
        #region Helper Methods
        
        /// <summary>
        /// Get the next box from the queue
        /// </summary>
        private Box GetNextBox()
        {
            if (remainingBoxes.Count > 0)
            {
                Box box = remainingBoxes[0];
                remainingBoxes.RemoveAt(0);
                return box;
            }
            return null;
        }
        
        /// <summary>
        /// Decode a discrete action index into a placement action
        /// </summary>
        private PlacementAction DecodeAction(int actionIndex)
        {
            // Action space structure:
            // Total actions = gridResolution × gridResolution × numRotations
            // Where numRotations = 4 (0°, 90°, 180°, 270°)
            
            int numRotations = 4;
            int totalGridPositions = gridResolution * gridResolution;
            
            // Extract rotation
            int rotationIndex = actionIndex / totalGridPositions;
            rotationIndex = Mathf.Clamp(rotationIndex, 0, numRotations - 1);
            
            // Extract grid position
            int gridIndex = actionIndex % totalGridPositions;
            int xIndex = gridIndex / gridResolution;
            int zIndex = gridIndex % gridResolution;
            
            // Convert to world position
            Vector3 position = GridToWorldPosition(xIndex, zIndex);
            
            // Convert to rotation
            int rotationDegrees = rotationIndex * 90;
            
            return new PlacementAction(position, rotationDegrees);
        }
        
        /// <summary>
        /// Convert grid coordinates to world position
        /// </summary>
        private Vector3 GridToWorldPosition(int xIndex, int zIndex)
        {
            // Map grid indices to world coordinates
            float xPos = (xIndex + 0.5f) / gridResolution * palletManager.palletSize.x;
            float zPos = (zIndex + 0.5f) / gridResolution * palletManager.palletSize.z;
            
            // Y position determined by height map
            float yPos = palletManager.GetHeightAt(xPos, zPos);
            
            return new Vector3(xPos, yPos, zPos);
        }
        
        /// <summary>
        /// Get heuristic action for manual control or demonstration
        /// </summary>
        private int GetHeuristicAction()
        {
            // Simple heuristic: place at lowest position with best support
            // This implements a basic "Bottom-Left-Fill" strategy
            
            float bestScore = float.MinValue;
            int bestAction = 0;
            
            int numRotations = 4;
            
            for (int rotation = 0; rotation < numRotations; rotation++)
            {
                for (int x = 0; x < gridResolution; x++)
                {
                    for (int z = 0; z < gridResolution; z++)
                    {
                        int actionIndex = rotation * (gridResolution * gridResolution) + 
                                        x * gridResolution + z;
                        
                        PlacementAction placement = DecodeAction(actionIndex);
                        
                        if (placementValidator.ValidatePlacement(currentBox, placement, palletManager))
                        {
                            // Score based on:
                            // - Low height (prefer lower placements)
                            // - Good support
                            // - Corner preference
                            float score = HeuristicScore(placement);
                            
                            if (score > bestScore)
                            {
                                bestScore = score;
                                bestAction = actionIndex;
                            }
                        }
                    }
                }
            }
            
            return bestAction;
        }
        
        /// <summary>
        /// Calculate heuristic score for a placement
        /// </summary>
        private float HeuristicScore(PlacementAction placement)
        {
            float score = 0f;
            
            // Prefer lower placements
            score -= placement.position.y / palletManager.palletSize.y * 10f;
            
            // Prefer positions with good support
            float supportRatio = palletManager.GetSupportRatio(currentBox, placement);
            score += supportRatio * 5f;
            
            // Prefer corners and edges (for stability)
            float cornerDistance = GetCornerDistance(placement.position);
            score -= cornerDistance * 2f;
            
            return score;
        }
        
        /// <summary>
        /// Check if there are any valid placements for the current box
        /// </summary>
        private bool HasAnyValidPlacement()
        {
            if (currentBox == null)
                return false;

            int numRotations = 4;
            int totalGridPositions = gridResolution * gridResolution;

            // Quick check: test a subset of actions to see if any are valid
            for (int rotation = 0; rotation < numRotations; rotation++)
            {
                for (int x = 0; x < gridResolution; x++)
                {
                    for (int z = 0; z < gridResolution; z++)
                    {
                        int actionIndex = rotation * totalGridPositions + x * gridResolution + z;
                        PlacementAction placement = DecodeAction(actionIndex);

                        if (placementValidator.ValidatePlacement(currentBox, placement, palletManager))
                        {
                            return true; // Found at least one valid placement
                        }
                    }
                }
            }

            return false; // No valid placements found
        }

        /// <summary>
        /// Get distance to nearest corner
        /// </summary>
        private float GetCornerDistance(Vector3 position)
        {
            Vector3 palletSize = palletManager.palletSize;
            
            Vector3[] corners = new Vector3[]
            {
                new Vector3(0, 0, 0),
                new Vector3(palletSize.x, 0, 0),
                new Vector3(0, 0, palletSize.z),
                new Vector3(palletSize.x, 0, palletSize.z)
            };
            
            float minDistance = float.MaxValue;
            foreach (Vector3 corner in corners)
            {
                float distance = Vector3.Distance(
                    new Vector3(position.x, 0, position.z),
                    corner
                );
                minDistance = Mathf.Min(minDistance, distance);
            }
            
            return minDistance / Mathf.Max(palletSize.x, palletSize.z);
        }
        
        /// <summary>
        /// End episode with success bonus
        /// </summary>
        private void EndEpisodeSuccess()
        {
            float episodeDuration = Time.time - episodeStartTime;
            float efficiency = palletManager.GetFillPercentage();
            
            // Completion bonus
            float completionBonus = 10.0f;
            AddReward(completionBonus);
            
            // Efficiency bonus (scales with packing efficiency)
            float efficiencyBonus = efficiency * 5.0f;
            AddReward(efficiencyBonus);
            
            // Speed bonus (penalize slow packing)
            float speedBonus = Mathf.Max(0, 2.0f - episodeDuration / 60f);
            AddReward(speedBonus);
            
            // Update statistics for curriculum
            UpdateStatistics(efficiency);
            
            if (debugMode)
            {
                Debug.Log($"[{gameObject.name}] Episode completed successfully!\n" +
                         $"Efficiency: {efficiency:P}, Duration: {episodeDuration:F1}s, " +
                         $"Total Reward: {GetCumulativeReward():F2}");
            }
            
            EndEpisode();
        }
        
        /// <summary>
        /// Get number of boxes for current curriculum level
        /// </summary>
        private int GetCurrentBoxCount()
        {
            // This can be controlled by Academy parameters for curriculum learning
            // For now, return configured value
            return maxBoxesPerEpisode;
        }
        
        /// <summary>
        /// Update training statistics
        /// </summary>
        private void UpdateStatistics(float efficiency)
        {
            totalEpisodesCompleted++;
            averagePackingEfficiency = 
                (averagePackingEfficiency * (totalEpisodesCompleted - 1) + efficiency) / 
                totalEpisodesCompleted;
        }
        
        #endregion
        
        #region Public Methods
        
        /// <summary>
        /// Get current training statistics
        /// </summary>
        public (float avgEfficiency, int episodes) GetStatistics()
        {
            return (averagePackingEfficiency, totalEpisodesCompleted);
        }
        
        /// <summary>
        /// Reset statistics (for curriculum advancement)
        /// </summary>
        public void ResetStatistics()
        {
            averagePackingEfficiency = 0f;
            totalEpisodesCompleted = 0;
        }
        
        #endregion
    }
}
