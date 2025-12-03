using UnityEngine;
using System.IO;

namespace BoxPacking.MLAgents
{
    /// <summary>
    /// Loads and applies environment configuration from JSON file
    /// This allows easy tracking of different parameter sets and experiments
    /// </summary>
    public class EnvironmentConfig : MonoBehaviour
    {
        [Header("Configuration")]
        [Tooltip("Path to JSON config file relative to project root")]
        [SerializeField] private string configFilePath = "Config/environment_config.json";

        [Tooltip("Load config on Start")]
        [SerializeField] private bool loadOnStart = true;

        [Header("Component References")]
        [SerializeField] private PalletManager palletManager;
        [SerializeField] private BoxSpawner boxSpawner;
        [SerializeField] private BoxPackingAgent agent;
        [SerializeField] private RewardCalculator rewardCalculator;

        [Header("Current Config (Read Only)")]
        [SerializeField] private string loadedConfigName;
        [SerializeField] private string loadedConfigVersion;

        private Config currentConfig;

        private void Start()
        {
            if (loadOnStart)
            {
                LoadAndApplyConfig();
            }
        }

        /// <summary>
        /// Load config from JSON and apply to all components
        /// </summary>
        public void LoadAndApplyConfig()
        {
            string fullPath = Path.Combine(Application.dataPath, "..", configFilePath);

            if (!File.Exists(fullPath))
            {
                Debug.LogError($"Config file not found: {fullPath}");
                return;
            }

            try
            {
                string json = File.ReadAllText(fullPath);
                currentConfig = JsonUtility.FromJson<Config>(json);

                loadedConfigName = currentConfig.config_name;
                loadedConfigVersion = currentConfig.version;

                ApplyConfiguration();

                Debug.Log($"[EnvironmentConfig] Loaded and applied: {loadedConfigName} v{loadedConfigVersion}");
            }
            catch (System.Exception e)
            {
                Debug.LogError($"Error loading config: {e.Message}");
            }
        }

        /// <summary>
        /// Apply loaded configuration to all components
        /// </summary>
        private void ApplyConfiguration()
        {
            if (currentConfig == null)
            {
                Debug.LogError("No config loaded!");
                return;
            }

            // Apply pallet settings
            if (palletManager != null)
            {
                palletManager.palletSize = new Vector3(
                    currentConfig.pallet_settings.size_x,
                    currentConfig.pallet_settings.size_y,
                    currentConfig.pallet_settings.size_z
                );
                palletManager.maxWeight = currentConfig.pallet_settings.max_weight;
            }

            // Apply box generation settings
            if (boxSpawner != null)
            {
                // Note: BoxSpawner fields need to be public or have setters
                // You may need to add public properties or SerializeField to BoxSpawner
            }

            // Apply agent settings
            if (agent != null)
            {
                // Note: Agent fields need to be accessible
                // You may need to add public properties to BoxPackingAgent
            }

            // Apply reward settings
            if (rewardCalculator != null && currentConfig.reward_settings != null)
            {
                rewardCalculator.SetSuccessReward(currentConfig.reward_settings.success_reward);
                rewardCalculator.SetInvalidPenalty(currentConfig.reward_settings.invalid_placement_penalty);
                rewardCalculator.SetRewardShaping(currentConfig.reward_settings.use_reward_shaping);
                rewardCalculator.SetShapingComplexity(currentConfig.reward_settings.shaping_complexity);

                // Apply all shaped reward parameters
                rewardCalculator.SetVolumeWeight(currentConfig.reward_settings.volume_weight);
                rewardCalculator.SetVolumeEfficiencyBonus(currentConfig.reward_settings.volume_efficiency_bonus);
                rewardCalculator.SetFlatSurfaceBonus(currentConfig.reward_settings.flat_surface_bonus);
                rewardCalculator.SetSupportQualityWeight(currentConfig.reward_settings.support_quality_weight);
                rewardCalculator.SetHeightPenaltyWeight(currentConfig.reward_settings.height_penalty_weight);
                rewardCalculator.SetCornerPlacementBonus(currentConfig.reward_settings.corner_placement_bonus);
                rewardCalculator.SetSurfaceCreationBonus(currentConfig.reward_settings.surface_creation_bonus);
                rewardCalculator.SetGapPenaltyWeight(currentConfig.reward_settings.gap_penalty_weight);
                rewardCalculator.SetStabilityWeight(currentConfig.reward_settings.stability_weight);
            }
        }

        /// <summary>
        /// Save current Unity Inspector settings to JSON
        /// </summary>
        public void SaveCurrentSettings(string outputPath)
        {
            Config config = new Config();

            // Read current settings from components
            if (palletManager != null)
            {
                config.pallet_settings = new PalletSettings
                {
                    size_x = palletManager.palletSize.x,
                    size_y = palletManager.palletSize.y,
                    size_z = palletManager.palletSize.z,
                    max_weight = palletManager.maxWeight
                };
            }

            // ... populate other settings

            string json = JsonUtility.ToJson(config, true);
            string fullPath = Path.Combine(Application.dataPath, "..", outputPath);
            File.WriteAllText(fullPath, json);

            Debug.Log($"Config saved to: {fullPath}");
        }

        #region Data Classes

        [System.Serializable]
        public class Config
        {
            public string config_name;
            public string version;
            public string description;
            public PalletSettings pallet_settings;
            public BoxGeneration box_generation;
            public AgentSettings agent_settings;
            public RewardSettings reward_settings;
            public DecisionRequester decision_requester;
            public Visualization visualization;
        }

        [System.Serializable]
        public class PalletSettings
        {
            public float size_x;
            public float size_y;
            public float size_z;
            public float max_weight;
        }

        [System.Serializable]
        public class BoxGeneration
        {
            public float min_box_size_x;
            public float min_box_size_y;
            public float min_box_size_z;
            public float max_box_size_x;
            public float max_box_size_y;
            public float max_box_size_z;
            public float min_weight;
            public float max_weight;
            public string generation_strategy;
            public float size_variation;
        }

        [System.Serializable]
        public class AgentSettings
        {
            public int max_boxes_per_episode;
            public int grid_resolution;
            public float step_penalty;
            public bool end_on_invalid_placement;
            public int max_steps;
            public int box_preview_count;
            public bool include_height_map;
            public int height_map_resolution;
        }

        [System.Serializable]
        public class RewardSettings
        {
            public float success_reward;
            public float invalid_placement_penalty;
            public float volume_weight;
            public float volume_efficiency_bonus;
            public float flat_surface_bonus;
            public float support_quality_weight;
            public float height_penalty_weight;
            public float corner_placement_bonus;
            public float surface_creation_bonus;
            public float gap_penalty_weight;
            public float stability_weight;
            public bool use_reward_shaping;
            public float shaping_complexity;
        }

        [System.Serializable]
        public class DecisionRequester
        {
            public int decision_period;
            public bool take_actions_between_decisions;
        }

        [System.Serializable]
        public class Visualization
        {
            public bool visualize_actions;
            public bool debug_mode;
        }

        #endregion
    }
}
