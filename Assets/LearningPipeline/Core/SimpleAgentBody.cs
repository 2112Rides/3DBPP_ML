using Unity.MLAgents.Sensors;
using UnityEngine;

namespace LearningPipeline.Core
{
    /// <summary>
    /// Simple agent body example.
    /// Controls a single transform (effector) with continuous actions.
    ///
    /// This is a minimal example showing how to implement AgentBody.
    /// For more complex bodies (articulated joints, grippers, etc.), create custom subclasses.
    ///
    /// ACTION SPACE: 3 continuous actions
    /// - action[0]: X velocity
    /// - action[1]: Y velocity
    /// - action[2]: Z velocity
    ///
    /// OBSERVATION SPACE: 6 floats
    /// - effector position (3)
    /// - effector velocity (3)
    /// </summary>
    public class SimpleAgentBody : AgentBody
    {
        [Header("Effector")]
        [SerializeField] private Transform effector;
        [SerializeField] private float maxSpeed = 5f;
        [SerializeField] private Vector3 initialPosition = Vector3.zero;

        [Header("Constraints")]
        [SerializeField] private bool constrainY = false;
        [SerializeField] private Vector3 boundsMin = new Vector3(-10, 0, -10);
        [SerializeField] private Vector3 boundsMax = new Vector3(10, 5, 10);

        private Vector3 velocity;
        private Rigidbody effectorRb;

        public override void Initialize()
        {
            base.Initialize();

            // Setup effector
            if (effector == null)
            {
                // Create default effector
                GameObject effectorObj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                effectorObj.name = "Effector";
                effectorObj.transform.SetParent(bodyRoot);
                effectorObj.transform.localPosition = Vector3.zero;
                effectorObj.transform.localScale = Vector3.one * 0.2f;
                effector = effectorObj.transform;

                // Setup rigidbody for physics-based movement
                effectorRb = effectorObj.AddComponent<Rigidbody>();
                effectorRb.useGravity = false;
                effectorRb.constraints = RigidbodyConstraints.FreezeRotation;
            }
            else
            {
                effectorRb = effector.GetComponent<Rigidbody>();
                if (effectorRb == null)
                {
                    effectorRb = effector.gameObject.AddComponent<Rigidbody>();
                    effectorRb.useGravity = false;
                    effectorRb.constraints = RigidbodyConstraints.FreezeRotation;
                }
            }

            ResetBodyPose();
        }

        public override void ResetBodyPose()
        {
            if (effector != null)
            {
                effector.localPosition = initialPosition;
                velocity = Vector3.zero;

                if (effectorRb != null)
                {
                    effectorRb.velocity = Vector3.zero;
                    effectorRb.angularVelocity = Vector3.zero;
                }
            }
        }

        public override void CollectBodyObservations(VectorSensor sensor)
        {
            if (effector != null)
            {
                // Effector position (normalized to bounds)
                Vector3 normalizedPos = NormalizePosition(effector.position);
                sensor.AddObservation(normalizedPos); // 3 floats

                // Effector velocity (normalized)
                Vector3 normalizedVel = velocity / maxSpeed;
                sensor.AddObservation(normalizedVel); // 3 floats
            }
            else
            {
                sensor.AddObservation(Vector3.zero); // 3 floats
                sensor.AddObservation(Vector3.zero); // 3 floats
            }
        }

        public override void ApplyActions(float[] actions)
        {
            if (effector == null || actions.Length < 3) return;

            // Read actions as velocity
            Vector3 actionVelocity = new Vector3(
                actions[0],
                constrainY ? 0f : actions[1],
                actions[2]
            ) * maxSpeed;

            // Apply to rigidbody
            if (effectorRb != null)
            {
                effectorRb.velocity = actionVelocity;
                velocity = effectorRb.velocity;
            }
            else
            {
                // Fallback: direct position update
                effector.position += actionVelocity * Time.fixedDeltaTime;
                velocity = actionVelocity;
            }

            // Enforce bounds
            Vector3 pos = effector.position;
            pos.x = Mathf.Clamp(pos.x, boundsMin.x, boundsMax.x);
            pos.y = Mathf.Clamp(pos.y, boundsMin.y, boundsMax.y);
            pos.z = Mathf.Clamp(pos.z, boundsMin.z, boundsMax.z);
            effector.position = pos;
        }

        public override int GetActionSize()
        {
            return 3; // X, Y, Z velocity
        }

        public override int GetObservationSize()
        {
            return 6; // Position (3) + Velocity (3)
        }

        /// <summary>
        /// Normalize position to [-1, 1] range based on bounds
        /// </summary>
        private Vector3 NormalizePosition(Vector3 worldPos)
        {
            Vector3 normalized = new Vector3(
                Mathf.InverseLerp(boundsMin.x, boundsMax.x, worldPos.x) * 2f - 1f,
                Mathf.InverseLerp(boundsMin.y, boundsMax.y, worldPos.y) * 2f - 1f,
                Mathf.InverseLerp(boundsMin.z, boundsMax.z, worldPos.z) * 2f - 1f
            );
            return normalized;
        }

        /// <summary>
        /// Public accessor for effector (useful for tasks)
        /// </summary>
        public Transform GetEffector()
        {
            return effector;
        }

        private void OnDrawGizmos()
        {
            // Draw bounds
            Gizmos.color = Color.cyan;
            Vector3 center = (boundsMin + boundsMax) / 2f;
            Vector3 size = boundsMax - boundsMin;
            Gizmos.DrawWireCube(center, size);

            // Draw effector
            if (effector != null)
            {
                Gizmos.color = Color.red;
                Gizmos.DrawWireSphere(effector.position, 0.1f);

                // Draw velocity vector
                Gizmos.color = Color.yellow;
                Gizmos.DrawLine(effector.position, effector.position + velocity);
            }
        }
    }
}
