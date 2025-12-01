using UnityEngine;

namespace BoxPacking.MLAgents
{
    /// <summary>
    /// Represents a 3D box to be packed
    /// </summary>
    [System.Serializable]
    public class Box
    {
        public int id;
        public Vector3 size;
        public float weight;
        public Color color;
        
        // Optional properties for advanced scenarios
        public bool isFragile = false;
        public bool canBeRotated = true;
        public int stackLimit = 0; // 0 = no limit
        public string category = "";
        
        /// <summary>
        /// Calculate volume of the box
        /// </summary>
        public float GetVolume()
        {
            return size.x * size.y * size.z;
        }
        
        /// <summary>
        /// Calculate surface area of the box
        /// </summary>
        public float GetSurfaceArea()
        {
            return 2 * (size.x * size.y + size.x * size.z + size.y * size.z);
        }
        
        /// <summary>
        /// Get aspect ratio (longest dimension / shortest dimension)
        /// </summary>
        public float GetAspectRatio()
        {
            float max = Mathf.Max(size.x, Mathf.Max(size.y, size.z));
            float min = Mathf.Min(size.x, Mathf.Min(size.y, size.z));
            return max / min;
        }
        
        /// <summary>
        /// Check if box is approximately cubic
        /// </summary>
        public bool IsCubic(float tolerance = 0.2f)
        {
            float avg = (size.x + size.y + size.z) / 3f;
            
            return Mathf.Abs(size.x - avg) / avg < tolerance &&
                   Mathf.Abs(size.y - avg) / avg < tolerance &&
                   Mathf.Abs(size.z - avg) / avg < tolerance;
        }
        
        /// <summary>
        /// Get the base area (for support calculations)
        /// </summary>
        public float GetBaseArea(int rotation = 0)
        {
            int normalizedRotation = ((rotation % 360) + 360) % 360;
            
            if (normalizedRotation == 90 || normalizedRotation == 270)
            {
                return size.z * size.x;
            }
            
            return size.x * size.z;
        }
        
        /// <summary>
        /// Clone this box
        /// </summary>
        public Box Clone()
        {
            return new Box
            {
                id = this.id,
                size = this.size,
                weight = this.weight,
                color = this.color,
                isFragile = this.isFragile,
                canBeRotated = this.canBeRotated,
                stackLimit = this.stackLimit,
                category = this.category
            };
        }
        
        public override string ToString()
        {
            return $"Box {id}: Size({size.x:F1},{size.y:F1},{size.z:F1}), Weight: {weight:F1}, Volume: {GetVolume():F1}";
        }
    }
    
    /// <summary>
    /// Represents a placement action (position and orientation)
    /// </summary>
    [System.Serializable]
    public class PlacementAction
    {
        public Vector3 position;
        public int rotation; // Rotation in degrees (typically 0, 90, 180, 270)
        
        public PlacementAction()
        {
            position = Vector3.zero;
            rotation = 0;
        }
        
        public PlacementAction(Vector3 position, int rotation)
        {
            this.position = position;
            this.rotation = rotation;
        }
        
        /// <summary>
        /// Get rotation as quaternion
        /// </summary>
        public Quaternion GetRotationQuaternion()
        {
            return Quaternion.Euler(0, rotation, 0);
        }
        
        /// <summary>
        /// Get normalized rotation (0-359)
        /// </summary>
        public int GetNormalizedRotation()
        {
            return ((rotation % 360) + 360) % 360;
        }
        
        /// <summary>
        /// Check if two placements are approximately equal
        /// </summary>
        public bool ApproximatelyEquals(PlacementAction other, float positionTolerance = 0.1f, int rotationTolerance = 5)
        {
            if (other == null)
                return false;
            
            bool positionMatch = Vector3.Distance(this.position, other.position) < positionTolerance;
            
            int rotDiff = Mathf.Abs(GetNormalizedRotation() - other.GetNormalizedRotation());
            rotDiff = Mathf.Min(rotDiff, 360 - rotDiff); // Handle wraparound
            bool rotationMatch = rotDiff < rotationTolerance;
            
            return positionMatch && rotationMatch;
        }
        
        public override string ToString()
        {
            return $"Placement: Pos({position.x:F1},{position.y:F1},{position.z:F1}), Rot: {rotation}°";
        }
        
        public PlacementAction Clone()
        {
            return new PlacementAction(position, rotation);
        }
    }
}
