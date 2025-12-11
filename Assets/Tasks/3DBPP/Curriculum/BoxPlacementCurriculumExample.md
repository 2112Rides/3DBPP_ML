# 3DBPP Curriculum Example

## Curriculum Design for 3D Bin Packing Process

This document outlines how to apply the Process-Task-Curriculum architecture to 3D Bin Packing.

## Process Breakdown

**Goal**: Agent that can efficiently pack boxes into a pallet/container

**Sub-skills needed**:
1. Place box at specific location
2. Recognize corner/edge positions
3. Stack boxes vertically
4. Optimize horizontal space
5. Handle different box sizes
6. Maximize volume utilization

## Curriculum Tasks (Progressive)

### Task 1: Corner Placement ✓ (Already Implemented)
**Goal**: Place one box in each of 4 corners

**Success**: All 4 corners occupied

**Teaches**:
- Basic placement control
- Corner recognition
- Grid-based positioning

**Current Status**: CornerPlacementTask.cs exists (can be migrated to new architecture)

---

### Task 2: Edge Placement
**Goal**: Place boxes along pallet edges (8 edge positions)

**Success**: All 8 edge positions filled

**Teaches**:
- Edge detection
- More precise placement
- Filling perimeter

**Implementation**:
```csharp
[CreateAssetMenu(menuName = "AI/Tasks/3DBPP/EdgePlacement")]
public class EdgePlacementTask : BaseTask
{
    private bool[] edgesFilled = new bool[8]; // 4 corners + 4 midpoints

    protected override float CalculateReward(TaskContext ctx)
    {
        // +10 for new edge filled
        // -1 for non-edge placement
    }
}
```

---

### Task 3: Bottom Layer Fill
**Goal**: Completely fill bottom layer (no gaps)

**Success**: ≥90% bottom layer coverage

**Teaches**:
- Space optimization
- Gap avoidance
- Tessellation patterns

**Difficulty Progression**:
- Level 1: Fixed box size (easy tessellation)
- Level 2: 2 box sizes
- Level 3: 3+ box sizes

---

### Task 4: Two-Layer Stack
**Goal**: Pack boxes in 2 layers

**Success**: Both layers have boxes, stable configuration

**Teaches**:
- Vertical stacking
- Stability awareness
- Height utilization

**Reward Shaping**:
```
- Bottom layer coverage: +0.01 per % coverage
- Second layer placement: +5 per box
- Stability bonus: +2 if no falling
- Height utilization: +0.1 per height used
```

---

### Task 5: Volume Optimization
**Goal**: Maximize volume utilization

**Success**: ≥70% volume utilization

**Teaches**:
- Global optimization
- Balancing fill vs stability
- Multi-layer planning

**Metrics**:
```
Volume Utilization = (Total Box Volume) / (Pallet Volume)
```

---

### Task 6: Mixed Box Sizes
**Goal**: Pack randomly sized boxes efficiently

**Success**: ≥60% utilization with 5+ different box sizes

**Teaches**:
- Adaptive placement
- Size matching
- Complex spatial reasoning

**Box Size Distribution**:
- Small: 20x20x20
- Medium: 30x30x30
- Large: 40x40x40
- Rectangular: 20x30x40
- Flat: 50x50x10

---

### Task 7: Time-Constrained Packing
**Goal**: Pack quickly while maintaining efficiency

**Success**: ≥50% utilization in <30 seconds

**Teaches**:
- Speed vs efficiency tradeoff
- Quick decision making
- Real-world constraints

---

## Implementation Strategy

### Phase 1: Migrate CornerPlacementTask
1. Create `CornerPlacementTaskV2.cs` inheriting from `BaseTask`
2. Move logic from old `CornerPlacementTask.cs`
3. Test with `ProcessAgent` + `TaskManager`

### Phase 2: Create AgentBody for 3DBPP
```csharp
public class BoxPlacementBody : AgentBody
{
    // Action space: grid X, grid Z, rotation (discrete)
    // OR: continuous X, Z, rotation

    public override void ApplyActions(float[] actions)
    {
        // Apply placement action
        // Handle box spawning, validation, physics
    }

    public override void CollectBodyObservations(VectorSensor sensor)
    {
        // Pallet state (grid occupancy)
        // Current box size
        // Available space
    }
}
```

### Phase 3: Build Curriculum
Create ScriptableObject assets:
1. `CornerPlacement.asset` (unlockSuccessRate: 0.8, minEpisodes: 200)
2. `EdgePlacement.asset` (unlockSuccessRate: 0.75, minEpisodes: 300)
3. `BottomLayerFill.asset` (unlockSuccessRate: 0.7, minEpisodes: 500)
4. ... etc.

Add to TaskManager curriculum list in order.

### Phase 4: Train
```yaml
behaviors:
  3DBPPAgent:
    trainer_type: ppo
    hyperparameters:
      learning_rate: 3.0e-4
      batch_size: 1024
      buffer_size: 10240
    network_settings:
      hidden_units: 256
      num_layers: 3
    reward_signals:
      extrinsic:
        strength: 1.0
        gamma: 0.99
    behavioral_cloning:
      demo_path: Demos/3DBPP_Curriculum.demo
      strength: 0.5
      steps: 150000
```

## Observation Space Design

### Body Observations (constant across tasks)
- Current box size: 3 floats (normalized)
- Boxes placed: 1 float (normalized)
- Pallet occupancy grid: NxN floats (binary or height)

Example: 8x8 grid = 64 floats
Total body obs: ~70 floats

### Task-Specific Observations (varies per task)

**CornerPlacement**:
- Corner occupied flags: 4 floats (binary)
- Distance to nearest unoccupied corner: 1 float

**EdgePlacement**:
- Edge occupied flags: 8 floats (binary)
- Distance to nearest unoccupied edge: 1 float

**VolumeOptimization**:
- Current volume utilization: 1 float
- Average height: 1 float
- Coverage per layer: 4 floats (if 4 max layers)

## Action Space Options

### Option A: Discrete (Current CornerPlacement approach)
```
Branch 0: Grid X (0-7) = 8 actions
Branch 1: Grid Z (0-7) = 8 actions
Branch 2: Rotation (0°, 90°, 180°, 270°) = 4 actions
Total: 8 × 8 × 4 = 256 action combinations
```

**Pros**: Clean grid alignment, easy demonstrations
**Cons**: Limited precision, doesn't scale to large pallets

### Option B: Continuous
```
Action 0: X position (normalized 0-1)
Action 1: Z position (normalized 0-1)
Action 2: Rotation (normalized 0-1, maps to 0-360°)
Total: 3 continuous actions
```

**Pros**: Scalable, precise placement
**Cons**: Harder to learn, needs reward shaping

### Recommendation
Start with Discrete for curriculum Tasks 1-3, transition to Continuous for Tasks 4-7.

## Demo Collection Strategy

### Task 1: Corner Placement
Record 50-100 demos using heuristic keyboard control:
- Demonstrate each corner
- Show different placement orders
- Include some "mistakes" (helps with recovery)

### Task 2: Edge Placement
Record 100-150 demos:
- Systematic edge filling
- Different patterns (clockwise, perimeter-first)

### Later Tasks
- Use trained model from previous task as starting point
- Record only corrective demos (to fix bad behaviors)
- Use self-play to generate diverse examples

## Expected Performance

| Task | Episodes to Master | Success Rate | Notes |
|------|-------------------|--------------|-------|
| 1. Corner Placement | 200-500 | 80%+ | Fast, simple goal |
| 2. Edge Placement | 500-1000 | 75%+ | More positions |
| 3. Bottom Layer Fill | 1000-2000 | 70%+ | Optimization challenge |
| 4. Two-Layer Stack | 2000-3000 | 65%+ | Stability learning |
| 5. Volume Optimization | 3000-5000 | 60%+ | Complex tradeoffs |
| 6. Mixed Box Sizes | 5000-10000 | 55%+ | Generalization |

## Next Steps

1. ✓ Read this curriculum design
2. Create `BoxPlacementBody.cs` (your agent's embodiment)
3. Migrate `CornerPlacementTask` to new architecture
4. Create `EdgePlacementTask.cs` (Task 2)
5. Setup scene with `ProcessAgent` + `TaskManager`
6. Record demos for Task 1
7. Start training and observe curriculum progression!

---

*This curriculum takes agent from "place box anywhere" to "expert packer" through 7 progressive tasks*
