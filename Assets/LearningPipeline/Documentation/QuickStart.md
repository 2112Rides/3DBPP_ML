# Learning Pipeline - Quick Start Guide

## What is This?

A **reusable framework** for developing RL agents through:
- **Curriculum Learning** - Progressive difficulty
- **Imitation Learning** - Bootstrap from demos
- **Task Abstraction** - Works for any RL problem

---

## Recording Your First Demonstration

### Step 1: Implement IInputMapper

Create a script that maps keyboard input to actions:

```csharp
using LearningPipeline.Imitation;
using Unity.MLAgents.Actuators;

public class MyTaskInputMapper : MonoBehaviour, IInputMapper
{
    private int selectedAction = 0;

    public ActionBuffers MapInput()
    {
        // Map keyboard to actions
        if (Input.GetKeyDown(KeyCode.UpArrow)) selectedAction++;
        if (Input.GetKeyDown(KeyCode.DownArrow)) selectedAction--;

        return ActionBuffers.FromDiscreteActions(selectedAction);
    }

    public bool IsActionConfirmed()
    {
        return Input.GetKeyDown(KeyCode.Space);
    }

    public void DisplayInputHints()
    {
        // Optional: Show controls on screen
    }

    public void ResetInput()
    {
        selectedAction = 0;
    }

    public string GetInputStateString()
    {
        return $"Action: {selectedAction}";
    }
}
```

### Step 2: Setup Agent GameObject

1. Create GameObject with your `LearningAgent` subclass
2. Add `KeyboardController` component
3. Add `DemonstrationRecorder` component (from ML-Agents)
4. Add your `IInputMapper` implementation
5. Assign InputMapper to KeyboardController

### Step 3: Implement Heuristic()

In your agent class:

```csharp
public override void Heuristic(in ActionBuffers actionsOut)
{
    // Let KeyboardController handle input
    var keyboard = GetComponent<KeyboardController>();
    if (keyboard != null)
    {
        keyboard.GetHeuristicActions(actionsOut);
    }
}
```

### Step 4: Record Demonstrations

1. Press Play in Unity
2. Press `D` to start recording
3. Use your keyboard controls to solve the task
4. Episode ends → demo automatically saved
5. Press `D` to stop recording

**Demos saved to:** `Assets/Demonstrations/`

### Step 5: Train with Imitation

Create YAML config:

```yaml
behaviors:
  YourAgent:
    trainer_type: ppo

    behavioral_cloning:
      demo_path: Demonstrations/YourDemo.demo
      steps: 50000
      strength: 0.5

    # ... rest of config
```

Train:
```bash
mlagents-learn config.yaml --run-id=ImitationTest
```

---

## Framework Components

### Core Interfaces

**ILearningTask** - Define any learning task
```csharp
public interface ILearningTask
{
    string TaskName { get; }
    void SetDifficultyLevel(int level);
    float GetCurrentPerformance();
    void ResetTask();
}
```

**LearningAgent** - Base for all agents
```csharp
public abstract class LearningAgent : Agent
{
    public virtual void SetupTask(ILearningTask task);
    protected abstract void ResetAgent();
}
```

**IInputMapper** - Map keyboard to actions
```csharp
public interface IInputMapper
{
    ActionBuffers MapInput();
    bool IsActionConfirmed();
}
```

---

## File Structure

```
Assets/
├── LearningPipeline/           ← Framework (reusable)
│   ├── Core/                   ← Base classes
│   ├── Imitation/              ← Demo recording
│   └── Documentation/          ← This guide
│
└── Tasks/                      ← Your tasks here
    └── YourTask/
        ├── Agents/
        ├── Curriculum/
        └── Demonstrations/
```

---

## Next Steps

1. Look at `Tasks/3DBPP/` for complete example
2. Implement your own task
3. Record demonstrations
4. Train with imitation learning!

---

**Framework Version:** 1.0
**Last Updated:** 2025-12-02
