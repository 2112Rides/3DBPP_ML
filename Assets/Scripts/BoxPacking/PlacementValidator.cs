using UnityEngine;

namespace BoxPacking.MLAgents
{
    /// <summary>
    /// Validates whether a box placement is legal according to physical constraints
    /// </summary>
    public class PlacementValidator : MonoBehaviour
    {
        #region Serialized Fields
        
        [Header("Validation Settings")]
        [Tooltip("Minimum support ratio required (0-1)")]
        [SerializeField] private float minSupportRatio = 0.7f;
        
        [Tooltip("Tolerance for boundary checks")]
        [SerializeField] private float boundaryTolerance = 0.01f;
        
        [Tooltip("Check weight constraints")]
        [SerializeField] private bool checkWeight = true;
        
        [Tooltip("Check stability constraints")]
        [SerializeField] private bool checkStability = true;
        
        [Tooltip("Allow floating boxes (boxes without support)")]
        [SerializeField] private bool allowFloating = false;
        
        [Header("Debug")]
        [SerializeField] private bool debugValidation = false;
        
        #endregion
        
        #region Public Methods
        
        /// <summary>
        /// Validate if a box can be placed at the given position
        /// </summary>
        public bool ValidatePlacement(Box box, PlacementAction placement, PalletManager palletManager)
        {
            // Check 1: Box must be within pallet boundaries
            if (!CheckBounds(box, placement, palletManager))
            {
                if (debugValidation)
                    Debug.Log("Validation failed: Out of bounds");
                return false;
            }
            
            // Check 2: No overlap with existing boxes
            if (CheckOverlap(box, placement, palletManager))
            {
                if (debugValidation)
                    Debug.Log("Validation failed: Overlap detected");
                return false;
            }
            
            // Check 3: Adequate support (unless floating is allowed)
            if (!allowFloating && checkStability)
            {
                float supportRatio = palletManager.GetSupportRatio(box, placement);
                if (supportRatio < minSupportRatio)
                {
                    if (debugValidation)
                        Debug.Log($"Validation failed: Insufficient support ({supportRatio:F2} < {minSupportRatio:F2})");
                    return false;
                }
            }
            
            // Check 4: Weight constraint
            if (checkWeight)
            {
                if (palletManager.WouldExceedWeight(box))
                {
                    if (debugValidation)
                        Debug.Log("Validation failed: Weight limit exceeded");
                    return false;
                }
            }
            
            // Check 5: Placement position must be valid
            if (!IsValidPosition(placement.position, palletManager))
            {
                if (debugValidation)
                    Debug.Log("Validation failed: Invalid position");
                return false;
            }
            
            return true;
        }
        
        /// <summary>
        /// Check if box is within pallet boundaries
        /// </summary>
        public bool CheckBounds(Box box, PlacementAction placement, PalletManager palletManager)
        {
            Vector3 rotatedSize = GetRotatedSize(box.size, placement.rotation);
            Vector3 minPoint = placement.position;
            Vector3 maxPoint = placement.position + rotatedSize;
            
            Vector3 palletMin = Vector3.zero - Vector3.one * boundaryTolerance;
            Vector3 palletMax = palletManager.palletSize + Vector3.one * boundaryTolerance;
            
            bool withinBounds = 
                minPoint.x >= palletMin.x && maxPoint.x <= palletMax.x &&
                minPoint.y >= palletMin.y && maxPoint.y <= palletMax.y &&
                minPoint.z >= palletMin.z && maxPoint.z <= palletMax.z;
            
            return withinBounds;
        }
        
        /// <summary>
        /// Check if box overlaps with any existing boxes
        /// </summary>
        public bool CheckOverlap(Box box, PlacementAction placement, PalletManager palletManager)
        {
            return palletManager.CheckOverlap(box, placement);
        }
        
        /// <summary>
        /// Check if position is valid (e.g., not floating in air)
        /// </summary>
        public bool IsValidPosition(Vector3 position, PalletManager palletManager)
        {
            // Position Y should match height at XZ location (with small tolerance)
            float expectedHeight = palletManager.GetHeightAt(position.x, position.z);
            float tolerance = 1f;
            
            return Mathf.Abs(position.y - expectedHeight) < tolerance;
        }
        
        /// <summary>
        /// Get list of valid placements for a box
        /// </summary>
        public System.Collections.Generic.List<PlacementAction> GetValidPlacements(
            Box box, 
            PalletManager palletManager, 
            int gridResolution = 10)
        {
            var validPlacements = new System.Collections.Generic.List<PlacementAction>();
            
            int[] rotations = { 0, 90, 180, 270 };
            
            foreach (int rotation in rotations)
            {
                for (int x = 0; x < gridResolution; x++)
                {
                    for (int z = 0; z < gridResolution; z++)
                    {
                        float xPos = (x + 0.5f) / gridResolution * palletManager.palletSize.x;
                        float zPos = (z + 0.5f) / gridResolution * palletManager.palletSize.z;
                        float yPos = palletManager.GetHeightAt(xPos, zPos);
                        
                        PlacementAction placement = new PlacementAction(
                            new Vector3(xPos, yPos, zPos),
                            rotation
                        );
                        
                        if (ValidatePlacement(box, placement, palletManager))
                        {
                            validPlacements.Add(placement);
                        }
                    }
                }
            }
            
            return validPlacements;
        }
        
        #endregion
        
        #region Helper Methods
        
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
        
        public void SetMinSupportRatio(float ratio)
        {
            minSupportRatio = Mathf.Clamp01(ratio);
        }
        
        public void SetAllowFloating(bool allow)
        {
            allowFloating = allow;
        }
        
        public void SetCheckWeight(bool check)
        {
            checkWeight = check;
        }
        
        public void SetCheckStability(bool check)
        {
            checkStability = check;
        }
        
        #endregion
    }
}
