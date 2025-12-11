using Unity.MLAgents.Sensors;
using UnityEngine;

namespace LearningPipeline.Core
{
    /// <summary>
    /// Abstract representation of an agent's physical body.
    /// Separates embodiment (joints, effectors, sensors) from decision-making.
    ///
    /// Subclass this for different body types:
    /// - ArticulatedBody (joints, IK)
    /// - DrummerBody (stick tips, drum pads)
    /// - ManipulatorBody (gripper, tool holder)
    /// - SimpleBody (just a transform)
    /// </summary>
    public abstract class AgentBody : MonoBehaviour
    {
        [Header("Body Configuration")]
        [SerializeField] protected Transform bodyRoot;

        /// <summary>
        /// Initialize body components.
        /// Called once during agent setup.
        /// </summary>
        public virtual void Initialize()
        {
            if (bodyRoot == null)
                bodyRoot = transform;
        }

        /// <summary>
        /// Reset body to initial pose/state.
        /// Called at start of each episode.
        /// </summary>
        public abstract void ResetBodyPose();

        /// <summary>
        /// Collect body-specific observations (joint angles, velocities, etc.)
        /// These are core observations shared across all tasks.
        /// </summary>
        public abstract void CollectBodyObservations(VectorSensor sensor);

        /// <summary>
        /// Apply actions to the body (joint torques, IK targets, etc.)
        /// </summary>
        public abstract void ApplyActions(float[] actions);

        /// <summary>
        /// Get the number of action dimensions this body requires.
        /// Used to configure agent's action space.
        /// </summary>
        public abstract int GetActionSize();

        /// <summary>
        /// Get the number of observations this body produces.
        /// Used to configure agent's observation space.
        /// </summary>
        public abstract int GetObservationSize();
    }
}
