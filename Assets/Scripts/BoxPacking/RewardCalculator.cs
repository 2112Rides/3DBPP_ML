using UnityEngine;

namespace BoxPacking.MLAgents
{
    /// <summary>
    /// Calculates rewards for box placement actions
    /// </summary>
    public class RewardCalculator : MonoBehaviour
    {
        #region Serialized Fields
        
        [Header("Base Rewards")]
        [Tooltip("Reward for successful placement")]
        [SerializeField] private float successReward = 1.5f;  // Optimized for action masking

        [Tooltip("Penalty for invalid placement")]
        [SerializeField] private float invalidPlacementPenalty = -1.0f;  // Reduced - rarely used with action masking

        [Header("Volume Efficiency")]
        [Tooltip("Weight for volume utilization reward")]
        [SerializeField] private float volumeWeight = 0.8f;  // Increased to encourage packing larger boxes
        
        [Tooltip("Bonus for efficient volume usage")]
        [SerializeField] private float volumeEfficiencyBonus = 0.3f;
        
        [Header("Placement Quality")]
        [Tooltip("Reward for creating flat surfaces")]
        [SerializeField] private float flatSurfaceBonus = 0.5f;
        
        [Tooltip("Reward for good support")]
        [SerializeField] private float supportQualityWeight = 0.3f;
        
        [Tooltip("Penalty for high placement (less stable)")]
        [SerializeField] private float heightPenaltyWeight = 0.2f;
        
        [Header("Strategic Placement")]
        [Tooltip("Reward for corner/edge placement")]
        [SerializeField] private float cornerPlacementBonus = 0.2f;
        
        [Tooltip("Reward for creating useful surfaces")]
        [SerializeField] private float surfaceCreationBonus = 0.4f;
        
        [Tooltip("Penalty for creating gaps")]
        [SerializeField] private float gapPenaltyWeight = 0.2f;
        
        [Header("Stability")]
        [Tooltip("Reward weight for stability")]
        [SerializeField] private float stabilityWeight = 0.3f;
        
        [Header("Reward Shaping")]
        [Tooltip("Use shaped rewards (more guidance)")]
        [SerializeField] private bool useRewardShaping = true;

        [Tooltip("Reward shaping complexity (0=simple, 1=complex)")]
        [SerializeField] private float shapingComplexity = 1.0f;  // Maximized for action masking - stronger signals
        
        #endregion
        
        #region Public Methods
        
        /// <summary>
        /// Calculate reward for a successful placement
        /// </summary>
        public float CalculatePlacementReward(Box box, PlacementAction placement, PalletManager palletManager)
        {
            if (!useRewardShaping)
            {
                return CalculateSimpleReward(box, placement, palletManager);
            }
            
            float reward = 0f;
            
            // Base success reward
            reward += successReward;
            
            // Volume efficiency
            reward += CalculateVolumeReward(box, palletManager);
            
            // Placement quality
            reward += CalculatePlacementQualityReward(box, placement, palletManager);
            
            // Strategic value
            reward += CalculateStrategicReward(box, placement, palletManager);
            
            // Stability contribution
            reward += CalculateStabilityReward(box, placement, palletManager);
            
            return reward * Mathf.Lerp(0.5f, 1.0f, shapingComplexity);
        }
        
        /// <summary>
        /// Get penalty for invalid placement
        /// </summary>
        public float GetInvalidPlacementPenalty()
        {
            return invalidPlacementPenalty;
        }
        
        #endregion
        
        #region Reward Components
        
        /// <summary>
        /// Simple reward based only on volume
        /// </summary>
        private float CalculateSimpleReward(Box box, PlacementAction placement, PalletManager palletManager)
        {
            float volumeRatio = box.GetVolume() / palletManager.GetTotalVolume();
            return successReward + volumeRatio * volumeWeight;
        }
        
        /// <summary>
        /// Calculate reward based on volume utilization
        /// </summary>
        private float CalculateVolumeReward(Box box, PalletManager palletManager)
        {
            // Reward proportional to box volume
            float volumeRatio = box.GetVolume() / palletManager.GetTotalVolume();
            float baseVolumeReward = volumeRatio * volumeWeight;
            
            // Bonus for maintaining high efficiency
            float currentEfficiency = palletManager.GetFillPercentage();
            float efficiencyBonus = 0f;
            
            if (currentEfficiency > 0.5f)
            {
                efficiencyBonus = (currentEfficiency - 0.5f) * volumeEfficiencyBonus;
            }
            
            return baseVolumeReward + efficiencyBonus;
        }
        
        /// <summary>
        /// Calculate reward based on placement quality
        /// </summary>
        private float CalculatePlacementQualityReward(Box box, PlacementAction placement, PalletManager palletManager)
        {
            float reward = 0f;
            
            // 1. Support quality
            float supportRatio = palletManager.GetSupportRatio(box, placement);
            reward += supportRatio * supportQualityWeight;
            
            // 2. Height penalty (lower is better for stability)
            float heightRatio = placement.position.y / palletManager.palletSize.y;
            reward -= heightRatio * heightPenaltyWeight;
            
            // 3. Surface flatness contribution
            float flatnessImprovement = CalculateFlatnessImprovement(box, placement, palletManager);
            if (flatnessImprovement > 0)
            {
                reward += flatnessImprovement * flatSurfaceBonus;
            }
            
            return reward;
        }
        
        /// <summary>
        /// Calculate reward for strategic placement
        /// </summary>
        private float CalculateStrategicReward(Box box, PlacementAction placement, PalletManager palletManager)
        {
            float reward = 0f;
            
            // 1. Corner/edge placement bonus (for stability)
            float cornerScore = CalculateCornerScore(placement.position, palletManager.palletSize);
            reward += cornerScore * cornerPlacementBonus;
            
            // 2. Surface creation bonus
            float surfaceQuality = CalculateSurfaceCreationQuality(box, placement, palletManager);
            reward += surfaceQuality * surfaceCreationBonus;
            
            // 3. Gap penalty
            float gapScore = CalculateGapPenalty(box, placement, palletManager);
            reward -= gapScore * gapPenaltyWeight;
            
            return reward;
        }
        
        /// <summary>
        /// Calculate reward for stability contribution
        /// </summary>
        private float CalculateStabilityReward(Box box, PlacementAction placement, PalletManager palletManager)
        {
            float stabilityScore = palletManager.GetStabilityScore();
            return stabilityScore * stabilityWeight;
        }
        
        #endregion
        
        #region Helper Methods
        
        /// <summary>
        /// Calculate how much this placement improves surface flatness
        /// </summary>
        private float CalculateFlatnessImprovement(Box box, PlacementAction placement, PalletManager palletManager)
        {
            // Check if this box fills a gap or creates a level surface
            Vector3 rotatedSize = GetRotatedSize(box.size, placement.rotation);
            float boxTop = placement.position.y + rotatedSize.y;
            
            // Sample surrounding heights
            float avgSurroundingHeight = 0f;
            int samples = 4;
            int count = 0;
            
            for (int dx = -1; dx <= 1; dx += 2)
            {
                for (int dz = -1; dz <= 1; dz += 2)
                {
                    float x = placement.position.x + dx * rotatedSize.x;
                    float z = placement.position.z + dz * rotatedSize.z;
                    
                    if (x >= 0 && x <= palletManager.palletSize.x &&
                        z >= 0 && z <= palletManager.palletSize.z)
                    {
                        avgSurroundingHeight += palletManager.GetHeightAt(x, z);
                        count++;
                    }
                }
            }
            
            if (count > 0)
            {
                avgSurroundingHeight /= count;
                
                // Reward if box top is close to surrounding height (levels surface)
                float heightDifference = Mathf.Abs(boxTop - avgSurroundingHeight);
                float normalizedDifference = heightDifference / palletManager.palletSize.y;
                
                return 1f - normalizedDifference;
            }
            
            return 0f;
        }
        
        /// <summary>
        /// Calculate corner/edge placement score
        /// </summary>
        private float CalculateCornerScore(Vector3 position, Vector3 palletSize)
        {
            // Normalize position to 0-1
            float nx = position.x / palletSize.x;
            float nz = position.z / palletSize.z;
            
            // Calculate distance from edges
            float xEdgeDistance = Mathf.Min(nx, 1f - nx);
            float zEdgeDistance = Mathf.Min(nz, 1f - nz);
            
            // Closer to edge = higher score
            float edgeScore = 1f - Mathf.Min(xEdgeDistance, zEdgeDistance) * 2f;
            
            return Mathf.Clamp01(edgeScore);
        }
        
        /// <summary>
        /// Calculate quality of surface created by this box
        /// </summary>
        private float CalculateSurfaceCreationQuality(Box box, PlacementAction placement, PalletManager palletManager)
        {
            Vector3 rotatedSize = GetRotatedSize(box.size, placement.rotation);
            
            // Larger top surface = better for future placements
            float topSurfaceArea = rotatedSize.x * rotatedSize.z;
            float palletBaseArea = palletManager.palletSize.x * palletManager.palletSize.z;
            
            float surfaceRatio = topSurfaceArea / palletBaseArea;
            
            // Bonus for boxes that create usable surfaces
            return Mathf.Clamp01(surfaceRatio * 2f);
        }
        
        /// <summary>
        /// Calculate penalty for creating gaps
        /// </summary>
        private float CalculateGapPenalty(Box box, PlacementAction placement, PalletManager palletManager)
        {
            // Penalize if this placement creates unusable gaps
            // This is approximated by surface fragmentation
            
            float fragmentationBefore = palletManager.GetSurfaceFragmentation();
            
            // Estimate fragmentation increase (simplified)
            Vector3 rotatedSize = GetRotatedSize(box.size, placement.rotation);
            float sizeRatio = Mathf.Min(rotatedSize.x, rotatedSize.z) / 
                            Mathf.Max(palletManager.palletSize.x, palletManager.palletSize.z);
            
            // Smaller boxes relative to pallet = more likely to create gaps
            float gapRisk = 1f - sizeRatio;
            
            return gapRisk * 0.5f;
        }
        
        /// <summary>
        /// Get rotated box size
        /// </summary>
        private Vector3 GetRotatedSize(Vector3 size, int rotation)
        {
            int normalizedRotation = ((rotation % 360) + 360) % 360;
            
            if (normalizedRotation == 90 || normalizedRotation == 270)
            {
                return new Vector3(size.z, size.y, size.x);
            }
            
            return size;
        }
        
        #endregion
        
        #region Configuration

        public void SetRewardShaping(bool enable)
        {
            useRewardShaping = enable;
        }

        public void SetShapingComplexity(float complexity)
        {
            shapingComplexity = Mathf.Clamp01(complexity);
        }

        public void SetSuccessReward(float reward)
        {
            successReward = reward;
        }

        public void SetInvalidPenalty(float penalty)
        {
            invalidPlacementPenalty = penalty;
        }

        // Volume efficiency setters
        public void SetVolumeWeight(float weight)
        {
            volumeWeight = weight;
        }

        public void SetVolumeEfficiencyBonus(float bonus)
        {
            volumeEfficiencyBonus = bonus;
        }

        // Placement quality setters
        public void SetFlatSurfaceBonus(float bonus)
        {
            flatSurfaceBonus = bonus;
        }

        public void SetSupportQualityWeight(float weight)
        {
            supportQualityWeight = weight;
        }

        public void SetHeightPenaltyWeight(float weight)
        {
            heightPenaltyWeight = weight;
        }

        // Strategic placement setters
        public void SetCornerPlacementBonus(float bonus)
        {
            cornerPlacementBonus = bonus;
        }

        public void SetSurfaceCreationBonus(float bonus)
        {
            surfaceCreationBonus = bonus;
        }

        public void SetGapPenaltyWeight(float weight)
        {
            gapPenaltyWeight = weight;
        }

        // Stability setter
        public void SetStabilityWeight(float weight)
        {
            stabilityWeight = weight;
        }

        #endregion
    }
}
