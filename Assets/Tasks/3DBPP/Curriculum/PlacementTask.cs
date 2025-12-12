using UnityEngine;
using System.Collections.Generic;
using System.IO;
using LearningPipeline.Core;

namespace Tasks._3DBPP.Curriculum
{
    public enum PresetPattern
    {
        Custom,
        Corners,
        Center,
        Edges,
        TShape,
        LShape
    }

    /// <summary>
    /// General Placement Task
    ///
    /// GOAL: Place boxes according to a configurable grid pattern
    /// SUCCESS: All target cells in the pattern are occupied
    ///
    /// Use the inspector to define target patterns like:
    /// - Center placement
    /// - Edge placement
    /// - T-shape, L-shape, or any custom pattern
    /// </summary>
    public class PlacementTask : MonoBehaviour, ILearningTask
    {
        [Header("Grid Configuration")]
        [SerializeField] private int gridResolution = 8;
        [SerializeField] private Vector3 palletSize = new Vector3(100, 100, 100);

        [Header("Target Pattern")]
        [SerializeField] private PresetPattern presetPattern = PresetPattern.Custom;
        [Tooltip("Check the cells where boxes should be placed. Array is flattened row by row (Z, then X).")]
        [SerializeField] private bool[] targetPattern = new bool[64]; // 8x8 grid by default

        private PresetPattern lastPresetPattern = PresetPattern.Custom;

        [Header("Settings")]
        [SerializeField] private float cellTolerance = 0.3f;  // How much of a cell's area counts as "in cell" (0-1)

        [Header("Status (Runtime)")]
        [HideInInspector] public bool[] cellsOccupied; // Hidden - use custom inspector to view
        [SerializeField] private int boxesPlaced = 0;
        [SerializeField] private int targetCellsCount = 0;
        [SerializeField] private int targetCellsOccupied = 0;
        [SerializeField] private float currentPerformance = 0f;

        private const float TARGET_CELL_REWARD = 25f;
        private const float NON_TARGET_PENALTY = -5f;
        private const float DUPLICATE_PENALTY = -2f;

        public string TaskName => "3DBPP_GeneralPlacement";
        public string TaskDescription => "Place boxes according to the target pattern";

        private void OnValidate()
        {
            // Ensure target pattern array matches grid resolution
            int requiredSize = gridResolution * gridResolution;
            if (targetPattern == null || targetPattern.Length != requiredSize)
            {
                bool[] newPattern = new bool[requiredSize];
                if (targetPattern != null)
                {
                    // Copy existing values
                    int copyLength = Mathf.Min(targetPattern.Length, newPattern.Length);
                    System.Array.Copy(targetPattern, newPattern, copyLength);
                }
                targetPattern = newPattern;
            }

            // Ensure cells occupied array matches
            if (cellsOccupied == null || cellsOccupied.Length != requiredSize)
            {
                cellsOccupied = new bool[requiredSize];
            }

            // Apply preset pattern if changed
            if (presetPattern != lastPresetPattern && presetPattern != PresetPattern.Custom)
            {
                ApplyPresetPattern(presetPattern);
                lastPresetPattern = presetPattern;
            }

            // Count target cells
            CountTargetCells();
        }

        private void Awake()
        {
            // Initialize arrays if needed
            int requiredSize = gridResolution * gridResolution;
            if (cellsOccupied == null || cellsOccupied.Length != requiredSize)
            {
                cellsOccupied = new bool[requiredSize];
            }
            CountTargetCells();
        }

        public void ResetTask()
        {
            int size = gridResolution * gridResolution;
            cellsOccupied = new bool[size];
            boxesPlaced = 0;
            targetCellsOccupied = 0;
            currentPerformance = 0f;
        }

        public void SetDifficultyLevel(int level)
        {
            // Future: Higher levels could require:
            // - Tighter cell tolerance
            // - More complex patterns
            // - Specific placement order
            // - Time limits
        }

        public int GetDifficultyLevel()
        {
            return 0;
        }

        public float GetCurrentPerformance()
        {
            return currentPerformance;
        }

        public bool IsLessonComplete()
        {
            // Complete when all target cells are occupied
            return targetCellsOccupied >= targetCellsCount;
        }

        public Dictionary<string, float> GetMetrics()
        {
            return new Dictionary<string, float>
            {
                { "target_cells_occupied", targetCellsOccupied },
                { "target_cells_total", targetCellsCount },
                { "boxes_placed", boxesPlaced },
                { "completion_percent", targetCellsCount > 0 ? (targetCellsOccupied / (float)targetCellsCount) * 100f : 0f }
            };
        }

        /// <summary>
        /// Evaluate a box placement and return reward
        /// </summary>
        public float EvaluatePlacement(Vector3 position)
        {
            boxesPlaced++;
            float reward = 0f;

            // Get grid cell index for this position
            int cellIndex = GetCellIndex(position);

            if (cellIndex >= 0)
            {
                int x = cellIndex % gridResolution;
                int z = cellIndex / gridResolution;

                // Check if this cell is a target
                if (targetPattern[cellIndex])
                {
                    if (!cellsOccupied[cellIndex])
                    {
                        // First box in target cell - big reward!
                        cellsOccupied[cellIndex] = true;
                        targetCellsOccupied++;
                        reward = TARGET_CELL_REWARD;
                        Debug.Log($"<color=green>Target cell ({x},{z}) occupied!</color> ({targetCellsOccupied}/{targetCellsCount})");
                    }
                    else
                    {
                        // Target cell already occupied - small penalty
                        reward = DUPLICATE_PENALTY;
                        Debug.Log($"<color=yellow>Target cell ({x},{z}) already occupied</color>");
                    }
                }
                else
                {
                    // Not a target cell - penalty
                    reward = NON_TARGET_PENALTY;
                    Debug.Log($"<color=red>Box placed in non-target cell ({x},{z})</color>");
                }
            }
            else
            {
                // Position outside grid - penalty
                reward = NON_TARGET_PENALTY;
                Debug.Log($"<color=red>Box placed outside grid!</color> Position: {position}");
            }

            // Update performance
            currentPerformance = targetCellsCount > 0 ? (targetCellsOccupied / (float)targetCellsCount) : 0f;

            return reward;
        }

        /// <summary>
        /// Get the grid cell index for a world position, or -1 if outside grid
        /// </summary>
        private int GetCellIndex(Vector3 position)
        {
            // Calculate cell size
            float cellWidth = palletSize.x / gridResolution;
            float cellDepth = palletSize.z / gridResolution;

            // Get grid coordinates
            int x = Mathf.FloorToInt(position.x / cellWidth);
            int z = Mathf.FloorToInt(position.z / cellDepth);

            // Check if within bounds
            if (x < 0 || x >= gridResolution || z < 0 || z >= gridResolution)
            {
                return -1;
            }

            // Calculate cell center
            float cellCenterX = (x + 0.5f) * cellWidth;
            float cellCenterZ = (z + 0.5f) * cellDepth;

            // Check if position is within tolerance of cell center
            float distX = Mathf.Abs(position.x - cellCenterX) / (cellWidth * 0.5f);
            float distZ = Mathf.Abs(position.z - cellCenterZ) / (cellDepth * 0.5f);

            if (distX <= cellTolerance && distZ <= cellTolerance)
            {
                return z * gridResolution + x;
            }

            return -1;
        }

        /// <summary>
        /// Count how many target cells are defined in the pattern
        /// </summary>
        private void CountTargetCells()
        {
            targetCellsCount = 0;
            if (targetPattern != null)
            {
                foreach (bool isTarget in targetPattern)
                {
                    if (isTarget) targetCellsCount++;
                }
            }
        }

        /// <summary>
        /// Helper method to get target status for a grid coordinate
        /// </summary>
        public bool IsTargetCell(int x, int z)
        {
            if (x < 0 || x >= gridResolution || z < 0 || z >= gridResolution)
                return false;

            int index = z * gridResolution + x;
            return targetPattern[index];
        }

        /// <summary>
        /// Helper method to set target status for a grid coordinate
        /// </summary>
        public void SetTargetCell(int x, int z, bool isTarget)
        {
            if (x < 0 || x >= gridResolution || z < 0 || z >= gridResolution)
                return;

            int index = z * gridResolution + x;
            targetPattern[index] = isTarget;
            CountTargetCells();
        }

        /// <summary>
        /// Apply a preset pattern (used by OnValidate when dropdown changes)
        /// </summary>
        private void ApplyPresetPattern(PresetPattern preset)
        {
            // Clear current pattern
            for (int i = 0; i < targetPattern.Length; i++)
            {
                targetPattern[i] = false;
            }

            switch (preset)
            {
                case PresetPattern.Corners:
                    // Four corners
                    SetTargetCell(0, 0, true);
                    SetTargetCell(gridResolution - 1, 0, true);
                    SetTargetCell(0, gridResolution - 1, true);
                    SetTargetCell(gridResolution - 1, gridResolution - 1, true);
                    break;

                case PresetPattern.Center:
                    // Center 2x2
                    int mid = gridResolution / 2;
                    SetTargetCell(mid - 1, mid - 1, true);
                    SetTargetCell(mid, mid - 1, true);
                    SetTargetCell(mid - 1, mid, true);
                    SetTargetCell(mid, mid, true);
                    break;

                case PresetPattern.Edges:
                    // All edges
                    for (int i = 0; i < gridResolution; i++)
                    {
                        SetTargetCell(i, 0, true); // Bottom edge
                        SetTargetCell(i, gridResolution - 1, true); // Top edge
                        SetTargetCell(0, i, true); // Left edge
                        SetTargetCell(gridResolution - 1, i, true); // Right edge
                    }
                    break;

                case PresetPattern.TShape:
                    // T shape
                    int midX = gridResolution / 2;
                    for (int i = 0; i < gridResolution; i++)
                    {
                        SetTargetCell(i, 0, true); // Top bar
                    }
                    for (int i = 1; i < gridResolution / 2; i++)
                    {
                        SetTargetCell(midX, i, true); // Vertical stem
                    }
                    break;

                case PresetPattern.LShape:
                    // L shape
                    for (int i = 0; i < gridResolution; i++)
                    {
                        SetTargetCell(0, i, true); // Vertical bar
                    }
                    for (int i = 1; i < gridResolution / 2; i++)
                    {
                        SetTargetCell(i, gridResolution - 1, true); // Horizontal bar
                    }
                    break;
            }

            CountTargetCells();
        }

        /// <summary>
        /// Set a preset pattern (legacy string-based method for backwards compatibility)
        /// </summary>
        public void SetPresetPattern(string presetName)
        {
            PresetPattern preset = PresetPattern.Custom;
            switch (presetName.ToLower())
            {
                case "corners": preset = PresetPattern.Corners; break;
                case "center": preset = PresetPattern.Center; break;
                case "edges": preset = PresetPattern.Edges; break;
                case "t-shape": preset = PresetPattern.TShape; break;
                case "l-shape": preset = PresetPattern.LShape; break;
            }

            if (preset != PresetPattern.Custom)
            {
                presetPattern = preset;
                ApplyPresetPattern(preset);
            }
        }

        /// <summary>
        /// Get the number of target cells occupied
        /// </summary>
        public int GetTargetCellsOccupied()
        {
            return targetCellsOccupied;
        }

        /// <summary>
        /// Get the total number of target cells
        /// </summary>
        public int GetTargetCellsCount()
        {
            return targetCellsCount;
        }

        /// <summary>
        /// Visualize grid pattern in Scene view
        /// </summary>
        private void OnDrawGizmos()
        {
            if (targetPattern == null) return;

            float cellWidth = palletSize.x / gridResolution;
            float cellDepth = palletSize.z / gridResolution;
            float height = 5f;

            for (int z = 0; z < gridResolution; z++)
            {
                for (int x = 0; x < gridResolution; x++)
                {
                    int index = z * gridResolution + x;
                    if (index >= targetPattern.Length) continue;

                    // Only draw target cells
                    if (targetPattern[index])
                    {
                        // Calculate cell center position
                        float centerX = (x + 0.5f) * cellWidth;
                        float centerZ = (z + 0.5f) * cellDepth;
                        Vector3 cellCenterLocal = new Vector3(centerX, height / 2, centerZ);

                        // Check if occupied
                        bool occupied = Application.isPlaying &&
                                      cellsOccupied != null &&
                                      index < cellsOccupied.Length &&
                                      cellsOccupied[index];

                        // Color based on status
                        Gizmos.color = occupied ? Color.green : Color.yellow;

                        // Transform to world space
                        Vector3 worldCenter = transform.TransformPoint(cellCenterLocal);
                        Vector3 cellSize = Vector3.Scale(
                            new Vector3(cellWidth * 0.8f, height, cellDepth * 0.8f),
                            transform.lossyScale
                        );

                        Gizmos.DrawWireCube(worldCenter, cellSize);
                    }
                }
            }

            // Draw pallet bounds for reference
            Gizmos.color = Color.white;
            Vector3 palletCenterLocal = new Vector3(palletSize.x / 2, 0, palletSize.z / 2);
            Vector3 palletSizeLocal = new Vector3(palletSize.x, 0.1f, palletSize.z);
            Vector3 palletCenterWorld = transform.TransformPoint(palletCenterLocal);
            Vector3 palletSizeWorld = Vector3.Scale(palletSizeLocal, transform.lossyScale);
            Gizmos.DrawWireCube(palletCenterWorld, palletSizeWorld);
        }

        #region Pattern Save/Load

        private const string PATTERN_FOLDER = "Assets/Tasks/3DBPP/Curriculum/Patterns/";

        /// <summary>
        /// Save current pattern to JSON file
        /// </summary>
        public void SavePattern(string patternName, string description = "")
        {
            // Ensure folder exists
            if (!Directory.Exists(PATTERN_FOLDER))
            {
                Directory.CreateDirectory(PATTERN_FOLDER);
            }

            // Create pattern data
            PatternData data = new PatternData(patternName, gridResolution, targetPattern, description);

            // Save to file
            string filename = SanitizeFilename(patternName) + ".json";
            string filepath = Path.Combine(PATTERN_FOLDER, filename);
            File.WriteAllText(filepath, data.ToJson());

            Debug.Log($"Pattern saved: {filepath}");

#if UNITY_EDITOR
            UnityEditor.AssetDatabase.Refresh();
#endif
        }

        /// <summary>
        /// Load pattern from JSON file
        /// </summary>
        public bool LoadPattern(string filename)
        {
            string filepath = Path.Combine(PATTERN_FOLDER, filename);

            if (!File.Exists(filepath))
            {
                Debug.LogError($"Pattern file not found: {filepath}");
                return false;
            }

            try
            {
                string json = File.ReadAllText(filepath);
                PatternData data = PatternData.FromJson(json);

                // Validate grid resolution matches
                if (data.gridResolution != gridResolution)
                {
                    Debug.LogWarning($"Pattern grid resolution ({data.gridResolution}) doesn't match current resolution ({gridResolution}). Resizing...");
                    gridResolution = data.gridResolution;
                }

                // Apply pattern
                targetPattern = data.cells;
                presetPattern = PresetPattern.Custom;
                CountTargetCells();

                Debug.Log($"Pattern loaded: {data.patternName} - {data.description}");
                return true;
            }
            catch (System.Exception e)
            {
                Debug.LogError($"Failed to load pattern: {e.Message}");
                return false;
            }
        }

        /// <summary>
        /// Get all saved pattern files
        /// </summary>
        public static string[] GetSavedPatternFiles()
        {
            if (!Directory.Exists(PATTERN_FOLDER))
            {
                return new string[0];
            }

            string[] files = Directory.GetFiles(PATTERN_FOLDER, "*.json");
            for (int i = 0; i < files.Length; i++)
            {
                files[i] = Path.GetFileName(files[i]);
            }
            return files;
        }

        /// <summary>
        /// Get pattern name from filename
        /// </summary>
        public static string GetPatternName(string filename)
        {
            if (!File.Exists(Path.Combine(PATTERN_FOLDER, filename)))
                return filename;

            try
            {
                string json = File.ReadAllText(Path.Combine(PATTERN_FOLDER, filename));
                PatternData data = PatternData.FromJson(json);
                return data.patternName;
            }
            catch
            {
                return Path.GetFileNameWithoutExtension(filename);
            }
        }

        private string SanitizeFilename(string filename)
        {
            foreach (char c in Path.GetInvalidFileNameChars())
            {
                filename = filename.Replace(c, '_');
            }
            return filename;
        }

        #endregion
    }
}
