using UnityEngine;
using System.Collections.Generic;

namespace BoxPacking.MLAgents
{
    /// <summary>
    /// Generates sequences of boxes for packing episodes
    /// </summary>
    public class BoxSpawner : MonoBehaviour
    {
        #region Serialized Fields
        
        [Header("Box Generation Settings")]
        [Tooltip("Minimum box size")]
        [SerializeField] private Vector3 minBoxSize = new Vector3(10f, 10f, 10f);
        
        [Tooltip("Maximum box size")]
        [SerializeField] private Vector3 maxBoxSize = new Vector3(50f, 50f, 50f);
        
        [Tooltip("Minimum box weight")]
        [SerializeField] private float minWeight = 1f;
        
        [Tooltip("Maximum box weight")]
        [SerializeField] private float maxWeight = 50f;
        
        [Header("Generation Strategy")]
        [Tooltip("Type of box generation strategy")]
        [SerializeField] private GenerationStrategy strategy = GenerationStrategy.Random;
        
        [Tooltip("Size variation (for curriculum learning, 0-1)")]
        [SerializeField] private float sizeVariation = 1.0f;
        
        [Tooltip("Use fixed seed for reproducibility")]
        [SerializeField] private bool useFixedSeed = false;
        
        [SerializeField] private int randomSeed = 12345;
        
        [Header("Predefined Sets")]
        [Tooltip("List of predefined box sets for testing")]
        [SerializeField] private List<BoxSet> predefinedSets = new List<BoxSet>();
        
        [SerializeField] private int currentSetIndex = 0;
        
        [Header("Curriculum Parameters")]
        [Tooltip("Current difficulty level (controlled by curriculum)")]
        public float difficultyLevel = 0.5f;
        
        #endregion
        
        #region Private Fields
        
        private System.Random random;
        private int generationCount = 0;
        
        #endregion
        
        #region Initialization
        
        public void Initialize()
        {
            if (useFixedSeed)
            {
                random = new System.Random(randomSeed);
            }
            else
            {
                random = new System.Random();
            }
        }
        
        #endregion
        
        #region Box Generation
        
        /// <summary>
        /// Generate a set of boxes for an episode
        /// </summary>
        public List<Box> GenerateBoxSet(int count)
        {
            generationCount++;
            
            switch (strategy)
            {
                case GenerationStrategy.Random:
                    return GenerateRandomBoxes(count);
                
                case GenerationStrategy.SimilarSizes:
                    return GenerateSimilarSizeBoxes(count);
                
                case GenerationStrategy.Graduated:
                    return GenerateGraduatedBoxes(count);
                
                case GenerationStrategy.Predefined:
                    return GetPredefinedSet();
                
                case GenerationStrategy.Curriculum:
                    return GenerateCurriculumBoxes(count);
                
                default:
                    return GenerateRandomBoxes(count);
            }
        }
        
        /// <summary>
        /// Generate completely random boxes
        /// </summary>
        private List<Box> GenerateRandomBoxes(int count)
        {
            List<Box> boxes = new List<Box>();
            
            for (int i = 0; i < count; i++)
            {
                boxes.Add(GenerateRandomBox());
            }
            
            return boxes;
        }
        
        /// <summary>
        /// Generate boxes with similar sizes (easier for learning)
        /// </summary>
        private List<Box> GenerateSimilarSizeBoxes(int count)
        {
            List<Box> boxes = new List<Box>();
            
            // Generate a base size
            Vector3 baseSize = new Vector3(
                RandomRange(minBoxSize.x, maxBoxSize.x),
                RandomRange(minBoxSize.y, maxBoxSize.y),
                RandomRange(minBoxSize.z, maxBoxSize.z)
            );
            
            // Generate boxes with small variations from base size
            for (int i = 0; i < count; i++)
            {
                float variation = 0.2f * sizeVariation;
                Vector3 size = new Vector3(
                    baseSize.x * RandomRange(1f - variation, 1f + variation),
                    baseSize.y * RandomRange(1f - variation, 1f + variation),
                    baseSize.z * RandomRange(1f - variation, 1f + variation)
                );
                
                size = ClampSize(size);
                
                Box box = new Box
                {
                    id = i,
                    size = size,
                    weight = CalculateWeight(size),
                    color = GenerateColor(i)
                };
                
                boxes.Add(box);
            }
            
            return boxes;
        }
        
        /// <summary>
        /// Generate boxes in graduated sizes (largest to smallest or vice versa)
        /// </summary>
        private List<Box> GenerateGraduatedBoxes(int count)
        {
            List<Box> boxes = new List<Box>();
            
            bool largestFirst = random.NextDouble() > 0.5;
            
            for (int i = 0; i < count; i++)
            {
                float t = i / (float)(count - 1);
                if (!largestFirst) t = 1f - t;
                
                Vector3 size = Vector3.Lerp(minBoxSize, maxBoxSize, t);
                
                // Add some randomness
                size.x *= RandomRange(0.9f, 1.1f);
                size.y *= RandomRange(0.9f, 1.1f);
                size.z *= RandomRange(0.9f, 1.1f);
                
                size = ClampSize(size);
                
                Box box = new Box
                {
                    id = i,
                    size = size,
                    weight = CalculateWeight(size),
                    color = GenerateColor(i)
                };
                
                boxes.Add(box);
            }
            
            return boxes;
        }
        
        /// <summary>
        /// Get predefined box set
        /// </summary>
        private List<Box> GetPredefinedSet()
        {
            if (predefinedSets.Count == 0)
            {
                Debug.LogWarning("No predefined sets available, falling back to random generation");
                return GenerateRandomBoxes(10);
            }
            
            BoxSet set = predefinedSets[currentSetIndex % predefinedSets.Count];
            currentSetIndex++;
            
            return set.GetBoxes();
        }
        
        /// <summary>
        /// Generate boxes based on curriculum difficulty
        /// </summary>
        private List<Box> GenerateCurriculumBoxes(int count)
        {
            List<Box> boxes = new List<Box>();
            
            // Adjust parameters based on difficulty
            // Easy (0.0) -> Similar sizes, few boxes
            // Hard (1.0) -> Varied sizes, many boxes
            
            float currentVariation = Mathf.Lerp(0.2f, 1.0f, difficultyLevel);
            
            Vector3 baseSize = new Vector3(
                Mathf.Lerp(minBoxSize.x, maxBoxSize.x, 0.5f),
                Mathf.Lerp(minBoxSize.y, maxBoxSize.y, 0.5f),
                Mathf.Lerp(minBoxSize.z, maxBoxSize.z, 0.5f)
            );
            
            for (int i = 0; i < count; i++)
            {
                Vector3 size = new Vector3(
                    baseSize.x * RandomRange(1f - currentVariation, 1f + currentVariation),
                    baseSize.y * RandomRange(1f - currentVariation, 1f + currentVariation),
                    baseSize.z * RandomRange(1f - currentVariation, 1f + currentVariation)
                );
                
                size = ClampSize(size);
                
                Box box = new Box
                {
                    id = i,
                    size = size,
                    weight = CalculateWeight(size),
                    color = GenerateColor(i)
                };
                
                boxes.Add(box);
            }
            
            return boxes;
        }
        
        /// <summary>
        /// Generate a single random box
        /// </summary>
        private Box GenerateRandomBox()
        {
            Vector3 size = new Vector3(
                RandomRange(minBoxSize.x, maxBoxSize.x),
                RandomRange(minBoxSize.y, maxBoxSize.y),
                RandomRange(minBoxSize.z, maxBoxSize.z)
            );
            
            return new Box
            {
                id = generationCount,
                size = size,
                weight = CalculateWeight(size),
                color = GenerateColor(generationCount)
            };
        }
        
        #endregion
        
        #region Helper Methods
        
        private float RandomRange(float min, float max)
        {
            return (float)(random.NextDouble() * (max - min) + min);
        }
        
        private Vector3 ClampSize(Vector3 size)
        {
            return new Vector3(
                Mathf.Clamp(size.x, minBoxSize.x, maxBoxSize.x),
                Mathf.Clamp(size.y, minBoxSize.y, maxBoxSize.y),
                Mathf.Clamp(size.z, minBoxSize.z, maxBoxSize.z)
            );
        }
        
        private float CalculateWeight(Vector3 size)
        {
            // Weight is proportional to volume but with some randomness
            float volume = size.x * size.y * size.z;
            float maxVolume = maxBoxSize.x * maxBoxSize.y * maxBoxSize.z;
            
            float baseWeight = Mathf.Lerp(minWeight, maxWeight, volume / maxVolume);
            float randomFactor = RandomRange(0.8f, 1.2f);
            
            return baseWeight * randomFactor;
        }
        
        private Color GenerateColor(int index)
        {
            // Generate deterministic but varied colors
            float hue = (index * 0.618033988749895f) % 1.0f; // Golden ratio for distribution
            return Color.HSVToRGB(hue, 0.7f, 0.9f);
        }
        
        #endregion
        
        #region Public Methods
        
        /// <summary>
        /// Set generation strategy
        /// </summary>
        public void SetStrategy(GenerationStrategy newStrategy)
        {
            strategy = newStrategy;
        }
        
        /// <summary>
        /// Set difficulty level (for curriculum learning)
        /// </summary>
        public void SetDifficulty(float difficulty)
        {
            difficultyLevel = Mathf.Clamp01(difficulty);
        }
        
        /// <summary>
        /// Set size variation
        /// </summary>
        public void SetSizeVariation(float variation)
        {
            sizeVariation = Mathf.Clamp01(variation);
        }
        
        /// <summary>
        /// Add a predefined box set
        /// </summary>
        public void AddPredefinedSet(BoxSet set)
        {
            predefinedSets.Add(set);
        }
        
        #endregion
    }
    
    #region Enums and Classes
    
    public enum GenerationStrategy
    {
        Random,          // Completely random boxes
        SimilarSizes,    // Boxes with similar dimensions
        Graduated,       // Boxes in graduated sizes
        Predefined,      // Use predefined sets
        Curriculum       // Adjust based on curriculum difficulty
    }
    
    [System.Serializable]
    public class BoxSet
    {
        public string name;
        public List<BoxDefinition> boxes = new List<BoxDefinition>();
        
        public List<Box> GetBoxes()
        {
            List<Box> result = new List<Box>();
            for (int i = 0; i < boxes.Count; i++)
            {
                result.Add(boxes[i].ToBox(i));
            }
            return result;
        }
    }
    
    [System.Serializable]
    public class BoxDefinition
    {
        public Vector3 size;
        public float weight;
        public Color color = Color.white;
        
        public Box ToBox(int id)
        {
            return new Box
            {
                id = id,
                size = size,
                weight = weight,
                color = color
            };
        }
    }
    
    #endregion
}
