using UnityEngine;
using System.Collections.Generic;
using LearningPipeline.Core;

namespace Tasks._3DBPP.Curriculum
{
    /// <summary>
    /// Lesson 1: Corner Placement
    ///
    /// GOAL: Place 4 boxes, one in each corner of the pallet
    /// SUCCESS: All 4 corners occupied
    ///
    /// This is the simplest 3DBPP task - perfect for first demonstrations
    /// </summary>
    public class CornerPlacementTask : MonoBehaviour, ILearningTask
    {
        [Header("Task Configuration")]
        [SerializeField] private Vector3 palletSize = new Vector3(100, 100, 100);
        [SerializeField] private float cornerTolerance = 15f;  // How close to corner counts

        [Header("Status")]
        [SerializeField] private bool[] cornersOccupied = new bool[4];  // TL, TR, BL, BR
        [SerializeField] private int boxesPlaced = 0;
        [SerializeField] private float currentPerformance = 0f;

        private const int TARGET_BOXES = 4;
        private const float CORNER_REWARD = 25f;

        public string TaskName => "3DBPP_L1_CornerPlacement";
        public string TaskDescription => "Place one box in each of the 4 corners";

        public void ResetTask()
        {
            for (int i = 0; i < cornersOccupied.Length; i++)
            {
                cornersOccupied[i] = false;
            }
            boxesPlaced = 0;
            currentPerformance = 0f;
        }

        public void SetDifficultyLevel(int level)
        {
            // This task has only one difficulty level
            // In future lessons, higher levels could:
            // - Require tighter corner tolerance
            // - Require specific corner order
            // - Add time limits
        }

        public int GetDifficultyLevel()
        {
            return 0;  // Only one difficulty for this task
        }

        public float GetCurrentPerformance()
        {
            return currentPerformance;
        }

        public bool IsLessonComplete()
        {
            // Lesson complete when all corners occupied
            return GetCornersOccupied() == 4;
        }

        public Dictionary<string, float> GetMetrics()
        {
            return new Dictionary<string, float>
            {
                { "corners_occupied", GetCornersOccupied() },
                { "boxes_placed", boxesPlaced },
                { "completion_percent", (GetCornersOccupied() / 4.0f) * 100f }
            };
        }

        /// <summary>
        /// Check if a placement is in a corner and mark it occupied
        /// </summary>
        public float EvaluatePlacement(Vector3 position)
        {
            boxesPlaced++;
            float reward = 0f;

            // Check each corner
            int cornerIndex = GetCornerIndex(position);

            if (cornerIndex >= 0 && !cornersOccupied[cornerIndex])
            {
                // First box in this corner - big reward!
                cornersOccupied[cornerIndex] = true;
                reward = CORNER_REWARD;
                Debug.Log($"<color=green>Corner {cornerIndex} occupied!</color> ({GetCornersOccupied()}/4)");
            }
            else if (cornerIndex >= 0 && cornersOccupied[cornerIndex])
            {
                // Corner already occupied - small penalty
                reward = -2f;
                Debug.Log($"<color=yellow>Corner {cornerIndex} already occupied</color>");
            }
            else
            {
                // Not in a corner - penalty
                reward = -5f;
                Debug.Log($"<color=red>Box not in corner!</color> Position: {position}");
            }

            // Update performance
            currentPerformance = (GetCornersOccupied() / 4.0f);

            return reward;
        }

        /// <summary>
        /// Get corner index for a position, or -1 if not in corner
        /// Corners: 0=TopLeft, 1=TopRight, 2=BottomLeft, 3=BottomRight
        /// </summary>
        private int GetCornerIndex(Vector3 position)
        {
            bool isLeft = position.x < cornerTolerance;
            bool isRight = position.x > (palletSize.x - cornerTolerance);
            bool isBack = position.z < cornerTolerance;
            bool isFront = position.z > (palletSize.z - cornerTolerance);

            // Top-Left (back-left)
            if (isLeft && isBack) return 0;

            // Top-Right (back-right)
            if (isRight && isBack) return 1;

            // Bottom-Left (front-left)
            if (isLeft && isFront) return 2;

            // Bottom-Right (front-right)
            if (isRight && isFront) return 3;

            return -1;  // Not in any corner
        }

        /// <summary>
        /// Count how many corners are occupied
        /// </summary>
        public int GetCornersOccupied()
        {
            int count = 0;
            foreach (bool occupied in cornersOccupied)
            {
                if (occupied) count++;
            }
            return count;
        }

        /// <summary>
        /// Visualize corners in Scene view
        /// </summary>
        private void OnDrawGizmos()
        {
            // Draw corner zones INSIDE the pallet
            float height = 10f;
            float offset = cornerTolerance / 2f;  // Offset from edge to center corner zone inside pallet

            // Corner positions (offset inward from edges)
            Vector3[] corners = new Vector3[]
            {
                new Vector3(offset, height/2, offset),                                    // Top-Left (back-left)
                new Vector3(palletSize.x - offset, height/2, offset),                     // Top-Right (back-right)
                new Vector3(offset, height/2, palletSize.z - offset),                     // Bottom-Left (front-left)
                new Vector3(palletSize.x - offset, height/2, palletSize.z - offset)       // Bottom-Right (front-right)
            };

            // Draw corner cubes
            for (int i = 0; i < corners.Length; i++)
            {
                Gizmos.color = cornersOccupied[i] ? Color.green : Color.yellow;
                // Convert local corner position to world using the GameObject's transform
                Vector3 worldCorner = transform.TransformPoint(corners[i]);
                // Scale the gizmo size by the object's lossy scale so visualization matches transform
                Vector3 worldSize = Vector3.Scale(Vector3.one * cornerTolerance, transform.lossyScale);
                Gizmos.DrawWireCube(worldCorner, worldSize);
            }

            // Draw pallet bounds for reference (use object's transform)
            Gizmos.color = Color.white;
            Vector3 palletCenterLocal = new Vector3(palletSize.x/2, 0, palletSize.z/2);
            Vector3 palletSizeLocal = new Vector3(palletSize.x, 0.1f, palletSize.z);
            Vector3 palletCenterWorld = transform.TransformPoint(palletCenterLocal);
            Vector3 palletSizeWorld = Vector3.Scale(palletSizeLocal, transform.lossyScale);
            Gizmos.DrawWireCube(palletCenterWorld, palletSizeWorld);
        }
    }
}
