using UnityEngine;
using UnityEditor;

namespace Tasks._3DBPP.Curriculum.Editor
{
    [CustomEditor(typeof(PlacementTask))]
    public class PlacementTaskEditor : UnityEditor.Editor
    {
        private SerializedProperty gridResolutionProp;
        private SerializedProperty palletSizeProp;
        private SerializedProperty presetPatternProp;
        private SerializedProperty targetPatternProp;
        private SerializedProperty cellToleranceProp;

        private const float CELL_SIZE = 20f;
        private const float GRID_SPACING = 2f;

        private void OnEnable()
        {
            gridResolutionProp = serializedObject.FindProperty("gridResolution");
            palletSizeProp = serializedObject.FindProperty("palletSize");
            presetPatternProp = serializedObject.FindProperty("presetPattern");
            targetPatternProp = serializedObject.FindProperty("targetPattern");
            cellToleranceProp = serializedObject.FindProperty("cellTolerance");
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            PlacementTask task = (PlacementTask)target;

            // Header
            EditorGUILayout.LabelField("Placement Task", EditorStyles.boldLabel);
            EditorGUILayout.Space();

            // Grid Configuration
            EditorGUILayout.LabelField("Grid Configuration", EditorStyles.boldLabel);
            EditorGUI.BeginChangeCheck();
            EditorGUILayout.PropertyField(gridResolutionProp, new GUIContent("Grid Resolution"));
            if (EditorGUI.EndChangeCheck())
            {
                // Grid resolution changed, pattern array will be resized in OnValidate
            }
            EditorGUILayout.PropertyField(palletSizeProp, new GUIContent("Pallet Size"));
            EditorGUILayout.Space();

            // Preset Pattern Dropdown
            EditorGUILayout.LabelField("Target Pattern", EditorStyles.boldLabel);
            EditorGUI.BeginChangeCheck();
            EditorGUILayout.PropertyField(presetPatternProp, new GUIContent("Preset Pattern"));
            if (EditorGUI.EndChangeCheck())
            {
                serializedObject.ApplyModifiedProperties();
                // OnValidate will be called automatically and apply the preset
            }

            EditorGUILayout.Space();

            // Interactive Grid UI
            int gridRes = gridResolutionProp.intValue;
            EditorGUILayout.LabelField($"Pattern Grid ({gridRes}x{gridRes})", EditorStyles.boldLabel);
            EditorGUILayout.HelpBox("Click cells to toggle them on/off. Green = target cell, Gray = empty cell\n\n" +
                "Grid orientation matches Unity 3D view: Z=0 at BOTTOM (back), Z increases UPWARD (forward toward camera).", MessageType.Info);

            DrawInteractiveGrid(task, gridRes);

            // Show legend
            EditorGUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            EditorGUILayout.LabelField("Legend:", GUILayout.Width(50));
            DrawColorBox(new Color(0.2f, 1f, 0.2f), "Target");
            if (Application.isPlaying)
            {
                DrawColorBox(new Color(0.1f, 0.6f, 1f), "Occupied");
            }
            DrawColorBox(new Color(0.4f, 0.4f, 0.4f), "Empty");
            GUILayout.FlexibleSpace();
            EditorGUILayout.EndHorizontal();

            EditorGUILayout.Space();

            // Pattern Management
            EditorGUILayout.LabelField("Pattern Management", EditorStyles.boldLabel);
            EditorGUILayout.BeginHorizontal();

            if (GUILayout.Button("Save Pattern", GUILayout.Height(25)))
            {
                SavePatternDialog(task);
            }

            if (GUILayout.Button("Load Pattern", GUILayout.Height(25)))
            {
                LoadPatternDialog(task);
            }

            EditorGUILayout.EndHorizontal();

            EditorGUILayout.Space();

            // Settings
            EditorGUILayout.LabelField("Settings", EditorStyles.boldLabel);
            EditorGUILayout.PropertyField(cellToleranceProp, new GUIContent("Cell Tolerance"));

            // Stats
            EditorGUILayout.Space();
            EditorGUILayout.LabelField("Pattern Stats", EditorStyles.boldLabel);
            int targetCount = task.GetTargetCellsCount();
            int occupiedCount = Application.isPlaying ? task.GetTargetCellsOccupied() : 0;
            EditorGUILayout.LabelField($"Target Cells: {targetCount}");
            if (Application.isPlaying)
            {
                EditorGUILayout.LabelField($"Occupied Cells: {occupiedCount}/{targetCount}");
                float completion = targetCount > 0 ? (occupiedCount / (float)targetCount) * 100f : 0f;
                EditorGUILayout.LabelField($"Completion: {completion:F1}%");
            }

            serializedObject.ApplyModifiedProperties();
        }

        private void DrawInteractiveGrid(PlacementTask task, int gridRes)
        {
            EditorGUILayout.BeginVertical();

            float gridWidth = gridRes * (CELL_SIZE + GRID_SPACING);
            GUILayoutUtility.GetRect(gridWidth, gridRes * (CELL_SIZE + GRID_SPACING) + 10);

            Rect lastRect = GUILayoutUtility.GetLastRect();
            float startX = lastRect.x + (lastRect.width - gridWidth) / 2;
            float startY = lastRect.y + 5;

            // Draw grid (Z increases upward to match Unity 3D view, X increases rightward)
            for (int z = gridRes - 1; z >= 0; z--)
            {
                for (int x = 0; x < gridRes; x++)
                {
                    float posX = startX + x * (CELL_SIZE + GRID_SPACING);
                    float posY = startY + (gridRes - 1 - z) * (CELL_SIZE + GRID_SPACING);
                    Rect cellRect = new Rect(posX, posY, CELL_SIZE, CELL_SIZE);

                    bool isTarget = task.IsTargetCell(x, z);
                    bool isOccupied = false;

                    // Check if occupied (during runtime)
                    if (Application.isPlaying && task.cellsOccupied != null)
                    {
                        int index = z * gridRes + x;
                        if (index < task.cellsOccupied.Length)
                        {
                            isOccupied = task.cellsOccupied[index];
                        }
                    }

                    // Draw cell button
                    Color originalColor = GUI.backgroundColor;

                    // Color priority: Occupied (blue) > Target (green) > Empty (gray)
                    // Use brighter colors, especially during play mode
                    if (isOccupied && isTarget)
                    {
                        GUI.backgroundColor = new Color(0.1f, 0.6f, 1f); // Bright blue for occupied target
                    }
                    else if (isTarget)
                    {
                        GUI.backgroundColor = new Color(0.2f, 1f, 0.2f); // Bright green for target
                    }
                    else
                    {
                        GUI.backgroundColor = new Color(0.4f, 0.4f, 0.4f); // Lighter gray for empty
                    }

                    // Only allow editing when not playing
                    if (!Application.isPlaying && GUI.Button(cellRect, ""))
                    {
                        // Toggle cell
                        Undo.RecordObject(task, "Toggle Grid Cell");
                        task.SetTargetCell(x, z, !isTarget);

                        // Set preset to Custom when manually editing
                        SerializedProperty presetProp = serializedObject.FindProperty("presetPattern");
                        presetProp.enumValueIndex = 0; // Custom
                        serializedObject.ApplyModifiedProperties();

                        EditorUtility.SetDirty(task);
                    }
                    else if (Application.isPlaying)
                    {
                        // Just draw the box during playmode
                        GUI.Box(cellRect, "");
                    }

                    GUI.backgroundColor = originalColor;

                    // Draw cell coordinates (optional, for debugging)
                    if (CELL_SIZE >= 20)
                    {
                        GUIStyle labelStyle = new GUIStyle(GUI.skin.label);
                        labelStyle.fontSize = 8;
                        labelStyle.alignment = TextAnchor.MiddleCenter;
                        labelStyle.normal.textColor = isTarget || isOccupied ? Color.white : Color.gray;
                        GUI.Label(cellRect, $"{x},{z}", labelStyle);
                    }
                }
            }

            EditorGUILayout.EndVertical();
        }

        private void DrawColorBox(Color color, string label)
        {
            EditorGUILayout.BeginHorizontal(GUILayout.Width(80));
            Color originalColor = GUI.backgroundColor;
            GUI.backgroundColor = color;
            GUILayout.Box("", GUILayout.Width(15), GUILayout.Height(15));
            GUI.backgroundColor = originalColor;
            EditorGUILayout.LabelField(label, GUILayout.Width(60));
            EditorGUILayout.EndHorizontal();
        }

        private void SavePatternDialog(PlacementTask task)
        {
            // Use a simpler approach with EditorUtility input field
            PatternSaveWindow.Show(task);
        }

        private void LoadPatternDialog(PlacementTask task)
        {
            string[] patternFiles = PlacementTask.GetSavedPatternFiles();

            if (patternFiles.Length == 0)
            {
                EditorUtility.DisplayDialog("No Patterns", "No saved patterns found. Create and save a pattern first!", "OK");
                return;
            }

            // Create popup menu
            GenericMenu menu = new GenericMenu();

            foreach (string file in patternFiles)
            {
                string patternName = PlacementTask.GetPatternName(file);
                menu.AddItem(new GUIContent(patternName), false, () =>
                {
                    if (task.LoadPattern(file))
                    {
                        EditorUtility.DisplayDialog("Pattern Loaded", $"Pattern '{patternName}' loaded successfully!", "OK");
                    }
                });
            }

            menu.ShowAsContext();
        }
    }

    /// <summary>
    /// Window for saving patterns with name and description
    /// </summary>
    public class PatternSaveWindow : EditorWindow
    {
        private PlacementTask task;
        private string patternName = "My Pattern";
        private string patternDescription = "";

        public static void Show(PlacementTask targetTask)
        {
            PatternSaveWindow window = GetWindow<PatternSaveWindow>(true, "Save Pattern", true);
            window.task = targetTask;
            window.minSize = new Vector2(450, 220);
            window.maxSize = new Vector2(800, 400);
            window.ShowUtility();
        }

        private void OnGUI()
        {
            EditorGUILayout.Space();
            EditorGUILayout.LabelField("Save Current Pattern", EditorStyles.boldLabel);
            EditorGUILayout.Space();

            EditorGUILayout.LabelField("Pattern Name:");
            GUI.SetNextControlName("NameField");
            patternName = EditorGUILayout.TextField(patternName);

            EditorGUILayout.Space();

            EditorGUILayout.LabelField("Description (optional):");
            GUI.SetNextControlName("DescriptionField");

            // Use TextArea with explicit style to make it focusable
            GUIStyle textAreaStyle = new GUIStyle(EditorStyles.textArea);
            textAreaStyle.wordWrap = true;
            patternDescription = EditorGUILayout.TextArea(patternDescription, textAreaStyle, GUILayout.Height(50));

            EditorGUILayout.Space();

            EditorGUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();

            // Save button with icon
            GUIContent saveContent = new GUIContent(" Save", EditorGUIUtility.IconContent("SaveAs").image);
            if (GUILayout.Button(saveContent, GUILayout.Width(100), GUILayout.Height(30)))
            {
                SaveAndClose();
            }

            if (GUILayout.Button("Cancel", GUILayout.Width(80), GUILayout.Height(30)))
            {
                Close();
            }

            EditorGUILayout.EndHorizontal();
            EditorGUILayout.Space();
        }

        private void SaveAndClose()
        {
            if (string.IsNullOrEmpty(patternName.Trim()))
            {
                EditorUtility.DisplayDialog("Invalid Name", "Please enter a pattern name.", "OK");
                return;
            }

            if (task != null)
            {
                task.SavePattern(patternName, patternDescription);
                EditorUtility.DisplayDialog("Pattern Saved",
                    $"Pattern '{patternName}' has been saved successfully!\n\nLocation: Assets/Tasks/3DBPP/Curriculum/Patterns/",
                    "OK");
            }

            Close();
        }
    }
}
