using UnityEngine;
using System.Collections.Generic;

namespace BoxPacking.MLAgents
{
    /// <summary>
    /// Manages visualization of the packing process
    /// </summary>
    public class VisualizationManager : MonoBehaviour
    {
        #region Serialized Fields
        
        [Header("Visualization Settings")]
        [SerializeField] private bool enableVisualization = true;
        
        [Tooltip("Highlight proposed placement before confirming")]
        [SerializeField] private bool highlightProposedPlacement = true;
        
        [Tooltip("Duration to show proposed placement (seconds)")]
        [SerializeField] private float highlightDuration = 0.1f;
        
        [Header("Visual Elements")]
        [SerializeField] private Material validPlacementMaterial;
        [SerializeField] private Material invalidPlacementMaterial;
        [SerializeField] private Material highlightMaterial;
        
        [Header("Grid Visualization")]
        [SerializeField] private bool showGrid = true;
        [SerializeField] private Color gridColor = new Color(0.5f, 0.5f, 0.5f, 0.3f);
        [SerializeField] private int gridResolution = 10;
        
        [Header("Height Map Visualization")]
        [SerializeField] private bool showHeightMap = true;
        [SerializeField] private Color lowHeightColor = Color.green;
        [SerializeField] private Color highHeightColor = Color.red;
        
        [Header("Text Display")]
        [SerializeField] private bool showStats = true;
        [SerializeField] private TMPro.TextMeshProUGUI statsText; // Optional: requires TextMeshPro
        
        #endregion
        
        #region Private Fields
        
        private GameObject highlightObject;
        private LineRenderer gridRenderer;
        private List<GameObject> visualElements = new List<GameObject>();
        private float highlightTimer = 0f;
        
        #endregion
        
        #region Initialization
        
        private void Awake()
        {
            CreateDefaultMaterials();
            
            if (showGrid)
            {
                CreateGridVisualization();
            }
        }
        
        private void Update()
        {
            // Update highlight timer
            if (highlightObject != null && highlightTimer > 0)
            {
                highlightTimer -= Time.deltaTime;
                if (highlightTimer <= 0)
                {
                    ClearProposedPlacement();
                }
            }
        }
        
        #endregion
        
        #region Public Methods
        
        /// <summary>
        /// Visualize a proposed placement
        /// </summary>
        public void VisualizeProposedPlacement(Box box, PlacementAction placement, bool isValid = true)
        {
            if (!enableVisualization || !highlightProposedPlacement)
                return;
            
            ClearProposedPlacement();
            
            // Create highlight object
            highlightObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
            highlightObject.name = "ProposedPlacement";
            
            Vector3 rotatedSize = GetRotatedSize(box.size, placement.rotation);
            highlightObject.transform.position = placement.position + rotatedSize / 2f;
            highlightObject.transform.localScale = rotatedSize;
            highlightObject.transform.rotation = Quaternion.Euler(0, placement.rotation, 0);
            
            // Apply material
            Renderer renderer = highlightObject.GetComponent<Renderer>();
            if (renderer != null)
            {
                Material material = isValid ? 
                    (validPlacementMaterial ?? CreateTransparentMaterial(Color.green)) :
                    (invalidPlacementMaterial ?? CreateTransparentMaterial(Color.red));
                
                renderer.material = material;
            }
            
            // Remove collider
            Collider collider = highlightObject.GetComponent<Collider>();
            if (collider != null)
            {
                Destroy(collider);
            }
            
            highlightTimer = highlightDuration;
        }
        
        /// <summary>
        /// Clear proposed placement visualization
        /// </summary>
        public void ClearProposedPlacement()
        {
            if (highlightObject != null)
            {
                Destroy(highlightObject);
                highlightObject = null;
            }
            highlightTimer = 0f;
        }
        
        /// <summary>
        /// Update pallet visualization with current state
        /// </summary>
        public void UpdatePalletVisualization(PalletManager palletManager)
        {
            if (!enableVisualization)
                return;
            
            if (showHeightMap)
            {
                VisualizeHeightMap(palletManager);
            }
            
            if (showStats)
            {
                UpdateStatsDisplay(palletManager);
            }
        }
        
        /// <summary>
        /// Clear all visualizations
        /// </summary>
        public void ClearVisualizations()
        {
            ClearProposedPlacement();
            
            foreach (var element in visualElements)
            {
                if (element != null)
                {
                    Destroy(element);
                }
            }
            visualElements.Clear();
        }
        
        /// <summary>
        /// Highlight a specific box
        /// </summary>
        public void HighlightBox(GameObject boxObject, Color color, float duration = 1f)
        {
            if (!enableVisualization || boxObject == null)
                return;
            
            Renderer renderer = boxObject.GetComponent<Renderer>();
            if (renderer != null)
            {
                StartCoroutine(HighlightCoroutine(renderer, color, duration));
            }
        }
        
        #endregion
        
        #region Private Methods
        
        private void CreateDefaultMaterials()
        {
            if (validPlacementMaterial == null)
            {
                validPlacementMaterial = CreateTransparentMaterial(new Color(0, 1, 0, 0.3f));
            }
            
            if (invalidPlacementMaterial == null)
            {
                invalidPlacementMaterial = CreateTransparentMaterial(new Color(1, 0, 0, 0.3f));
            }
            
            if (highlightMaterial == null)
            {
                highlightMaterial = CreateTransparentMaterial(new Color(1, 1, 0, 0.5f));
            }
        }
        
        private Material CreateTransparentMaterial(Color color)
        {
            Material mat = new Material(Shader.Find("Standard"));
            mat.SetFloat("_Mode", 3); // Transparent mode
            mat.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
            mat.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
            mat.SetInt("_ZWrite", 0);
            mat.DisableKeyword("_ALPHATEST_ON");
            mat.EnableKeyword("_ALPHABLEND_ON");
            mat.DisableKeyword("_ALPHAPREMULTIPLY_ON");
            mat.renderQueue = 3000;
            mat.color = color;
            return mat;
        }
        
        private void CreateGridVisualization()
        {
            GameObject gridObject = new GameObject("GridVisualization");
            gridObject.transform.parent = transform;
            
            gridRenderer = gridObject.AddComponent<LineRenderer>();
            gridRenderer.material = new Material(Shader.Find("Sprites/Default"));
            gridRenderer.startColor = gridColor;
            gridRenderer.endColor = gridColor;
            gridRenderer.startWidth = 0.1f;
            gridRenderer.endWidth = 0.1f;
            gridRenderer.useWorldSpace = true;
            
            // Create grid lines
            List<Vector3> points = new List<Vector3>();
            
            // Get pallet manager reference (assumes it's on same object or parent)
            PalletManager palletManager = GetComponentInParent<PalletManager>();
            if (palletManager == null)
            {
                palletManager = FindObjectOfType<PalletManager>();
            }
            
            if (palletManager != null)
            {
                Vector3 palletSize = palletManager.palletSize;
                float gridSpacing = Mathf.Max(palletSize.x, palletSize.z) / gridResolution;
                
                // Vertical lines (parallel to Z)
                for (int i = 0; i <= gridResolution; i++)
                {
                    float x = i * gridSpacing;
                    if (x <= palletSize.x)
                    {
                        points.Add(new Vector3(x, 0, 0));
                        points.Add(new Vector3(x, 0, palletSize.z));
                    }
                }
                
                // Horizontal lines (parallel to X)
                for (int i = 0; i <= gridResolution; i++)
                {
                    float z = i * gridSpacing;
                    if (z <= palletSize.z)
                    {
                        points.Add(new Vector3(0, 0, z));
                        points.Add(new Vector3(palletSize.x, 0, z));
                    }
                }
            }
            
            if (points.Count > 0)
            {
                gridRenderer.positionCount = points.Count;
                gridRenderer.SetPositions(points.ToArray());
            }
        }
        
        private void VisualizeHeightMap(PalletManager palletManager)
        {
            // This creates a simple height map visualization
            // For better performance, consider using a shader-based approach
            
            float[,] heightMap = palletManager.GetHeightMap(gridResolution);
            float maxHeight = palletManager.palletSize.y;
            
            // Clear previous height map visualizations
            foreach (var element in visualElements)
            {
                if (element != null && element.name.StartsWith("HeightViz"))
                {
                    Destroy(element);
                }
            }
            visualElements.RemoveAll(e => e == null || e.name.StartsWith("HeightViz"));
            
            // Create new visualization (simplified - only show highest points)
            for (int x = 0; x < gridResolution; x += 2) // Skip some for performance
            {
                for (int z = 0; z < gridResolution; z += 2)
                {
                    float height = heightMap[x, z];
                    if (height > 0.1f) // Only visualize if there's significant height
                    {
                        GameObject marker = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                        marker.name = "HeightViz";
                        marker.transform.localScale = Vector3.one * 2f;
                        
                        float worldX = (x + 0.5f) / gridResolution * palletManager.palletSize.x;
                        float worldZ = (z + 0.5f) / gridResolution * palletManager.palletSize.z;
                        marker.transform.position = new Vector3(worldX, height, worldZ);
                        
                        // Color based on height
                        float t = height / maxHeight;
                        Color color = Color.Lerp(lowHeightColor, highHeightColor, t);
                        
                        Renderer renderer = marker.GetComponent<Renderer>();
                        if (renderer != null)
                        {
                            renderer.material.color = color;
                        }
                        
                        Collider collider = marker.GetComponent<Collider>();
                        if (collider != null)
                        {
                            Destroy(collider);
                        }
                        
                        visualElements.Add(marker);
                    }
                }
            }
        }
        
        private void UpdateStatsDisplay(PalletManager palletManager)
        {
            if (statsText == null)
                return;
            
            float efficiency = palletManager.GetFillPercentage();
            float maxHeight = palletManager.GetMaxHeight();
            float stability = palletManager.GetStabilityScore();
            float flatness = palletManager.GetSurfaceFlatness();
            
            statsText.text = $"Packing Efficiency: {efficiency:P1}\n" +
                           $"Max Height: {maxHeight:F1}\n" +
                           $"Stability: {stability:P0}\n" +
                           $"Surface Flatness: {flatness:P0}";
        }
        
        private Vector3 GetRotatedSize(Vector3 size, int rotation)
        {
            int normalizedRotation = ((rotation % 360) + 360) % 360;
            
            if (normalizedRotation == 90 || normalizedRotation == 270)
            {
                return new Vector3(size.z, size.y, size.x);
            }
            
            return size;
        }
        
        private System.Collections.IEnumerator HighlightCoroutine(Renderer renderer, Color color, float duration)
        {
            Color originalColor = renderer.material.color;
            renderer.material.color = color;
            
            yield return new WaitForSeconds(duration);
            
            renderer.material.color = originalColor;
        }
        
        #endregion
        
        #region Public Configuration
        
        public void SetEnableVisualization(bool enable)
        {
            enableVisualization = enable;
        }
        
        public void SetShowGrid(bool show)
        {
            showGrid = show;
            if (gridRenderer != null)
            {
                gridRenderer.enabled = show;
            }
        }
        
        public void SetShowHeightMap(bool show)
        {
            showHeightMap = show;
        }
        
        #endregion
    }
}
