using System.Collections.Generic;

namespace LearningPipeline.Core
{
    /// <summary>
    /// Generic interface that any learning task must implement.
    /// Enables curriculum learning, task switching, and standardized evaluation.
    /// </summary>
    public interface ILearningTask
    {
        /// <summary>
        /// Unique identifier for this task (e.g., "3DBPP_CornerPlacement")
        /// </summary>
        string TaskName { get; }

        /// <summary>
        /// Human-readable description of the task
        /// </summary>
        string TaskDescription { get; }

        /// <summary>
        /// Set the difficulty level for curriculum learning (0 = easiest)
        /// </summary>
        void SetDifficultyLevel(int level);

        /// <summary>
        /// Get current performance metric (0.0 to 1.0)
        /// Used to determine when to advance curriculum
        /// </summary>
        float GetCurrentPerformance();

        /// <summary>
        /// Check if current lesson/difficulty is complete
        /// </summary>
        bool IsLessonComplete();

        /// <summary>
        /// Reset task to initial state
        /// Called at start of each episode
        /// </summary>
        void ResetTask();

        /// <summary>
        /// Get dictionary of task-specific metrics for logging
        /// Examples: boxes_placed, pallet_utilization, stability_score
        /// </summary>
        Dictionary<string, float> GetMetrics();

        /// <summary>
        /// Get current difficulty level
        /// </summary>
        int GetDifficultyLevel();
    }
}
