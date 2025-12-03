# Generalized Learning Development Pipeline

## Vision

Create a **reusable, task-agnostic framework** for developing complex RL agents through:
- **Curriculum Learning** - Progressive difficulty scaling
- **Imitation Learning** - Bootstrap from demonstrations
- **Behavioral Primitives** - Composable skill building
- **Automated Testing** - Validate each learning stage

**This pipeline will be reused for:**
- 3D Bin Packing (first implementation)
- Robotic Manipulation
- Navigation tasks
- Multi-agent coordination
- Any complex RL problem

---

## Architecture Principles

### 1. **Separation of Concerns**
```
Task-Specific Code (3DBPP)   →   Isolated in task folder
Generic Pipeline Code         →   Reusable framework
Demonstrations               →   Standard format
Curriculum Definitions       →   Declarative YAML
```

### 2. **Clean Folder Structure**
```
Assets/
├── LearningPipeline/                    ← NEW: Generic framework
│   ├── Core/                            ← Core abstractions
│   ├── Curriculum/                      ← Curriculum system
│   ├── Imitation/                       ← Demo recording & playback
│   ├── Evaluation/                      ← Testing & metrics
│   └── Documentation/                   ← Framework docs
│
├── Tasks/                               ← NEW: All tasks here
│   ├── 3DBPP/                          ← Bin packing task
│   │   ├── Agents/                     ← Agent implementations
│   │   ├── Curriculum/                 ← Task-specific lessons
│   │   ├── Demonstrations/             ← Recorded demos
│   │   ├── Heuristics/                 ← Expert algorithms
│   │   └── Configs/                    ← Task configs
│   │
│   ├── RoboticArm/                     ← Future task
│   └── Navigation/                      ← Future task
│
└── Scripts/                             ← EXISTING CODE (untouched)
    └── BoxPacking/                      ← Current working system
        ├── BoxPackingAgent.cs           ← Keep as-is
        ├── PalletManager.cs
        ├── RewardCalculator.cs
        └── ...
```

### 3. **Namespace Organization**
```csharp
namespace LearningPipeline.Core { }              // Generic abstractions
namespace LearningPipeline.Curriculum { }        // Curriculum system
namespace LearningPipeline.Imitation { }         // Imitation learning
namespace LearningPipeline.Evaluation { }        // Testing framework

namespace Tasks._3DBPP.Agents { }                // 3DBPP agents
namespace Tasks._3DBPP.Curriculum { }            // 3DBPP lessons
namespace Tasks._3DBPP.Heuristics { }            // 3DBPP algorithms

namespace Tasks.RoboticArm { }                   // Future tasks
```

---

## Framework Components

### **Core Abstractions** (`LearningPipeline/Core/`)

#### 1. `ILearningTask.cs` - Task Interface
```csharp
namespace LearningPipeline.Core
{
    /// <summary>
    /// Generic interface that any learning task must implement
    /// </summary>
    public interface ILearningTask
    {
        string TaskName { get; }
        string TaskDescription { get; }

        // Curriculum support
        void SetDifficultyLevel(int level);
        float GetCurrentPerformance();
        bool IsLessonComplete();

        // Reset
        void ResetTask();

        // Metrics
        Dictionary<string, float> GetMetrics();
    }
}
```

#### 2. `LearningAgent.cs` - Generic Agent Base
```csharp
namespace LearningPipeline.Core
{
    /// <summary>
    /// Base class for all learning agents in the pipeline
    /// Extends Unity ML-Agents Agent class
    /// </summary>
    public abstract class LearningAgent : Agent
    {
        protected ILearningTask task;
        protected CurriculumController curriculum;
        protected MetricsTracker metrics;

        // Generic methods all agents share
        public abstract void SetupTask(ILearningTask task);
        public abstract float CalculateReward();
        public abstract bool IsEpisodeComplete();

        // Curriculum integration
        protected void UpdateCurriculumProgress() { }

        // Metrics tracking
        protected void RecordMetric(string name, float value) { }
    }
}
```

#### 3. `RewardComponent.cs` - Modular Rewards
```csharp
namespace LearningPipeline.Core
{
    /// <summary>
    /// Base class for composable reward components
    /// </summary>
    public abstract class RewardComponent
    {
        public string Name { get; set; }
        public float Weight { get; set; }

        public abstract float CalculateReward(AgentState state, ActionResult result);
    }

    // Example usage:
    // reward = successReward.Calculate() + volumeReward.Calculate() + ...
}
```

---

### **Curriculum System** (`LearningPipeline/Curriculum/`)

#### 1. `CurriculumController.cs`
```csharp
namespace LearningPipeline.Curriculum
{
    /// <summary>
    /// Manages progression through curriculum lessons
    /// </summary>
    public class CurriculumController : MonoBehaviour
    {
        [SerializeField] private List<LessonConfig> lessons;
        private int currentLesson = 0;

        public void CheckLessonCompletion()
        {
            if (CurrentLessonComplete())
            {
                ProgressToNextLesson();
            }
        }

        public LessonConfig GetCurrentLesson() { }
        public void ApplyLessonSettings(ILearningTask task) { }
    }
}
```

#### 2. `LessonConfig.cs` - Lesson Definition
```csharp
namespace LearningPipeline.Curriculum
{
    [System.Serializable]
    public class LessonConfig
    {
        public string lessonName;
        public string description;

        // Completion criteria
        public CompletionType completionType; // Reward, Time, SuccessRate
        public float completionThreshold;
        public int minEpisodes;

        // Lesson parameters (generic dictionary)
        public Dictionary<string, object> parameters;

        // Demonstrations
        public string demoPath;
        public bool useImitation;
    }
}
```

#### 3. Lesson Examples (YAML)
```yaml
# 3DBPP_Curriculum.yaml
curriculum:
  - lesson: "L1_CornerPlacement"
    description: "Learn to place boxes in corners"
    parameters:
      max_boxes: 4
      allowed_positions: "corners_only"
      box_size: [20, 20, 20]
    completion:
      type: "reward"
      threshold: 35.0
      min_episodes: 50
    imitation:
      demo_path: "Demos/3DBPP/Corners.demo"
      use_behavioral_cloning: true

  - lesson: "L2_EdgeFilling"
    description: "Fill edges after corners"
    parameters:
      max_boxes: 8
      strategy_hint: "edges_after_corners"
    completion:
      type: "reward"
      threshold: 60.0
```

---

### **Imitation Learning** (`LearningPipeline/Imitation/`)

#### 1. `DemonstrationRecorder.cs`
```csharp
namespace LearningPipeline.Imitation
{
    /// <summary>
    /// Records human/heuristic demonstrations for any task
    /// </summary>
    public class DemonstrationRecorder : MonoBehaviour
    {
        private bool isRecording = false;
        private DemonstrationStore currentDemo;

        public void StartRecording(string taskName) { }
        public void StopRecording() { }
        public void RecordAction(ActionBuffers actions) { }
        public void SaveDemo(string path) { }
    }
}
```

#### 2. `KeyboardController.cs` - Generic Input
```csharp
namespace LearningPipeline.Imitation
{
    /// <summary>
    /// Generic keyboard controller for recording demonstrations
    /// Task-specific mappings injected via interface
    /// </summary>
    public class KeyboardController : MonoBehaviour
    {
        private IInputMapper inputMapper;
        private DemonstrationRecorder recorder;

        void Update()
        {
            if (!isRecording) return;

            // Get input from task-specific mapper
            ActionBuffers actions = inputMapper.MapInput();
            recorder.RecordAction(actions);
        }

        public void SetInputMapper(IInputMapper mapper) { }
    }
}
```

#### 3. `IInputMapper.cs` - Task-Specific Input
```csharp
namespace LearningPipeline.Imitation
{
    /// <summary>
    /// Interface for task-specific input mapping
    /// </summary>
    public interface IInputMapper
    {
        ActionBuffers MapInput();
        void DisplayInputHints();
    }
}
```

---

### **Evaluation System** (`LearningPipeline/Evaluation/`)

#### 1. `EvaluationSuite.cs`
```csharp
namespace LearningPipeline.Evaluation
{
    /// <summary>
    /// Runs standardized tests on trained agents
    /// </summary>
    public class EvaluationSuite : MonoBehaviour
    {
        public EvaluationResults RunEvaluation(Agent agent, int episodes = 100)
        {
            // Run test episodes
            // Collect metrics
            // Generate report
        }

        public void GenerateReport(EvaluationResults results, string outputPath) { }
    }
}
```

#### 2. `MetricsTracker.cs`
```csharp
namespace LearningPipeline.Evaluation
{
    /// <summary>
    /// Tracks and aggregates metrics across episodes
    /// </summary>
    public class MetricsTracker
    {
        private Dictionary<string, List<float>> metrics;

        public void RecordMetric(string name, float value) { }
        public float GetMean(string name) { }
        public float GetStd(string name) { }
        public void ExportToCSV(string path) { }
    }
}
```

---

## Task-Specific Implementation (3DBPP)

### **Folder: `Assets/Tasks/3DBPP/`**

#### 1. `Agents/CurriculumBinPackingAgent.cs`
```csharp
namespace Tasks._3DBPP.Agents
{
    using LearningPipeline.Core;
    using LearningPipeline.Curriculum;

    /// <summary>
    /// 3DBPP agent that uses curriculum learning
    /// Extends generic LearningAgent base class
    /// </summary>
    public class CurriculumBinPackingAgent : LearningAgent
    {
        // 3DBPP-specific components
        private PalletManager palletManager;
        private BoxSpawner boxSpawner;

        // Curriculum lesson parameters
        private int maxBoxesForLesson;
        private bool allowStackingForLesson;
        private Vector3 fixedBoxSize; // For single-SKU lessons

        public override void SetupTask(ILearningTask task)
        {
            // Cast to 3DBPP task and configure
        }

        public override float CalculateReward()
        {
            // 3DBPP-specific reward logic
            // But uses RewardComponent base classes
        }
    }
}
```

#### 2. `Curriculum/Lesson_L1_Corners.cs`
```csharp
namespace Tasks._3DBPP.Curriculum
{
    using LearningPipeline.Curriculum;

    /// <summary>
    /// Lesson 1: Corner placement
    /// </summary>
    public class Lesson_L1_Corners : LessonConfig
    {
        public Lesson_L1_Corners()
        {
            lessonName = "L1_CornerPlacement";
            description = "Place 4 boxes, one in each corner";

            parameters = new Dictionary<string, object>
            {
                { "max_boxes", 4 },
                { "box_size", new Vector3(20, 20, 20) },
                { "allow_stacking", false },
                { "reward_corner_placement", 10.0f }
            };

            completionThreshold = 35.0f;
            minEpisodes = 50;
        }
    }
}
```

#### 3. `Heuristics/BottomLeftFillSolver.cs`
```csharp
namespace Tasks._3DBPP.Heuristics
{
    using LearningPipeline.Imitation;

    /// <summary>
    /// Bottom-Left-Fill heuristic for 3DBPP
    /// Can generate demonstrations automatically
    /// </summary>
    public class BottomLeftFillSolver : IExpertSolver
    {
        public List<PlacementAction> Solve(List<Box> boxes, PalletManager pallet)
        {
            // Implement BLF algorithm
            // Return sequence of placements
        }

        public void RecordAsDemonstration(string outputPath)
        {
            // Play solution step-by-step
            // DemonstrationRecorder captures it
        }
    }
}
```

#### 4. `Configs/3DBPP_InputMapper.cs`
```csharp
namespace Tasks._3DBPP.Configs
{
    using LearningPipeline.Imitation;

    /// <summary>
    /// Maps keyboard input to 3DBPP actions
    /// </summary>
    public class BinPackingInputMapper : IInputMapper
    {
        private int gridX, gridZ, rotation;

        public ActionBuffers MapInput()
        {
            // Arrow keys → grid position
            if (Input.GetKeyDown(KeyCode.UpArrow)) gridZ++;
            if (Input.GetKeyDown(KeyCode.DownArrow)) gridZ--;
            // etc...

            // Return discrete action
            int action = EncodeAction(gridX, gridZ, rotation);
            return ActionBuffers.FromDiscreteActions(action);
        }

        public void DisplayInputHints()
        {
            // Show on-screen hints for keyboard controls
        }
    }
}
```

---

## Workflow: Adding a New Task

### Example: Robotic Arm Pick-and-Place

```
1. Create folder: Assets/Tasks/RoboticArm/

2. Implement ILearningTask:
   namespace Tasks.RoboticArm {
       public class PickPlaceTask : ILearningTask { }
   }

3. Create agent extending LearningAgent:
   public class RoboticArmAgent : LearningAgent { }

4. Define curriculum:
   - L1_ReachTarget.cs
   - L2_PickObject.cs
   - L3_PlaceObject.cs
   - L4_StackObjects.cs

5. Create input mapper:
   public class ArmInputMapper : IInputMapper { }

6. Define heuristics:
   public class InverseKinematicsSolver : IExpertSolver { }

7. Configure YAML:
   curriculum: RoboticArm_Curriculum.yaml

8. Train:
   mlagents-learn RoboticArm_Curriculum.yaml --run-id=Arm_v1
```

**No changes to LearningPipeline framework needed!**

---

## Benefits of This Architecture

### ✅ **Reusability**
- Write framework once, use for all tasks
- Each new task just implements interfaces

### ✅ **Maintainability**
- Clear separation of generic vs task-specific code
- Easy to update framework without breaking tasks

### ✅ **Scalability**
- Add new tasks without modifying existing code
- Parallel development of multiple tasks

### ✅ **Testing**
- Test framework independently
- Task-specific tests isolated

### ✅ **Collaboration**
- Clear contracts (interfaces)
- Multiple developers can work on different tasks

---

## Implementation Phases

### **Phase 1: Framework Foundation** (Week 1)
- [ ] Create folder structure
- [ ] Implement core interfaces (ILearningTask, LearningAgent)
- [ ] Basic curriculum controller
- [ ] Demonstration recorder
- [ ] Documentation

### **Phase 2: 3DBPP Migration** (Week 2)
- [ ] Create Tasks/3DBPP/ folder
- [ ] Migrate current 3DBPP code to use framework
- [ ] Keep old code intact (backward compatibility)
- [ ] Verify identical behavior

### **Phase 3: Curriculum Lessons** (Week 3)
- [ ] Implement L1-L4 for 3DBPP
- [ ] Keyboard controller + input mapper
- [ ] Test each lesson independently

### **Phase 4: Imitation Learning** (Week 4)
- [ ] Record human demonstrations
- [ ] Implement heuristic solvers
- [ ] Behavioral cloning integration
- [ ] Compare imitation vs from-scratch training

### **Phase 5: Second Task** (Week 5)
- [ ] Choose second task (navigation? manipulation?)
- [ ] Implement using framework
- [ ] Validate framework generality
- [ ] Refine based on learnings

---

## File Structure Summary

```
Assets/
├── LearningPipeline/              ← Generic, reusable framework
│   ├── Core/
│   │   ├── ILearningTask.cs
│   │   ├── LearningAgent.cs
│   │   ├── RewardComponent.cs
│   │   └── AgentState.cs
│   ├── Curriculum/
│   │   ├── CurriculumController.cs
│   │   ├── LessonConfig.cs
│   │   └── CompletionCriteria.cs
│   ├── Imitation/
│   │   ├── DemonstrationRecorder.cs
│   │   ├── KeyboardController.cs
│   │   ├── IInputMapper.cs
│   │   └── IExpertSolver.cs
│   ├── Evaluation/
│   │   ├── EvaluationSuite.cs
│   │   ├── MetricsTracker.cs
│   │   └── PerformanceReport.cs
│   └── Documentation/
│       └── FrameworkGuide.md
│
├── Tasks/                         ← Task-specific implementations
│   └── 3DBPP/
│       ├── Agents/
│       │   ├── CurriculumBinPackingAgent.cs
│       │   └── BinPackingTask.cs
│       ├── Curriculum/
│       │   ├── Lesson_L1_Corners.cs
│       │   ├── Lesson_L2_SingleLayer.cs
│       │   ├── Lesson_L3_TwoLayers.cs
│       │   └── Lesson_L4_Full3DBPP.cs
│       ├── Heuristics/
│       │   ├── BottomLeftFillSolver.cs
│       │   ├── MaximalSpacesSolver.cs
│       │   └── LayerGreedySolver.cs
│       ├── Configs/
│       │   ├── BinPackingInputMapper.cs
│       │   └── 3DBPP_Curriculum.yaml
│       └── Demonstrations/
│           ├── Corners.demo
│           ├── SingleLayer.demo
│           └── FullSolution.demo
│
└── Scripts/BoxPacking/            ← EXISTING CODE (preserved)
    ├── BoxPackingAgent.cs         ← Keep working as-is
    ├── PalletManager.cs
    └── ...
```

---

## Next Steps

1. **Review this architecture** - Does it meet your requirements?
2. **Approve folder structure** - Any changes needed?
3. **Begin Phase 1** - Create framework foundation
4. **Commit before coding** - Always commit current state first

**Ready to proceed?**
