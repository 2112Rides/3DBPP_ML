using Unity.MLAgents.Sensors;
using UnityEngine;
using LearningPipeline.Core;

namespace Tasks.Templates
{
    /// <summary>
    /// EXAMPLE TASK: Reach a target position
    ///
    /// This is a simple template showing how to implement a task.
    /// The agent must move its "effector" to reach a target sphere.
    ///
    /// CURRICULUM EXAMPLE:
    /// Task 1: Stationary target
    /// Task 2: Moving target (sine wave X)
    /// Task 3: Moving target (sine wave XZ)
    /// Task 4: Multiple targets
    /// Task 5: Moving + time constraint
    /// </summary>
    [CreateAssetMenu(menuName = "AI/Tasks/Examples/SimpleReachTarget")]
    public class SimpleReachTargetTask : BaseTask
    {
        [Header("Target Configuration")]
        [SerializeField] private GameObject targetPrefab;
        [SerializeField] private float targetRadius = 0.5f;
        [SerializeField] private float successDistance = 0.1f;

        [Header("Spawn Area")]
        [SerializeField] private Vector3 spawnAreaMin = new Vector3(-5, 0, -5);
        [SerializeField] private Vector3 spawnAreaMax = new Vector3(5, 3, 5);

        [Header("Movement (Optional)")]
        [SerializeField] private bool targetMoves = false;
        [SerializeField] private Vector3 moveAmplitude = new Vector3(2, 0, 0);
        [SerializeField] private float moveFrequency = 1f;

        [Header("Reward Tuning")]
        [SerializeField] private float distanceRewardScale = 0.01f;
        [SerializeField] private float reachReward = 5f;

        // Runtime state
        private GameObject targetInstance;
        private Vector3 targetBasePosition;
        private Transform effectorTransform;
        private float timeSinceSpawn;

        protected override void SetupEnvironment(TaskContext ctx)
        {
            // Get effector from body (assuming body has a "GetEffector()" method)
            // For generic template, we'll find a tagged transform
            if (ctx.Body != null)
            {
                effectorTransform = ctx.Body.transform.Find("Effector");
                if (effectorTransform == null)
                {
                    Debug.LogWarning($"[{taskId}] No 'Effector' child found on AgentBody!");
                    effectorTransform = ctx.Body.transform; // Fallback to body root
                }
            }

            // Spawn or reset target
            if (targetInstance == null)
            {
                if (targetPrefab != null)
                {
                    targetInstance = Instantiate(targetPrefab, ctx.EnvironmentRoot);
                }
                else
                {
                    // Create simple sphere if no prefab
                    targetInstance = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    targetInstance.transform.SetParent(ctx.EnvironmentRoot);
                    targetInstance.transform.localScale = Vector3.one * targetRadius;
                    targetInstance.GetComponent<Renderer>().material.color = Color.green;

                    // Remove collider to avoid physics interference
                    if (targetInstance.GetComponent<Collider>() != null)
                        Destroy(targetInstance.GetComponent<Collider>());
                }
            }

            // Randomize target position
            targetBasePosition = new Vector3(
                Random.Range(spawnAreaMin.x, spawnAreaMax.x),
                Random.Range(spawnAreaMin.y, spawnAreaMax.y),
                Random.Range(spawnAreaMin.z, spawnAreaMax.z)
            );

            targetInstance.transform.position = targetBasePosition;
            timeSinceSpawn = 0f;
        }

        protected override void AddTaskObservations(TaskContext ctx, VectorSensor sensor)
        {
            if (targetInstance == null || effectorTransform == null) return;

            // Vector from effector to target (key observation!)
            Vector3 toTarget = targetInstance.transform.position - effectorTransform.position;
            sensor.AddObservation(toTarget); // 3 floats

            // Distance to target (normalized)
            float distance = toTarget.magnitude;
            float normalizedDistance = Mathf.Clamp01(distance / 10f);
            sensor.AddObservation(normalizedDistance); // 1 float

            // Total observations: 4 (plus 2 from base class = 6 total)
        }

        protected override float CalculateReward(TaskContext ctx)
        {
            if (targetInstance == null || effectorTransform == null) return 0f;

            // Update target position if moving
            if (targetMoves)
            {
                timeSinceSpawn += Time.fixedDeltaTime;
                Vector3 movement = new Vector3(
                    Mathf.Sin(timeSinceSpawn * moveFrequency) * moveAmplitude.x,
                    Mathf.Sin(timeSinceSpawn * moveFrequency) * moveAmplitude.y,
                    Mathf.Sin(timeSinceSpawn * moveFrequency) * moveAmplitude.z
                );
                targetInstance.transform.position = targetBasePosition + movement;
            }

            // Calculate distance
            float distance = Vector3.Distance(effectorTransform.position, targetInstance.transform.position);

            // Reward shaping: closer is better
            float shapingReward = Mathf.Clamp01(1f - (distance / 10f)) * distanceRewardScale;

            // Check if reached target
            if (distance <= successDistance)
            {
                return shapingReward + reachReward;
            }

            return shapingReward;
        }

        protected override bool IsComplete(TaskContext ctx, out bool success)
        {
            success = false;

            if (targetInstance == null || effectorTransform == null)
                return false;

            // Check if reached target
            float distance = Vector3.Distance(effectorTransform.position, targetInstance.transform.position);
            if (distance <= successDistance)
            {
                success = true;
                return true;
            }

            return false;
        }

        protected override void CleanupEnvironment(TaskContext ctx)
        {
            // Optionally destroy target (or keep for reuse)
            // if (targetInstance != null)
            // {
            //     Destroy(targetInstance);
            //     targetInstance = null;
            // }
        }

        private void OnDrawGizmosSelected()
        {
            // Visualize spawn area
            Gizmos.color = Color.yellow;
            Vector3 center = (spawnAreaMin + spawnAreaMax) / 2f;
            Vector3 size = spawnAreaMax - spawnAreaMin;
            Gizmos.DrawWireCube(center, size);

            // Visualize success distance
            if (targetInstance != null)
            {
                Gizmos.color = Color.green;
                Gizmos.DrawWireSphere(targetInstance.transform.position, successDistance);
            }
        }
    }
}
