# Process-Task-Curriculum Architecture

## Overview

This architecture separates agent embodiment from task logic, enabling:
- **One agent to learn multiple tasks**
- **Curriculum learning** with automatic progression
- **Reusable components** across different processes
- **Scalable** from simple reach tasks to complex assembly/drumming/packing

## Core Concepts

```
ProcessAgent (Generic)
    ↓ uses
AgentBody (Embodiment)
    ↓ executes
ITask (Problem Definition)
    ↓ managed by
TaskManager (Curriculum)
```

### 1. **ProcessAgent** - Decision Maker
- Handles ML-Agents lifecycle (observations, actions, episodes)
- Delegates to current task for problem-specific logic
- **Generic across all tasks**

### 2. **AgentBody** - Physical Embodiment
- Controls joints, effectors, sensors
- Provides body observations (joint angles, velocities)
- Applies actions (torques, velocities)
- **Reusable across similar tasks** (e.g., same robot, different tasks)

### 3. **ITask** - Problem Definition
- Sets up environment (spawn objects, randomize)
- Defines observations (target positions, distances)
- Computes rewards (shaping, success bonuses)
- Checks termination (success/failure conditions)
- **One per skill/sub-skill**

### 4. **TaskManager** - Curriculum Controller
- Tracks performance per task
- Unlocks next task when criteria met
- Supports multiple curriculum modes (sequential, parallel, staged)
- **One per process/learning pipeline**

## File Structure

```
Assets/
├── LearningPipeline/
│   └── Core/
│       ├── ITask.cs                 # Task interface + TaskContext
│       ├── BaseTask.cs              # ScriptableObject base class
│       ├── AgentBody.cs             # Body abstraction
│       ├── SimpleAgentBody.cs       # Example body implementation
│       ├── ProcessAgent.cs          # Generic agent
│       └── TaskManager.cs           # Curriculum manager
└── Tasks/
    ├── Templates/
    │   └── SimpleReachTargetTask.cs # Example task
    ├── 3DBPP/
    │   ├── BoxPlacementTask.cs
    │   └── CornerPlacementTask.cs
    ├── Drumming/
    │   ├── HitStaticPadTask.cs
    │   └── HitMovingPadTask.cs
    └── Assembly/
        └── PlacePartInSlotTask.cs
```

## Quick Start

### Step 1: Create a Task

```csharp
[CreateAssetMenu(menuName = "AI/Tasks/MyTask")]
public class MyTask : BaseTask
{
    protected override void SetupEnvironment(TaskContext ctx)
    {
        // Spawn objects, randomize positions
    }

    protected override void AddTaskObservations(TaskContext ctx, VectorSensor sensor)
    {
        // Add observations (target position, distances, etc.)
    }

    protected override float CalculateReward(TaskContext ctx)
    {
        // Return reward for this step
    }

    protected override bool IsComplete(TaskContext ctx, out bool success)
    {
        // Check if task succeeded or failed
    }
}
```

### Step 2: Create Task Assets

1. Right-click in Project > Create > AI > Tasks > MyTask
2. Configure parameters in Inspector
3. Repeat for each task in curriculum

### Step 3: Setup Scene

#### A. Create Agent GameObject
```
AgentGameObject
├── ProcessAgent (component)
├── SimpleAgentBody (component)  // or your custom body
├── TaskManager (component)
└── Effector (child transform)   // used by body
```

#### B. Configure ProcessAgent
- **Agent Body**: Assign SimpleAgentBody component
- **Task Manager**: Assign TaskManager component
- **Environment Root**: Assign parent for spawned objects

#### C. Configure TaskManager
- **Curriculum**: Add task ScriptableObject assets
- **Unlock Success Rate**: e.g., 0.8 (80% success to advance)
- **Min Episodes**: e.g., 200 (minimum episodes before advancing)

#### D. Configure Behavior Parameters
- **Vector Observation Space Size**:
  - Body observations: 6 (SimpleAgentBody)
  - Base task observations: 2 (time, steps)
  - Custom task observations: varies
  - **Total**: Add them up
- **Actions**:
  - Continuous: 3 (SimpleAgentBody X,Y,Z velocity)
  - Or configure for your custom body

### Step 4: Train

```bash
mlagents-learn config.yaml --run-id=my_process
```

As agent masters each task, TaskManager automatically advances to next task in curriculum.

## Example Curriculum

### Process: 3D Bin Packing

```
Task 1: Place box in corner (stationary)
Task 2: Place box in specific corner (4 corners)
Task 3: Fill bottom layer
Task 4: Stack boxes (2 layers)
Task 5: Optimize volume utilization
Task 6: Handle mixed box sizes
```

### Process: Drumming

```
Task 1: Hit static pad
Task 2: Hit moving pad (X axis)
Task 3: Hit moving pad (XZ axes)
Task 4: Hit on rhythm (whole notes)
Task 5: Hit on rhythm (quarter notes)
Task 6: Play paradiddle pattern
```

### Process: Assembly

```
Task 1: Pick up part
Task 2: Place part in slot
Task 3: Align shaft through hole
Task 4: Attach arm to base
Task 5: Full assembly sequence
```

## Advanced Features

### Custom Agent Bodies

Subclass `AgentBody` for complex embodiments:

```csharp
public class ArticulatedArmBody : AgentBody
{
    [SerializeField] private ArticulationBody[] joints;

    public override void ApplyActions(float[] actions)
    {
        // Apply torques to joints
    }

    public override void CollectBodyObservations(VectorSensor sensor)
    {
        // Joint angles, velocities
    }
}
```

### Curriculum Modes

**Sequential** (default): Linear progression
```
Task1 → Task2 → Task3 → ...
```

**Parallel**: Sample from unlocked tasks (reinforces weaker skills)
```
Task1 ─┬→ Task2 ─┬→ Task4
       └→ Task3 ─┘
(randomly sample from unlocked)
```

**Staged**: Groups that must complete together
```
Stage 1: [Task1, Task2] → Stage 2: [Task3, Task4]
(all tasks in stage must master before advancing)
```

### Observation Strategy

Tasks should observe:
1. **Goal state** (where to go, what to achieve)
2. **Current state** (current position, progress)
3. **Relative information** (distance to target, error)
4. **Time** (normalized episode time for urgency)

Avoid:
- Absolute positions (use relative to body)
- Non-normalized values (normalize to [-1, 1] or [0, 1])
- Redundant information

### Reward Shaping Best Practices

```csharp
protected override float CalculateReward(TaskContext ctx)
{
    float reward = 0f;

    // 1. Dense shaping (small, frequent)
    float distance = Vector3.Distance(current, target);
    reward += Mathf.Clamp01(1f - distance / maxDist) * 0.01f;

    // 2. Progress rewards (milestones)
    if (ReachedCheckpoint()) reward += 1f;

    // 3. Success bonus (large, sparse)
    if (TaskComplete()) reward += 10f;

    // 4. Penalties (avoid unwanted behavior)
    if (InvalidAction()) reward -= 0.5f;

    return reward;
}
```

## Comparison to Current CornerPlacement

| Feature | Current (CornerPlacementAgent) | New (ProcessAgent) |
|---------|-------------------------------|-------------------|
| Agent-Task Separation | ✓ Partial | ✓ Full |
| Curriculum System | ✗ None | ✓ Automatic |
| Task Interface | `ILearningTask` (custom) | `ITask` (standardized) |
| TaskContext | ✗ None | ✓ Yes |
| Observation Collection | Agent queries task | Task contributes directly |
| Body Abstraction | ✗ Coupled | ✓ Separate component |
| Reusability | One agent per task | One agent many tasks |

## Migration Path

To migrate existing tasks:

1. **Keep**: Task logic (reward calculation, completion checks)
2. **Move**: Environment setup → `SetupEnvironment()`
3. **Move**: Observations → `AddTaskObservations()`
4. **Move**: Agent-specific code → `AgentBody` subclass
5. **Add**: TaskContext usage
6. **Create**: ScriptableObject task assets

## Next Steps

1. **Create your first task** using SimpleReachTargetTask as template
2. **Build curriculum** with 3-5 progressive tasks
3. **Train** and observe automatic curriculum advancement
4. **Iterate** on reward shaping and observations
5. **Scale** to complex multi-step processes

---

*Generated for 3DBPP_ML project - Process-based curriculum learning architecture*
