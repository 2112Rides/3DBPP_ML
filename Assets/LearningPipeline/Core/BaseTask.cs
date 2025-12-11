using Unity.MLAgents.Sensors;
using UnityEngine;
using System.Collections.Generic;

namespace LearningPipeline.Core
{
    /// <summary>
    /// Base ScriptableObject implementation of ITask.
    /// Inherit from this to create concrete tasks.
    ///
    /// USAGE:
    /// 1. Create new script inheriting from BaseTask
    /// 2. Add [CreateAssetMenu] attribute
    /// 3. Implement abstract methods
    /// 4. Create asset in Unity (Right-click > Create > Your Task)
    /// 5. Add to TaskManager's curriculum list
    ///
    /// EXAMPLE:
    /// [CreateAssetMenu(menuName = "AI/Tasks/MyCustomTask")]
    /// public class MyCustomTask : BaseTask
    /// {
    ///     protected override void SetupEnvironment(TaskContext ctx) { ... }
    ///     protected override void AddTaskObservations(TaskContext ctx, VectorSensor sensor) { ... }
    ///     protected override float CalculateReward(TaskContext ctx) { ... }
    ///     protected override bool IsComplete(TaskContext ctx, out bool success) { ... }
    /// }
    /// </summary>
    public abstract class BaseTask : ScriptableObject, ITask
    {
        [Header("Task Identity")]
        [SerializeField] protected string taskId = "task_unnamed";
        [SerializeField] protected string taskDescription = "";

        [Header("Episode Settings")]
        [SerializeField] protected float maxEpisodeTime = 30f;
        [SerializeField] protected int maxSteps = 1000;

        [Header("Reward Shaping")]
        [SerializeField] protected float successReward = 10f;
        [SerializeField] protected float failurePenalty = -1f;
        [SerializeField] protected float timeoutPenalty = -0.5f;

        // Runtime state
        protected float episodeTime;
        protected bool episodeActive;

        public string Id => taskId;

        public virtual void OnEpisodeBegin(TaskContext ctx)
        {
            episodeTime = 0f;
            episodeActive = true;

            // Setup environment (implemented by subclass)
            SetupEnvironment(ctx);
        }

        public virtual void CollectObservations(TaskContext ctx, VectorSensor sensor)
        {
            // Common observations
            sensor.AddObservation(ctx.ElapsedTime / maxEpisodeTime); // Normalized time
            sensor.AddObservation(ctx.StepCount / (float)maxSteps);  // Normalized steps

            // Task-specific observations (implemented by subclass)
            AddTaskObservations(ctx, sensor);
        }

        public virtual float ComputeReward(TaskContext ctx)
        {
            episodeTime += Time.fixedDeltaTime;

            // Task-specific reward (implemented by subclass)
            return CalculateReward(ctx);
        }

        public virtual bool CheckTermination(TaskContext ctx, out bool success)
        {
            success = false;

            // Check task-specific completion (implemented by subclass)
            if (IsComplete(ctx, out success))
            {
                return true;
            }

            // Check timeout
            if (ctx.ElapsedTime >= maxEpisodeTime)
            {
                success = false;
                return true;
            }

            // Check max steps
            if (ctx.StepCount >= maxSteps)
            {
                success = false;
                return true;
            }

            return false;
        }

        public virtual void OnEpisodeEnd(TaskContext ctx, bool success)
        {
            episodeActive = false;

            // Optional: Log completion
            if (success)
            {
                Debug.Log($"[{taskId}] Episode SUCCESS in {ctx.ElapsedTime:F2}s, {ctx.StepCount} steps");
            }
            else
            {
                Debug.Log($"[{taskId}] Episode FAILED");
            }

            // Cleanup (implemented by subclass)
            CleanupEnvironment(ctx);
        }

        public virtual Dictionary<string, float> GetMetrics()
        {
            return new Dictionary<string, float>
            {
                { "episode_time", episodeTime },
                { "is_active", episodeActive ? 1f : 0f }
            };
        }

        // ============================================
        // ABSTRACT METHODS - Implement in subclasses
        // ============================================

        /// <summary>
        /// Setup the environment for this task.
        /// Spawn objects, set positions, randomize parameters, etc.
        /// </summary>
        protected abstract void SetupEnvironment(TaskContext ctx);

        /// <summary>
        /// Add task-specific observations to the sensor.
        /// Examples: target positions, object states, distances, etc.
        /// </summary>
        protected abstract void AddTaskObservations(TaskContext ctx, VectorSensor sensor);

        /// <summary>
        /// Calculate reward for this step.
        /// Can include shaping rewards, progress rewards, penalties, etc.
        /// </summary>
        protected abstract float CalculateReward(TaskContext ctx);

        /// <summary>
        /// Check if task is complete.
        /// </summary>
        /// <param name="ctx">Task context</param>
        /// <param name="success">Set to true if completed successfully, false if failed</param>
        /// <returns>True if episode should end</returns>
        protected abstract bool IsComplete(TaskContext ctx, out bool success);

        /// <summary>
        /// Optional cleanup when episode ends.
        /// Destroy spawned objects, reset state, etc.
        /// </summary>
        protected virtual void CleanupEnvironment(TaskContext ctx)
        {
            // Default: no cleanup
            // Override if needed
        }
    }
}
