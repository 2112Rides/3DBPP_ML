using Unity.MLAgents.Sensors;
using UnityEngine;

namespace LearningPipeline.Core
{
    /// <summary>
    /// Context object passed between Agent and Task.
    /// Contains references and state needed for task execution.
    /// </summary>
    public class TaskContext
    {
        public ProcessAgent Agent;
        public AgentBody Body;
        public Transform EnvironmentRoot;
        public float ElapsedTime;
        public int StepCount;

        // Convenience helpers can be added here
        // e.g., RayHits, TargetTransforms, etc.
    }

    /// <summary>
    /// Core task interface for curriculum learning.
    /// Each task encapsulates:
    /// - Scene setup
    /// - Observations
    /// - Reward computation
    /// - Termination conditions
    /// </summary>
    public interface ITask
    {
        /// <summary>
        /// Unique identifier for this task
        /// </summary>
        string Id { get; }

        /// <summary>
        /// Called at the start of each episode.
        /// Setup environment, spawn objects, reset state.
        /// </summary>
        void OnEpisodeBegin(TaskContext ctx);

        /// <summary>
        /// Add task-specific observations to the sensor.
        /// Called during agent's CollectObservations phase.
        /// </summary>
        void CollectObservations(TaskContext ctx, VectorSensor sensor);

        /// <summary>
        /// Compute reward for this step.
        /// Called during agent's OnActionReceived phase.
        /// </summary>
        float ComputeReward(TaskContext ctx);

        /// <summary>
        /// Check if episode should terminate.
        /// </summary>
        /// <param name="ctx">Task context</param>
        /// <param name="success">Output: true if termination is due to success</param>
        /// <returns>True if episode should end</returns>
        bool CheckTermination(TaskContext ctx, out bool success);

        /// <summary>
        /// Called when episode ends.
        /// Cleanup, logging, curriculum signals.
        /// </summary>
        void OnEpisodeEnd(TaskContext ctx, bool success);

        /// <summary>
        /// Get task-specific metrics for tracking/logging.
        /// Optional - can return null if not needed.
        /// </summary>
        System.Collections.Generic.Dictionary<string, float> GetMetrics();
    }
}
