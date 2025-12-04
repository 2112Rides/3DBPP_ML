using UnityEngine;
using Unity.MLAgents.Actuators;
using LearningPipeline.Imitation;

namespace Tasks._3DBPP.Configs
{
    /// <summary>
    /// Maps keyboard input to 3DBPP box placement actions.
    ///
    /// CONTROLS:
    /// - Arrow Keys: Move grid cursor (X, Z position)
    /// - R Key: Rotate box 90 degrees
    /// - SPACE: Place box at current position
    /// - Q/E: Adjust grid resolution view (for precision)
    ///
    /// The selected grid position and rotation are encoded into a single discrete action.
    /// </summary>
    public class BinPackingInputMapper : MonoBehaviour, IInputMapper
    {
        [Header("Grid Settings")]
        [SerializeField] private int gridResolution = 8;
        [SerializeField] private Vector3 palletSize = new Vector3(100, 100, 100);

        [Header("Current Selection")]
        [SerializeField] private int gridX = 0;
        [SerializeField] private int gridZ = 0;
        [SerializeField] private int rotation = 0;  // 0, 90, 180, 270

        [Header("Input Settings")]
        [SerializeField] private float moveRepeatRate = 0.15f;  // Seconds between repeats when holding key

        private float lastMoveTime = 0f;
        private bool actionConfirmedThisFrame = false;

        private void Start()
        {
            ResetInput();
        }

        private void Update()
        {
            // Reset confirmed flag each frame
            actionConfirmedThisFrame = false;

            // Handle movement input
            HandleGridMovement();

            // Handle rotation
            if (Input.GetKeyDown(KeyCode.R))
            {
                rotation = (rotation + 90) % 360;
                Debug.Log($"Rotation: {rotation}°");
            }

            // Check for confirmation
            if (Input.GetKeyDown(KeyCode.Space))
            {
                actionConfirmedThisFrame = true;
                Debug.Log($"<color=cyan>ACTION CONFIRMED:</color> Grid({gridX},{gridZ}) Rot={rotation}°");
            }
        }

        public ActionBuffers MapInput()
        {
            // Encode grid position and rotation into single discrete action
            // Action = rotation * (gridResolution * gridResolution) + gridX * gridResolution + gridZ
            int numRotations = 4;
            int totalGridPositions = gridResolution * gridResolution;
            int action = (rotation / 90) * totalGridPositions + gridX * gridResolution + gridZ;

            // Create ActionBuffers with discrete action
            var discreteActions = new int[] { action };
            return new ActionBuffers(null, discreteActions);
        }

        public bool IsActionConfirmed()
        {
            return actionConfirmedThisFrame;
        }

        public void DisplayInputHints()
        {
            // Input hints displayed via GetInputStateString() and drawn by KeyboardController
        }

        public void ResetInput()
        {
            gridX = gridResolution / 2;
            gridZ = gridResolution / 2;
            rotation = 0;
        }

        public string GetInputStateString()
        {
            Vector3 worldPos = GridToWorldPosition(gridX, gridZ);
            return $"Grid: ({gridX}, {gridZ}) | World: ({worldPos.x:F1}, {worldPos.z:F1}) | Rotation: {rotation}° | [SPACE] to place";
        }

        private void HandleGridMovement()
        {
            // Allow key repeat for smooth movement
            if (Time.time - lastMoveTime < moveRepeatRate)
            {
                return;
            }

            bool moved = false;

            // Left/Right (X axis)
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                gridX = Mathf.Max(0, gridX - 1);
                moved = true;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                gridX = Mathf.Min(gridResolution - 1, gridX + 1);
                moved = true;
            }

            // Up/Down (Z axis)
            if (Input.GetKey(KeyCode.UpArrow))
            {
                gridZ = Mathf.Min(gridResolution - 1, gridZ + 1);
                moved = true;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                gridZ = Mathf.Max(0, gridZ - 1);
                moved = true;
            }

            if (moved)
            {
                lastMoveTime = Time.time;
            }
        }

        private Vector3 GridToWorldPosition(int x, int z)
        {
            float xPos = (x + 0.5f) / gridResolution * palletSize.x;
            float zPos = (z + 0.5f) / gridResolution * palletSize.z;
            return new Vector3(xPos, 0, zPos);
        }

        /// <summary>
        /// Visualize current selection in Scene view
        /// </summary>
        private void OnDrawGizmos()
        {
            Vector3 worldPos = GridToWorldPosition(gridX, gridZ);
            worldPos.y = 10f;  // Raise above pallet

            // Draw selection cursor
            Gizmos.color = Color.cyan;
            Gizmos.DrawWireCube(worldPos, new Vector3(10, 5, 10));

            // Draw rotation indicator
            Vector3 forward = Quaternion.Euler(0, rotation, 0) * Vector3.forward;
            Gizmos.color = Color.red;
            Gizmos.DrawLine(worldPos, worldPos + forward * 8);
        }

        /// <summary>
        /// Decode an action back into grid position and rotation (for debugging)
        /// </summary>
        public static void DecodeAction(int action, int gridResolution, out int x, out int z, out int rot)
        {
            int totalGridPositions = gridResolution * gridResolution;
            rot = (action / totalGridPositions) * 90;
            int gridPos = action % totalGridPositions;
            x = gridPos / gridResolution;
            z = gridPos % gridResolution;
        }
    }
}
