using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;
using System.Collections.Generic;

namespace LearningPipeline.Core
{
    /// <summary>
    /// Base class for all learning agents in the curriculum pipeline.
    /// Extends Unity ML-Agents Agent class with curriculum and imitation support.
    ///
    /// Subclasses should implement:
    /// - CollectObservations() - What the agent sees
    /// - OnActionReceived() - How agent actions affect the environment
    /// - Heuristic() - Optional: Manual control for demonstrations
    /// </summary>
    public abstract class LearningAgent : Agent
    {
        [Header("Learning Pipeline Components")]
        [SerializeField] protected bool enableMetricsLogging = true;
        [SerializeField] protected bool enableDemonstrationMode = false;

        protected ILearningTask currentTask;
        protected Dictionary<string, float> episodeMetrics;

        /// <summary>
        /// Initialize the agent with a specific learning task
        /// </summary>
        public virtual void SetupTask(ILearningTask task)
        {
            currentTask = task;
            episodeMetrics = new Dictionary<string, float>();
            Debug.Log($"[LearningAgent] Task set to: {task.TaskName}");
        }

        /// <summary>
        /// Called at the start of each episode
        /// </summary>
        public override void OnEpisodeBegin()
        {
            episodeMetrics.Clear();

            if (currentTask != null)
            {
                currentTask.ResetTask();
            }

            ResetAgent();
        }

        /// <summary>
        /// Task-specific reset logic (implemented by subclass)
        /// </summary>
        protected abstract void ResetAgent();

        /// <summary>
        /// Check if episode should end
        /// </summary>
        protected abstract bool IsEpisodeComplete();

        /// <summary>
        /// Record a metric for this episode
        /// </summary>
        protected void RecordMetric(string name, float value)
        {
            if (episodeMetrics.ContainsKey(name))
            {
                episodeMetrics[name] = value;
            }
            else
            {
                episodeMetrics.Add(name, value);
            }
        }

        /// <summary>
        /// Get all metrics for current episode
        /// </summary>
        public Dictionary<string, float> GetEpisodeMetrics()
        {
            return new Dictionary<string, float>(episodeMetrics);
        }

        /// <summary>
        /// Get current task
        /// </summary>
        public ILearningTask GetCurrentTask()
        {
            return currentTask;
        }

        /// <summary>
        /// Enable/disable demonstration recording mode
        /// When enabled, agent uses Heuristic() for control
        /// </summary>
        public void SetDemonstrationMode(bool enabled)
        {
            enableDemonstrationMode = enabled;
        }

        /// <summary>
        /// Check if currently in demonstration mode
        /// </summary>
        public bool IsDemonstrationMode()
        {
            return enableDemonstrationMode;
        }
    }
}
