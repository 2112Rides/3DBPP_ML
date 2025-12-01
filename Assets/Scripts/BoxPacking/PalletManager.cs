using UnityEngine;
using System.Collections.Generic;
using System.Linq;

namespace BoxPacking.MLAgents
{
    /// <summary>
    /// Manages the state of the pallet, including placed boxes and spatial queries
    /// </summary>
    public class PalletManager : MonoBehaviour
    {
        #region Serialized Fields
        
        [Header("Pallet Configuration")]
        [Tooltip("Size of the pallet (width, height, depth)")]
        public Vector3 palletSize = new Vector3(100f, 200f, 100f);
        
        [Tooltip("Maximum weight capacity of pallet")]
        public float maxWeight = 1000f;
        
        [Tooltip("Voxel resolution for spatial grid")]
        [SerializeField] private float voxelSize = 5f;
        
        [Header("Physics Settings")]
        [Tooltip("Minimum support ratio required (0-1)")]
        [SerializeField] private float minSupportRatio = 0.7f;
        
        [Tooltip("Gravity acceleration for stability checks")]
        [SerializeField] private float gravity = 9.81f;
        
        [Header("Visualization")]
        [SerializeField] private bool showGizmos = true;
        [SerializeField] private Color palletColor = new Color(0.8f, 0.8f, 0.8f, 0.5f);
        [SerializeField] private Color occupiedVoxelColor = new Color(1f, 0.5f, 0f, 0.3f);
        
        #endregion
        
        #region Private Fields
        
        private List<PlacedBox> placedBoxes = new List<PlacedBox>();
        private HashSet<Vector3Int> occupiedVoxels = new HashSet<Vector3Int>();
        private float[,] heightMap;
        private int heightMapResolution;
        private float currentWeight;
        
        #endregion
        
        #region Initialization
        
        public void Initialize()
        {
            Reset();
            heightMapResolution = Mathf.CeilToInt(Mathf.Max(palletSize.x, palletSize.z) / voxelSize);
            heightMap = new float[heightMapResolution, heightMapResolution];
        }
        
        /// <summary>
        /// Reset pallet to empty state
        /// </summary>
        public void Reset()
        {
            // Clear all boxes
            foreach (var placedBox in placedBoxes)
            {
                if (placedBox.gameObject != null)
                {
                    Destroy(placedBox.gameObject);
                }
            }
            
            placedBoxes.Clear();
            occupiedVoxels.Clear();
            currentWeight = 0f;
            
            // Reset height map
            if (heightMap != null)
            {
                for (int x = 0; x < heightMapResolution; x++)
                {
                    for (int z = 0; z < heightMapResolution; z++)
                    {
                        heightMap[x, z] = 0f;
                    }
                }
            }
        }
        
        #endregion
        
        #region Box Placement
        
        /// <summary>
        /// Place a box on the pallet
        /// </summary>
        public PlacedBox PlaceBox(Box box, PlacementAction placement)
        {
            // Create visual representation
            GameObject boxObject = CreateBoxVisual(box, placement);
            
            // Store placed box info
            PlacedBox placedBox = new PlacedBox
            {
                box = box,
                placement = placement,
                gameObject = boxObject,
                bounds = CalculateBounds(box, placement)
            };
            
            placedBoxes.Add(placedBox);
            
            // Update occupancy grid
            UpdateOccupancy(placedBox, true);
            
            // Update height map
            UpdateHeightMap(placedBox);
            
            // Update weight
            currentWeight += box.weight;
            
            return placedBox;
        }
        
        /// <summary>
        /// Remove a box from the pallet
        /// </summary>
        public void RemoveBox(PlacedBox placedBox)
        {
            placedBoxes.Remove(placedBox);
            UpdateOccupancy(placedBox, false);
            currentWeight -= placedBox.box.weight;
            
            if (placedBox.gameObject != null)
            {
                Destroy(placedBox.gameObject);
            }
            
            RecalculateHeightMap();
        }
        
        #endregion
        
        #region Spatial Queries
        
        /// <summary>
        /// Check if a box at given placement would overlap with existing boxes
        /// </summary>
        public bool CheckOverlap(Box box, PlacementAction placement)
        {
            Bounds testBounds = CalculateBounds(box, placement);
            
            foreach (var placedBox in placedBoxes)
            {
                if (testBounds.Intersects(placedBox.bounds))
                {
                    return true; // Overlap detected
                }
            }
            
            return false;
        }
        
        /// <summary>
        /// Check if box is within pallet boundaries
        /// </summary>
        public bool CheckBounds(Box box, PlacementAction placement)
        {
            Bounds testBounds = CalculateBounds(box, placement);
            Bounds palletBounds = new Bounds(
                transform.position + palletSize / 2f,
                palletSize
            );
            
            return palletBounds.Contains(testBounds.min) && 
                   palletBounds.Contains(testBounds.max);
        }
        
        /// <summary>
        /// Calculate support ratio for a box at given placement
        /// </summary>
        public float GetSupportRatio(Box box, PlacementAction placement)
        {
            if (placement.position.y <= 0.01f)
            {
                // Box is on the ground - full support
                return 1.0f;
            }
            
            // Calculate base area of the box
            Vector3 boxSize = GetRotatedSize(box.size, placement.rotation);
            float baseArea = boxSize.x * boxSize.z;
            
            // Check how much of the base is supported
            float supportedArea = CalculateSupportedArea(box, placement);
            
            return supportedArea / baseArea;
        }
        
        /// <summary>
        /// Get height at specific XZ position
        /// </summary>
        public float GetHeightAt(float x, float z)
        {
            if (heightMap == null)
                return 0f;
            
            int gridX = Mathf.Clamp(
                Mathf.FloorToInt(x / palletSize.x * heightMapResolution),
                0, heightMapResolution - 1
            );
            int gridZ = Mathf.Clamp(
                Mathf.FloorToInt(z / palletSize.z * heightMapResolution),
                0, heightMapResolution - 1
            );
            
            return heightMap[gridX, gridZ];
        }
        
        /// <summary>
        /// Get height map at specified resolution
        /// </summary>
        public float[,] GetHeightMap(int resolution)
        {
            float[,] resizedMap = new float[resolution, resolution];
            
            for (int x = 0; x < resolution; x++)
            {
                for (int z = 0; z < resolution; z++)
                {
                    float worldX = (x + 0.5f) / resolution * palletSize.x;
                    float worldZ = (z + 0.5f) / resolution * palletSize.z;
                    resizedMap[x, z] = GetHeightAt(worldX, worldZ);
                }
            }
            
            return resizedMap;
        }
        
        #endregion
        
        #region Metrics
        
        /// <summary>
        /// Get percentage of pallet volume that is filled
        /// </summary>
        public float GetFillPercentage()
        {
            float usedVolume = placedBoxes.Sum(pb => pb.box.GetVolume());
            float totalVolume = GetTotalVolume();
            return usedVolume / totalVolume;
        }
        
        /// <summary>
        /// Get available volume remaining
        /// </summary>
        public float GetAvailableVolume()
        {
            float usedVolume = placedBoxes.Sum(pb => pb.box.GetVolume());
            return GetTotalVolume() - usedVolume;
        }
        
        /// <summary>
        /// Get total pallet volume
        /// </summary>
        public float GetTotalVolume()
        {
            return palletSize.x * palletSize.y * palletSize.z;
        }
        
        /// <summary>
        /// Get maximum height of placed boxes
        /// </summary>
        public float GetMaxHeight()
        {
            if (placedBoxes.Count == 0)
                return 0f;
            
            return placedBoxes.Max(pb => pb.bounds.max.y);
        }
        
        /// <summary>
        /// Get average height of placed boxes
        /// </summary>
        public float GetAverageHeight()
        {
            if (placedBoxes.Count == 0)
                return 0f;
            
            return placedBoxes.Average(pb => pb.placement.position.y);
        }
        
        /// <summary>
        /// Calculate surface flatness (how level is the top surface)
        /// </summary>
        public float GetSurfaceFlatness()
        {
            if (heightMap == null || heightMapResolution == 0)
                return 1f;
            
            float avgHeight = 0f;
            int count = 0;
            
            for (int x = 0; x < heightMapResolution; x++)
            {
                for (int z = 0; z < heightMapResolution; z++)
                {
                    avgHeight += heightMap[x, z];
                    count++;
                }
            }
            avgHeight /= count;
            
            // Calculate standard deviation
            float variance = 0f;
            for (int x = 0; x < heightMapResolution; x++)
            {
                for (int z = 0; z < heightMapResolution; z++)
                {
                    float diff = heightMap[x, z] - avgHeight;
                    variance += diff * diff;
                }
            }
            variance /= count;
            
            float stdDev = Mathf.Sqrt(variance);
            
            // Normalize (lower stdDev = flatter = higher score)
            return Mathf.Exp(-stdDev / palletSize.y);
        }
        
        /// <summary>
        /// Calculate surface fragmentation (number of gaps/holes)
        /// </summary>
        public float GetSurfaceFragmentation()
        {
            if (heightMap == null)
                return 0f;
            
            // Count number of "edges" in height map (sharp transitions)
            int edgeCount = 0;
            float threshold = voxelSize * 2f;
            
            for (int x = 0; x < heightMapResolution - 1; x++)
            {
                for (int z = 0; z < heightMapResolution - 1; z++)
                {
                    float current = heightMap[x, z];
                    float right = heightMap[x + 1, z];
                    float down = heightMap[x, z + 1];
                    
                    if (Mathf.Abs(current - right) > threshold)
                        edgeCount++;
                    if (Mathf.Abs(current - down) > threshold)
                        edgeCount++;
                }
            }
            
            int maxEdges = (heightMapResolution - 1) * (heightMapResolution - 1) * 2;
            return 1f - (edgeCount / (float)maxEdges);
        }
        
        /// <summary>
        /// Calculate overall stability score
        /// </summary>
        public float GetStabilityScore()
        {
            if (placedBoxes.Count == 0)
                return 1f;
            
            float totalScore = 0f;
            
            foreach (var placedBox in placedBoxes)
            {
                // Factors affecting stability:
                // 1. Support ratio
                float supportScore = GetSupportRatio(placedBox.box, placedBox.placement);
                
                // 2. Center of mass (lower is better)
                float heightScore = 1f - (placedBox.placement.position.y / palletSize.y);
                
                // 3. Weight distribution
                float weightScore = 1f - (placedBox.box.weight / maxWeight);
                
                float boxScore = (supportScore * 0.5f + heightScore * 0.3f + weightScore * 0.2f);
                totalScore += boxScore;
            }
            
            return totalScore / placedBoxes.Count;
        }
        
        /// <summary>
        /// Get current weight on pallet
        /// </summary>
        public float GetCurrentWeight()
        {
            return currentWeight;
        }
        
        /// <summary>
        /// Check if adding a box would exceed weight limit
        /// </summary>
        public bool WouldExceedWeight(Box box)
        {
            return (currentWeight + box.weight) > maxWeight;
        }
        
        #endregion
        
        #region Private Methods
        
        private Bounds CalculateBounds(Box box, PlacementAction placement)
        {
            Vector3 rotatedSize = GetRotatedSize(box.size, placement.rotation);
            Vector3 center = transform.position + placement.position + rotatedSize / 2f;
            return new Bounds(center, rotatedSize);
        }
        
        private Vector3 GetRotatedSize(Vector3 size, int rotation)
        {
            // Rotate around Y axis
            int normalizedRotation = ((rotation % 360) + 360) % 360;
            
            if (normalizedRotation == 90 || normalizedRotation == 270)
            {
                // Swap X and Z
                return new Vector3(size.z, size.y, size.x);
            }
            
            return size;
        }
        
        private GameObject CreateBoxVisual(Box box, PlacementAction placement)
        {
            GameObject boxObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
            boxObject.name = $"Box_{placedBoxes.Count}";
            boxObject.transform.parent = transform;
            
            Vector3 rotatedSize = GetRotatedSize(box.size, placement.rotation);
            boxObject.transform.localPosition = placement.position + rotatedSize / 2f;
            boxObject.transform.localScale = rotatedSize;
            boxObject.transform.rotation = Quaternion.Euler(0, placement.rotation, 0);
            
            // Add random color for visualization
            Renderer renderer = boxObject.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.material.color = box.color;
            }
            
            return boxObject;
        }
        
        private void UpdateOccupancy(PlacedBox placedBox, bool occupy)
        {
            Vector3Int minVoxel = WorldToVoxel(placedBox.bounds.min);
            Vector3Int maxVoxel = WorldToVoxel(placedBox.bounds.max);
            
            for (int x = minVoxel.x; x <= maxVoxel.x; x++)
            {
                for (int y = minVoxel.y; y <= maxVoxel.y; y++)
                {
                    for (int z = minVoxel.z; z <= maxVoxel.z; z++)
                    {
                        Vector3Int voxel = new Vector3Int(x, y, z);
                        if (occupy)
                            occupiedVoxels.Add(voxel);
                        else
                            occupiedVoxels.Remove(voxel);
                    }
                }
            }
        }
        
        private void UpdateHeightMap(PlacedBox placedBox)
        {
            // Update height map for the area covered by this box
            int minX = Mathf.FloorToInt(placedBox.bounds.min.x / palletSize.x * heightMapResolution);
            int maxX = Mathf.CeilToInt(placedBox.bounds.max.x / palletSize.x * heightMapResolution);
            int minZ = Mathf.FloorToInt(placedBox.bounds.min.z / palletSize.z * heightMapResolution);
            int maxZ = Mathf.CeilToInt(placedBox.bounds.max.z / palletSize.z * heightMapResolution);
            
            minX = Mathf.Max(0, minX);
            maxX = Mathf.Min(heightMapResolution - 1, maxX);
            minZ = Mathf.Max(0, minZ);
            maxZ = Mathf.Min(heightMapResolution - 1, maxZ);
            
            float boxTopHeight = placedBox.bounds.max.y;
            
            for (int x = minX; x <= maxX; x++)
            {
                for (int z = minZ; z <= maxZ; z++)
                {
                    heightMap[x, z] = Mathf.Max(heightMap[x, z], boxTopHeight);
                }
            }
        }
        
        private void RecalculateHeightMap()
        {
            // Reset height map
            for (int x = 0; x < heightMapResolution; x++)
            {
                for (int z = 0; z < heightMapResolution; z++)
                {
                    heightMap[x, z] = 0f;
                }
            }
            
            // Rebuild from all placed boxes
            foreach (var placedBox in placedBoxes)
            {
                UpdateHeightMap(placedBox);
            }
        }
        
        private float CalculateSupportedArea(Box box, PlacementAction placement)
        {
            Bounds boxBounds = CalculateBounds(box, placement);
            Vector3 baseMin = new Vector3(boxBounds.min.x, boxBounds.min.y - 0.01f, boxBounds.min.z);
            Vector3 baseMax = new Vector3(boxBounds.max.x, boxBounds.min.y + 0.01f, boxBounds.max.z);
            Bounds baseBounds = new Bounds((baseMin + baseMax) / 2f, baseMax - baseMin);
            
            float supportedArea = 0f;
            Vector3 voxelSize3D = new Vector3(voxelSize, voxelSize, voxelSize);
            
            // Sample points under the box
            int samples = 5;
            float dx = (baseBounds.max.x - baseBounds.min.x) / samples;
            float dz = (baseBounds.max.z - baseBounds.min.z) / samples;
            
            for (int i = 0; i < samples; i++)
            {
                for (int j = 0; j < samples; j++)
                {
                    Vector3 samplePoint = new Vector3(
                        baseBounds.min.x + dx * (i + 0.5f),
                        baseBounds.min.y,
                        baseBounds.min.z + dz * (j + 0.5f)
                    );
                    
                    // Check if this point is supported
                    if (IsPointSupported(samplePoint))
                    {
                        supportedArea += (dx * dz);
                    }
                }
            }
            
            return supportedArea;
        }
        
        private bool IsPointSupported(Vector3 point)
        {
            // Check if point is on the ground
            if (point.y <= 0.01f)
                return true;
            
            // Check if point is above another box
            foreach (var placedBox in placedBoxes)
            {
                if (Mathf.Abs(placedBox.bounds.max.y - point.y) < 0.02f &&
                    point.x >= placedBox.bounds.min.x && point.x <= placedBox.bounds.max.x &&
                    point.z >= placedBox.bounds.min.z && point.z <= placedBox.bounds.max.z)
                {
                    return true;
                }
            }
            
            return false;
        }
        
        private Vector3Int WorldToVoxel(Vector3 worldPos)
        {
            return new Vector3Int(
                Mathf.FloorToInt(worldPos.x / voxelSize),
                Mathf.FloorToInt(worldPos.y / voxelSize),
                Mathf.FloorToInt(worldPos.z / voxelSize)
            );
        }
        
        #endregion
        
        #region Debug Visualization
        
        private void OnDrawGizmos()
        {
            if (!showGizmos)
                return;
            
            // Draw pallet bounds
            Gizmos.color = palletColor;
            Gizmos.DrawWireCube(transform.position + palletSize / 2f, palletSize);
            
            // Draw occupied voxels (optional, can be expensive)
            if (Application.isPlaying && occupiedVoxels != null && occupiedVoxels.Count < 1000)
            {
                Gizmos.color = occupiedVoxelColor;
                foreach (var voxel in occupiedVoxels)
                {
                    Vector3 pos = new Vector3(voxel.x, voxel.y, voxel.z) * voxelSize + 
                                 Vector3.one * voxelSize / 2f;
                    Gizmos.DrawCube(pos, Vector3.one * voxelSize * 0.9f);
                }
            }
        }
        
        #endregion
    }
    
    /// <summary>
    /// Represents a box that has been placed on the pallet
    /// </summary>
    [System.Serializable]
    public class PlacedBox
    {
        public Box box;
        public PlacementAction placement;
        public GameObject gameObject;
        public Bounds bounds;
    }
}
