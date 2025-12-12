using System;
using UnityEngine;

namespace Tasks._3DBPP.Curriculum
{
    /// <summary>
    /// Serializable data class for saving/loading grid patterns
    /// </summary>
    [Serializable]
    public class PatternData
    {
        public string patternName;
        public int gridResolution;
        public bool[] cells;
        public string description;

        public PatternData(string name, int resolution, bool[] pattern, string desc = "")
        {
            patternName = name;
            gridResolution = resolution;
            cells = pattern;
            description = desc;
        }

        /// <summary>
        /// Convert to JSON string
        /// </summary>
        public string ToJson()
        {
            return JsonUtility.ToJson(this, true);
        }

        /// <summary>
        /// Load from JSON string
        /// </summary>
        public static PatternData FromJson(string json)
        {
            return JsonUtility.FromJson<PatternData>(json);
        }
    }
}
