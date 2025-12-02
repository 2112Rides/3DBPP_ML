using UnityEngine;
using System.Linq;

namespace BoxPacking.MLAgents
{
    /// <summary>
    /// Diagnostic tool to understand what's actually happening in the environment
    /// Attach to agent GameObject and call from Inspector or code
    /// </summary>
    public class EnvironmentDiagnostics : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private BoxSpawner boxSpawner;
        [SerializeField] private PalletManager palletManager;
        [SerializeField] private BoxPackingAgent agent;
        [SerializeField] private PlacementValidator validator;

        [Header("Test Settings")]
        [SerializeField] private int testBoxCount = 10;
        [SerializeField] private int gridResolution = 8;

        [ContextMenu("Run Full Diagnostics")]
        public void RunFullDiagnostics()
        {
            Debug.Log("=== ENVIRONMENT DIAGNOSTICS ===\n");

            DiagnoseBoxSizes();
            DiagnosePalletCapacity();
            DiagnoseGridMapping();
            DiagnoseValidPlacements();

            Debug.Log("=== DIAGNOSTICS COMPLETE ===");
        }

        [ContextMenu("1. Check Box Sizes")]
        public void DiagnoseBoxSizes()
        {
            Debug.Log("\n--- BOX SIZE DIAGNOSIS ---");

            if (boxSpawner == null)
            {
                Debug.LogError("BoxSpawner not assigned!");
                return;
            }

            // Generate test boxes
            var boxes = boxSpawner.GenerateBoxSet(testBoxCount);

            Debug.Log($"Generated {boxes.Count} boxes:");

            float minVolume = float.MaxValue;
            float maxVolume = 0;
            float totalVolume = 0;

            for (int i = 0; i < boxes.Count; i++)
            {
                var box = boxes[i];
                float volume = box.size.x * box.size.y * box.size.z;
                totalVolume += volume;
                minVolume = Mathf.Min(minVolume, volume);
                maxVolume = Mathf.Max(maxVolume, volume);

                Debug.Log($"  Box {i}: Size=({box.size.x:F1}, {box.size.y:F1}, {box.size.z:F1}), " +
                         $"Volume={volume:F0}, Weight={box.weight:F1}");
            }

            Debug.Log($"\nVolume Stats:");
            Debug.Log($"  Min Volume: {minVolume:F0}");
            Debug.Log($"  Max Volume: {maxVolume:F0}");
            Debug.Log($"  Avg Volume: {(totalVolume / boxes.Count):F0}");
            Debug.Log($"  Total Volume: {totalVolume:F0}");
        }

        [ContextMenu("2. Check Pallet Capacity")]
        public void DiagnosePalletCapacity()
        {
            Debug.Log("\n--- PALLET CAPACITY DIAGNOSIS ---");

            if (palletManager == null)
            {
                Debug.LogError("PalletManager not assigned!");
                return;
            }

            Vector3 size = palletManager.palletSize;
            float totalVolume = size.x * size.y * size.z;
            float baseArea = size.x * size.z;

            Debug.Log($"Pallet Dimensions: {size.x}×{size.y}×{size.z}");
            Debug.Log($"Total Volume: {totalVolume:F0}");
            Debug.Log($"Base Area: {baseArea:F0}");
            Debug.Log($"Max Weight: {palletManager.maxWeight}");

            // Calculate theoretical capacity
            if (boxSpawner != null)
            {
                var boxes = boxSpawner.GenerateBoxSet(testBoxCount);
                float avgBoxVolume = boxes.Average(b => b.size.x * b.size.y * b.size.z);
                float avgBoxBaseArea = boxes.Average(b => b.size.x * b.size.z);
                float avgBoxHeight = boxes.Average(b => b.size.y);

                int theoreticalTotal = Mathf.FloorToInt(totalVolume / avgBoxVolume);
                int theoreticalPerLayer = Mathf.FloorToInt(baseArea / avgBoxBaseArea);
                int theoreticalLayers = Mathf.FloorToInt(size.y / avgBoxHeight);

                Debug.Log($"\nTheoretical Capacity:");
                Debug.Log($"  Avg Box Volume: {avgBoxVolume:F0}");
                Debug.Log($"  Avg Box Base Area: {avgBoxBaseArea:F0}");
                Debug.Log($"  Avg Box Height: {avgBoxHeight:F1}");
                Debug.Log($"  Boxes Per Layer: {theoreticalPerLayer}");
                Debug.Log($"  Number of Layers: {theoreticalLayers}");
                Debug.Log($"  Total Boxes (perfect packing): {theoreticalTotal}");
                Debug.Log($"  Total Boxes (layered): {theoreticalPerLayer * theoreticalLayers}");

                // Utilization check
                float utilization = (avgBoxVolume * testBoxCount) / totalVolume * 100f;
                Debug.Log($"  {testBoxCount} boxes would use: {utilization:F1}% of pallet");

                if (theoreticalPerLayer < 5)
                {
                    Debug.LogWarning("⚠️ WARNING: Less than 5 boxes per layer! Boxes may be too large!");
                }
                if (theoreticalPerLayer < 3)
                {
                    Debug.LogError("❌ CRITICAL: Less than 3 boxes per layer! Boxes are WAY too large!");
                }
            }
        }

        [ContextMenu("3. Check Grid Mapping")]
        public void DiagnoseGridMapping()
        {
            Debug.Log("\n--- GRID MAPPING DIAGNOSIS ---");

            if (palletManager == null)
            {
                Debug.LogError("PalletManager not assigned!");
                return;
            }

            Debug.Log($"Grid Resolution: {gridResolution}×{gridResolution}");
            Debug.Log($"Total Grid Cells: {gridResolution * gridResolution}");

            float cellWidth = palletManager.palletSize.x / gridResolution;
            float cellDepth = palletManager.palletSize.z / gridResolution;

            Debug.Log($"Cell Size: {cellWidth:F1}×{cellDepth:F1}");

            // Check if boxes fit in cells
            if (boxSpawner != null)
            {
                var boxes = boxSpawner.GenerateBoxSet(5);
                Debug.Log($"\nBox-to-Cell Fit:");
                foreach (var box in boxes)
                {
                    bool fitsInCell = box.size.x <= cellWidth && box.size.z <= cellDepth;
                    string status = fitsInCell ? "✓ Fits" : "❌ TOO LARGE";
                    Debug.Log($"  Box ({box.size.x:F1}×{box.size.z:F1}): {status} in cell ({cellWidth:F1}×{cellDepth:F1})");
                }
            }

            // Sample grid positions
            Debug.Log($"\nSample Grid-to-World Mappings:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    float xPos = (i + 0.5f) / gridResolution * palletManager.palletSize.x;
                    float zPos = (j + 0.5f) / gridResolution * palletManager.palletSize.z;
                    Debug.Log($"  Grid({i},{j}) -> World({xPos:F1}, {zPos:F1})");
                }
            }
        }

        [ContextMenu("4. Check Valid Placements")]
        public void DiagnoseValidPlacements()
        {
            Debug.Log("\n--- VALID PLACEMENTS DIAGNOSIS ---");

            if (boxSpawner == null || validator == null || palletManager == null)
            {
                Debug.LogError("Required components not assigned!");
                return;
            }

            // Generate one test box
            var boxes = boxSpawner.GenerateBoxSet(1);
            if (boxes.Count == 0) return;

            var testBox = boxes[0];
            Debug.Log($"Testing with box: Size=({testBox.size.x:F1}, {testBox.size.y:F1}, {testBox.size.z:F1})");

            // Check all grid positions
            int validCount = 0;
            int totalPositions = gridResolution * gridResolution * 4; // 4 rotations

            for (int rotation = 0; rotation < 4; rotation++)
            {
                for (int x = 0; x < gridResolution; x++)
                {
                    for (int z = 0; z < gridResolution; z++)
                    {
                        float xPos = (x + 0.5f) / gridResolution * palletManager.palletSize.x;
                        float zPos = (z + 0.5f) / gridResolution * palletManager.palletSize.z;
                        float yPos = palletManager.GetHeightAt(xPos, zPos);

                        var placement = new PlacementAction(
                            new Vector3(xPos, yPos, zPos),
                            rotation * 90
                        );

                        if (validator.ValidatePlacement(testBox, placement, palletManager))
                        {
                            validCount++;
                        }
                    }
                }
            }

            float validPercent = (validCount / (float)totalPositions) * 100f;
            Debug.Log($"\nValid Placements:");
            Debug.Log($"  Valid: {validCount}/{totalPositions} ({validPercent:F1}%)");

            if (validPercent < 10)
            {
                Debug.LogWarning($"⚠️ WARNING: Only {validPercent:F1}% of positions are valid!");
            }
            if (validPercent < 5)
            {
                Debug.LogError($"❌ CRITICAL: Only {validPercent:F1}% valid! Boxes way too large or grid too fine!");
            }
        }

        [ContextMenu("5. Test Episode Simulation")]
        public void SimulateEpisode()
        {
            Debug.Log("\n--- EPISODE SIMULATION ---");

            if (boxSpawner == null || validator == null || palletManager == null)
            {
                Debug.LogError("Required components not assigned!");
                return;
            }

            palletManager.Reset();

            var boxes = boxSpawner.GenerateBoxSet(testBoxCount);
            int placedCount = 0;
            int attemptCount = 0;
            int maxAttempts = 1000;

            Debug.Log($"Attempting to place {boxes.Count} boxes...");

            for (int i = 0; i < boxes.Count && attemptCount < maxAttempts; i++)
            {
                var box = boxes[i];
                bool placed = false;

                // Try random placements until one works
                for (int attempt = 0; attempt < 100 && !placed; attempt++)
                {
                    attemptCount++;

                    int x = Random.Range(0, gridResolution);
                    int z = Random.Range(0, gridResolution);
                    int rot = Random.Range(0, 4);

                    float xPos = (x + 0.5f) / gridResolution * palletManager.palletSize.x;
                    float zPos = (z + 0.5f) / gridResolution * palletManager.palletSize.z;
                    float yPos = palletManager.GetHeightAt(xPos, zPos);

                    var placement = new PlacementAction(
                        new Vector3(xPos, yPos, zPos),
                        rot * 90
                    );

                    if (validator.ValidatePlacement(box, placement, palletManager))
                    {
                        palletManager.PlaceBox(box, placement);
                        placedCount++;
                        placed = true;
                        Debug.Log($"  ✓ Placed box {i+1} at grid ({x},{z}) after {attempt+1} attempts");
                    }
                }

                if (!placed)
                {
                    Debug.LogWarning($"  ❌ Failed to place box {i+1} after 100 attempts");
                    break;
                }
            }

            float fillPercent = palletManager.GetFillPercentage() * 100f;
            Debug.Log($"\nSimulation Results:");
            Debug.Log($"  Boxes Placed: {placedCount}/{boxes.Count}");
            Debug.Log($"  Total Attempts: {attemptCount}");
            Debug.Log($"  Pallet Fill: {fillPercent:F1}%");

            if (placedCount < 5)
            {
                Debug.LogError($"❌ CRITICAL: Only placed {placedCount} boxes! Environment is broken!");
            }
            else if (placedCount < 10)
            {
                Debug.LogWarning($"⚠️ WARNING: Only placed {placedCount} boxes. Boxes may be too large.");
            }
            else
            {
                Debug.Log($"✓ Good: Placed {placedCount} boxes successfully!");
            }
        }
    }
}
