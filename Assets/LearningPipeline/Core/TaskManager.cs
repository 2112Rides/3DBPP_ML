using UnityEngine;
using System.Collections.Generic;

namespace LearningPipeline.Core
{
    /// <summary>
    /// Entry in the curriculum defining a task and its unlock criteria.
    /// </summary>
    [System.Serializable]
    public class TaskEntry
    {
        [Tooltip("ScriptableObject that implements ITask")]
        public ScriptableObject taskAsset;

        [Tooltip("Required success rate to unlock next task (0.0 to 1.0)")]
        [Range(0f, 1f)]
        public float unlockSuccessRate = 0.8f;

        [Tooltip("Minimum episodes required before considering advancement")]
        public int minEpisodes = 200;

        [Tooltip("Optional: manually lock/unlock this task")]
        public bool manuallyLocked = false;

        // Runtime tracking
        [HideInInspector] public int episodesCompleted = 0;
        [HideInInspector] public int successCount = 0;
        [HideInInspector] public bool isUnlocked = false;
    }

    /// <summary>
    /// Manages curriculum learning progression.
    /// Tracks performance on tasks and automatically advances when criteria are met.
    ///
    /// USAGE:
    /// 1. Create TaskEntry list in inspector with ScriptableObject tasks
    /// 2. Set unlock criteria (success rate, min episodes)
    /// 3. TaskManager will automatically progress through tasks as agent improves
    ///
    /// CURRICULUM STRATEGIES:
    /// - Sequential: Tasks unlock one after another (default)
    /// - Parallel: Multiple tasks available, randomly sampled based on performance
    /// - Staged: Groups of tasks that must all complete before next stage
    /// </summary>
    public class TaskManager : MonoBehaviour
    {
        [Header("Curriculum Configuration")]
        [SerializeField] private List<TaskEntry> curriculum = new List<TaskEntry>();

        [Header("Curriculum Strategy")]
        [SerializeField] private CurriculumMode mode = CurriculumMode.Sequential;
        [Tooltip("If true, first task is always unlocked at start")]
        [SerializeField] private bool unlockFirstTask = true;

        [Header("Runtime State")]
        [SerializeField] private int currentTaskIndex = 0;
        [SerializeField] private bool curriculumComplete = false;

        [Header("Debug")]
        [SerializeField] private bool logProgressions = true;
        [SerializeField] private bool showTaskStats = true;

        private ITask currentTask;

        public enum CurriculumMode
        {
            Sequential,      // Linear progression through tasks
            Parallel,        // Sample from unlocked tasks
            Staged          // Groups that must complete together
        }

        private void Awake()
        {
            // Unlock first task if configured
            if (unlockFirstTask && curriculum.Count > 0)
            {
                curriculum[0].isUnlocked = true;
            }
        }

        /// <summary>
        /// Get the currently active task for the agent to execute.
        /// </summary>
        public ITask GetActiveTask()
        {
            if (curriculum.Count == 0)
            {
                Debug.LogError("[TaskManager] No tasks in curriculum!");
                return null;
            }

            // Return cached task if still valid
            if (currentTask != null)
            {
                return currentTask;
            }

            // Select task based on curriculum mode
            switch (mode)
            {
                case CurriculumMode.Sequential:
                    currentTask = GetSequentialTask();
                    break;

                case CurriculumMode.Parallel:
                    currentTask = GetParallelTask();
                    break;

                case CurriculumMode.Staged:
                    currentTask = GetStagedTask();
                    break;
            }

            return currentTask;
        }

        /// <summary>
        /// Report episode result to update curriculum progression.
        /// </summary>
        public void ReportEpisodeResult(bool success)
        {
            if (curriculumComplete) return;
            if (currentTaskIndex >= curriculum.Count) return;

            var entry = curriculum[currentTaskIndex];
            entry.episodesCompleted++;
            if (success) entry.successCount++;

            float successRate = (float)entry.successCount / Mathf.Max(1, entry.episodesCompleted);

            if (showTaskStats)
            {
                Debug.Log($"[TaskManager] {entry.taskAsset?.name}: " +
                         $"{entry.successCount}/{entry.episodesCompleted} " +
                         $"({successRate:P0}) Success: {success}");
            }

            // Check if task is mastered
            bool meetsEpisodeRequirement = entry.episodesCompleted >= entry.minEpisodes;
            bool meetsSuccessRequirement = successRate >= entry.unlockSuccessRate;

            if (meetsEpisodeRequirement && meetsSuccessRequirement && !entry.manuallyLocked)
            {
                AdvanceTask();
            }
        }

        /// <summary>
        /// Advance to next task in curriculum.
        /// </summary>
        private void AdvanceTask()
        {
            if (currentTaskIndex < curriculum.Count - 1)
            {
                currentTaskIndex++;
                curriculum[currentTaskIndex].isUnlocked = true;
                currentTask = null; // Force reload on next GetActiveTask

                if (logProgressions)
                {
                    var newEntry = curriculum[currentTaskIndex];
                    Debug.Log($"<color=green>[TaskManager] TASK UNLOCKED:</color> {newEntry.taskAsset?.name} " +
                             $"(Task {currentTaskIndex + 1}/{curriculum.Count})");
                }
            }
            else
            {
                curriculumComplete = true;
                if (logProgressions)
                {
                    Debug.Log("<color=cyan>[TaskManager] CURRICULUM COMPLETE!</color>");
                }
            }
        }

        /// <summary>
        /// Sequential curriculum: return current unlocked task.
        /// </summary>
        private ITask GetSequentialTask()
        {
            if (currentTaskIndex >= curriculum.Count) return null;

            var entry = curriculum[currentTaskIndex];
            if (entry.taskAsset is ITask task)
            {
                return task;
            }

            Debug.LogError($"[TaskManager] Task asset {entry.taskAsset?.name} doesn't implement ITask!");
            return null;
        }

        /// <summary>
        /// Parallel curriculum: randomly sample from unlocked tasks.
        /// Weight by inverse performance for more training on weaker tasks.
        /// </summary>
        private ITask GetParallelTask()
        {
            List<TaskEntry> unlockedTasks = curriculum.FindAll(e => e.isUnlocked && !e.manuallyLocked);

            if (unlockedTasks.Count == 0) return null;

            // TODO: Implement weighted sampling based on performance
            // For now, random uniform
            var selected = unlockedTasks[Random.Range(0, unlockedTasks.Count)];
            currentTaskIndex = curriculum.IndexOf(selected);

            return selected.taskAsset as ITask;
        }

        /// <summary>
        /// Staged curriculum: sample from current stage's tasks.
        /// </summary>
        private ITask GetStagedTask()
        {
            // TODO: Implement stage grouping logic
            // For now, fallback to sequential
            return GetSequentialTask();
        }

        /// <summary>
        /// Manually set which task to use (for testing).
        /// </summary>
        public void SetTaskByIndex(int index)
        {
            if (index >= 0 && index < curriculum.Count)
            {
                currentTaskIndex = index;
                curriculum[index].isUnlocked = true;
                currentTask = null;

                Debug.Log($"[TaskManager] Manually set to task {index}: {curriculum[index].taskAsset?.name}");
            }
        }

        /// <summary>
        /// Reset curriculum to beginning.
        /// </summary>
        public void ResetCurriculum()
        {
            currentTaskIndex = 0;
            curriculumComplete = false;
            currentTask = null;

            foreach (var entry in curriculum)
            {
                entry.episodesCompleted = 0;
                entry.successCount = 0;
                entry.isUnlocked = false;
            }

            if (unlockFirstTask && curriculum.Count > 0)
            {
                curriculum[0].isUnlocked = true;
            }

            Debug.Log("[TaskManager] Curriculum reset");
        }

        /// <summary>
        /// Get current curriculum progress.
        /// </summary>
        public float GetCurriculumProgress()
        {
            if (curriculum.Count == 0) return 0f;
            return (float)(currentTaskIndex + 1) / curriculum.Count;
        }

        /// <summary>
        /// Get statistics for current task.
        /// </summary>
        public (int episodes, int successes, float successRate) GetCurrentTaskStats()
        {
            if (currentTaskIndex >= curriculum.Count)
                return (0, 0, 0f);

            var entry = curriculum[currentTaskIndex];
            float rate = entry.episodesCompleted > 0
                ? (float)entry.successCount / entry.episodesCompleted
                : 0f;

            return (entry.episodesCompleted, entry.successCount, rate);
        }

        private void OnGUI()
        {
            if (!showTaskStats) return;

            GUIStyle style = new GUIStyle();
            style.fontSize = 14;
            style.normal.textColor = Color.white;

            int y = 10;
            GUI.Label(new Rect(10, y, 500, 25),
                $"Curriculum: {currentTaskIndex + 1}/{curriculum.Count} ({GetCurriculumProgress():P0})", style);

            y += 25;
            if (currentTaskIndex < curriculum.Count)
            {
                var entry = curriculum[currentTaskIndex];
                var (eps, succ, rate) = GetCurrentTaskStats();
                GUI.Label(new Rect(10, y, 500, 25),
                    $"Task: {entry.taskAsset?.name} - {succ}/{eps} ({rate:P0}) [Target: {entry.unlockSuccessRate:P0}]", style);
            }
        }
    }
}
