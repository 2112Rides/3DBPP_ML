# 3D Bin Packing Problem - ML-Agents Implementation Guide

## Overview
This document outlines the design and implementation of an ML-Agents reinforcement learning system for solving the 3D Bin Packing Problem (3DBPP), specifically focused on mixed box palletization.

## Table of Contents
1. [Problem Definition](#problem-definition)
2. [Environment Design](#environment-design)
3. [Agent Architecture](#agent-architecture)
4. [Implementation Phases](#implementation-phases)
5. [Code Structure](#code-structure)

---

## Problem Definition

### 3D Bin Packing Problem
- **Goal**: Pack a set of 3D boxes into one or more pallets/containers
- **Objective**: Maximize space utilization while respecting physical constraints
- **Constraints**:
  - No box overlap
  - Boxes must be fully supported (no floating boxes)
  - Stay within pallet boundaries
  - Optional: Weight distribution, stability, stacking rules

### Success Metrics
- **Packing efficiency**: Percentage of pallet volume utilized
- **Number of boxes packed**: How many boxes fit before failure
- **Stability score**: How stable is the configuration
- **Time to solution**: Steps taken to complete packing

---

## Environment Design

### 1. State Representation

The agent needs to observe:

#### Current Pallet State (3D Grid)
- **Occupancy grid**: 3D array showing filled/empty voxels
- **Height map**: 2D array showing maximum height at each XY position
- **Support map**: Shows which areas have adequate support

#### Current Box to Place
- Dimensions (length, width, height)
- Weight
- Fragility/stackability properties (if applicable)

#### Remaining Boxes Queue
- Preview of next N boxes (e.g., next 3-5 boxes)
- Statistics: total volume remaining, count, etc.

#### Placement Options
- Valid placement positions
- Orientation options (0°, 90°, 180°, 270°, and rotations)

### 2. Observation Space

**Option A: Grid-Based (for smaller pallets)**
```
Observation Space: Box(shape=(depth, height, width, channels))
Channels:
- Channel 0: Occupancy (0=empty, 1=occupied)
- Channel 1: Height values (normalized)
- Channel 2: Support values
- Channel 3: Current box mask (proposed placement)
```

**Option B: Vector-Based (more scalable)**
```
Observation Vector:
[
  # Pallet state (normalized)
  current_fill_percentage,      # 1 value
  available_volume,              # 1 value
  max_height_used,               # 1 value
  height_map_features,           # N values (statistical features)
  
  # Current box
  box_length / pallet_length,    # 3 values (normalized dimensions)
  box_width / pallet_width,
  box_height / pallet_height,
  box_weight / max_weight,       # 1 value
  
  # Next boxes preview
  next_box_1_dims,               # 3 values × N boxes
  next_box_2_dims,
  ...
  
  # Placement context
  num_valid_placements,          # 1 value
  average_gap_size,              # 1 value
  stability_score,               # 1 value
]
```

**Option C: Hybrid (Grid + Vector)**
- Use grid for spatial understanding
- Use vector for box properties and statistics
- ML-Agents supports multiple observation types

### 3. Action Space

**Discrete Action Space** (recommended for starting):
```
Action = (placement_position, orientation)

Where:
- placement_position: Index into valid placement positions list
- orientation: One of 6 possible orientations (3 axes × 2 rotations)

Total actions: num_valid_positions × 6 orientations
```

**For simplicity, we can use stratified discrete actions:**
```
Action Space: Discrete(n)
Where each action maps to:
- X position (discretized grid)
- Y position (discretized grid)
- Z position (automatically calculated or discretized)
- Rotation (0°, 90°, 180°, 270° around vertical axis)
- Flip (original orientation vs rotated 90° horizontally)
```

**Alternative: Multi-Discrete**
```
Action Space: MultiDiscrete([grid_x, grid_y, rotations, flips])
```

### 4. Reward Function

**Phase 1: Simple Reward**
```python
reward = 0

# Successful placement
if placement_valid:
    reward += box_volume / total_pallet_volume  # Volume utilization
    reward += 1.0  # Success bonus
    
    # Bonus for good placement
    if creates_flat_surface:
        reward += 0.5
    if good_stability:
        reward += 0.3
else:
    reward -= 1.0  # Invalid placement penalty

# Episode completion
if all_boxes_placed:
    reward += 10.0  # Completion bonus
    reward += packing_efficiency * 5.0  # Efficiency bonus
```

**Phase 2: Advanced Reward Shaping**
```python
reward = 0

# Volume efficiency
volume_reward = box_volume / remaining_volume * 0.5

# Height efficiency (prefer lower placements for stability)
height_penalty = -(placement_height / max_height) * 0.2

# Support quality
support_reward = support_area / box_base_area * 0.3

# Compactness (minimize gaps)
compactness_reward = -gap_volume / total_volume * 0.2

# Future placement potential
if placement_creates_good_surface:
    potential_reward = 0.4

# Combine
reward = volume_reward + height_penalty + support_reward + \
         compactness_reward + potential_reward

# Penalties
if invalid_placement:
    reward = -2.0
    
# Terminal rewards
if episode_complete:
    efficiency = used_volume / pallet_volume
    reward += efficiency * 10.0
```

---

## Agent Architecture

### Agent Type: Decision Requester Agent
- Agent requests decisions at each box placement
- Episode = packing all boxes from a batch
- Max steps = number of boxes (with margin)

### Neural Network Architecture

**Phase 1: Simple FC Network**
```
Input: Vector observation (50-100 features)
Hidden Layer 1: 256 units, ReLU
Hidden Layer 2: 256 units, ReLU
Hidden Layer 3: 128 units, ReLU
Output: Action logits + Value estimate
```

**Phase 2: Convolutional Network (if using grid observations)**
```
Input: 3D grid observation
Conv3D Layer 1: 32 filters, 3×3×3 kernel
Conv3D Layer 2: 64 filters, 3×3×3 kernel
Conv3D Layer 3: 64 filters, 3×3×3 kernel
Flatten
FC Layer 1: 256 units
FC Layer 2: 128 units
Output: Action logits + Value estimate
```

**Phase 3: Attention-Based (for variable box queues)**
```
Box encoder: Transformer encoder for next N boxes
Pallet encoder: CNN or graph network for pallet state
Fusion: Attention mechanism
Output: Policy + Value
```

### Training Algorithm

**Start with PPO (Proximal Policy Optimization)**
- Proven effective for discrete action spaces
- Sample efficient
- Stable training
- Default choice for ML-Agents

**Configuration:**
```yaml
behaviors:
  BoxPacker:
    trainer_type: ppo
    hyperparameters:
      batch_size: 1024
      buffer_size: 10240
      learning_rate: 3.0e-4
      beta: 5.0e-3
      epsilon: 0.2
      lambd: 0.95
      num_epoch: 3
      learning_rate_schedule: linear
    network_settings:
      normalize: true
      hidden_units: 256
      num_layers: 3
      vis_encode_type: simple  # or 'nature_cnn' for grid obs
    reward_signals:
      extrinsic:
        gamma: 0.99
        strength: 1.0
    max_steps: 5000000
    time_horizon: 64
    summary_freq: 10000
```

---

## Implementation Phases

### Phase 1: Basic Implementation (Start Here)

**Week 1-2: Environment Setup**
- [ ] Create Unity scene with pallet visualization
- [ ] Implement box spawning system
- [ ] Create 3D grid representation
- [ ] Implement basic placement validation
- [ ] Add visual feedback (colors for occupied/empty spaces)

**Week 2-3: Agent Integration**
- [ ] Create ML-Agents `Agent` class
- [ ] Implement observation collection
- [ ] Implement action space
- [ ] Implement simple reward function
- [ ] Test with random agent

**Week 3-4: Initial Training**
- [ ] Configure PPO trainer
- [ ] Start training with simple scenarios (few boxes)
- [ ] Monitor training metrics
- [ ] Debug and iterate

**Deliverable**: Agent that can pack 5-10 boxes with basic rules

### Phase 2: Curriculum Learning

**Curriculum Strategy:**

```yaml
# Training Curriculum Configuration
curriculum:
  - lesson: 0  # Easy
    criteria:
      measure: reward
      threshold: 5.0
      min_lesson_length: 100000
    parameters:
      num_boxes: [3, 5]
      box_size_variation: 0.2
      pallet_size: [100, 100, 100]
      
  - lesson: 1  # Medium
    criteria:
      measure: reward
      threshold: 8.0
      min_lesson_length: 150000
    parameters:
      num_boxes: [5, 10]
      box_size_variation: 0.4
      pallet_size: [100, 100, 150]
      
  - lesson: 2  # Hard
    criteria:
      measure: reward
      threshold: 12.0
      min_lesson_length: 200000
    parameters:
      num_boxes: [10, 20]
      box_size_variation: 0.6
      pallet_size: [100, 100, 200]
      
  - lesson: 3  # Very Hard
    parameters:
      num_boxes: [20, 50]
      box_size_variation: 1.0
      pallet_size: [120, 120, 250]
```

**Implementation:**
- Gradually increase problem complexity
- Start with few, similar-sized boxes
- Progress to many, varied-sized boxes
- Increase pallet size and constraints
- Add weight and stability requirements

### Phase 3: Imitation Learning & Behavior Cloning

**Step 1: Collect Demonstrations**

Option A: Human Demonstrations
- Create UI for manual box placement
- Record observation-action pairs
- Collect 50-100 successful episodes

Option B: Heuristic Expert
- Implement rule-based packing algorithm (e.g., First-Fit Decreasing)
- Generate demonstrations automatically
- Collect thousands of episodes

**Step 2: Behavior Cloning**

```yaml
behaviors:
  BoxPacker:
    trainer_type: ppo
    hyperparameters:
      # ... PPO settings ...
    behavioral_cloning:
      demo_path: demos/expert_packing.demo
      strength: 0.5  # Weight of BC loss
      steps: 150000  # Pretraining steps
      batch_size: 512
```

**Training Process:**
1. **Pretraining Phase**: Train on demonstrations only (BC)
2. **Fine-tuning Phase**: Continue with PPO + BC
3. **RL Phase**: Pure PPO after agent surpasses expert

**Step 3: GAIL (Generative Adversarial Imitation Learning)**

```yaml
reward_signals:
  extrinsic:
    strength: 0.5
  gail:
    strength: 1.0
    gamma: 0.99
    demo_path: demos/expert_packing.demo
    encoding_size: 128
```

---

## Code Structure

### Unity Project Structure
```
Assets/
├── ML-Agents/
│   ├── Scenes/
│   │   └── BoxPackingEnvironment.unity
│   ├── Scripts/
│   │   ├── BoxPackingAgent.cs          # Main agent script
│   │   ├── BoxPackingEnvironment.cs    # Environment controller
│   │   ├── PalletManager.cs            # Pallet state management
│   │   ├── BoxSpawner.cs               # Box generation
│   │   ├── PlacementValidator.cs       # Placement validation
│   │   ├── RewardCalculator.cs         # Reward calculation
│   │   └── VisualizationManager.cs     # Visual feedback
│   ├── Prefabs/
│   │   ├── Box.prefab
│   │   ├── Pallet.prefab
│   │   └── Agent.prefab
│   └── Materials/
│       ├── BoxMaterial.mat
│       ├── PalletMaterial.mat
│       └── HighlightMaterial.mat
```

### Python Training Structure
```
ml-agents-training/
├── config/
│   ├── box_packing_config.yaml         # PPO configuration
│   ├── curriculum.yaml                 # Curriculum learning config
│   └── imitation_config.yaml           # BC/GAIL configuration
├── demos/
│   └── expert_packing.demo             # Demonstration recordings
├── results/
│   └── [training run folders]
├── scripts/
│   ├── train.py                        # Training script
│   ├── evaluate.py                     # Evaluation script
│   └── visualize_results.py            # Visualization tools
└── requirements.txt
```

---

## Key Implementation Details

### BoxPackingAgent.cs - Core Structure

```csharp
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;
using System.Collections.Generic;

public class BoxPackingAgent : Agent
{
    [Header("Environment References")]
    public PalletManager palletManager;
    public BoxSpawner boxSpawner;
    public PlacementValidator placementValidator;
    public RewardCalculator rewardCalculator;
    
    [Header("Agent Settings")]
    public int maxBoxesToPack = 20;
    public float stepPenalty = -0.01f;
    
    private Box currentBox;
    private List<Box> remainingBoxes;
    private int boxesPackedThisEpisode = 0;
    
    // Episode initialization
    public override void OnEpisodeBegin()
    {
        // Reset pallet
        palletManager.Reset();
        
        // Generate new box set
        remainingBoxes = boxSpawner.GenerateBoxSet(maxBoxesToPack);
        boxesPackedThisEpisode = 0;
        
        // Get first box
        currentBox = GetNextBox();
    }
    
    // Collect observations
    public override void CollectObservations(VectorSensor sensor)
    {
        // Pallet state
        sensor.AddObservation(palletManager.GetFillPercentage());
        sensor.AddObservation(palletManager.GetAvailableVolume());
        sensor.AddObservation(palletManager.GetMaxHeight());
        
        // Current box (normalized)
        if (currentBox != null)
        {
            Vector3 normalizedSize = currentBox.size / palletManager.palletSize;
            sensor.AddObservation(normalizedSize);
            sensor.AddObservation(currentBox.weight / palletManager.maxWeight);
        }
        else
        {
            sensor.AddObservation(Vector3.zero);
            sensor.AddObservation(0f);
        }
        
        // Next boxes preview (up to 5)
        for (int i = 0; i < 5; i++)
        {
            if (i < remainingBoxes.Count)
            {
                Vector3 normalizedSize = remainingBoxes[i].size / palletManager.palletSize;
                sensor.AddObservation(normalizedSize);
            }
            else
            {
                sensor.AddObservation(Vector3.zero);
            }
        }
        
        // Context information
        sensor.AddObservation(remainingBoxes.Count);
        sensor.AddObservation(boxesPackedThisEpisode / (float)maxBoxesToPack);
    }
    
    // Execute actions
    public override void OnActionReceived(ActionBuffers actions)
    {
        if (currentBox == null)
        {
            EndEpisode();
            return;
        }
        
        // Decode action
        int actionIndex = actions.DiscreteActions[0];
        PlacementAction placement = DecodeAction(actionIndex);
        
        // Validate and place
        bool placementValid = placementValidator.ValidatePlacement(
            currentBox, placement, palletManager
        );
        
        if (placementValid)
        {
            // Place the box
            palletManager.PlaceBox(currentBox, placement);
            
            // Calculate reward
            float reward = rewardCalculator.CalculateReward(
                currentBox, placement, palletManager, true
            );
            AddReward(reward);
            
            boxesPackedThisEpisode++;
            
            // Check if done
            if (remainingBoxes.Count == 0)
            {
                // All boxes placed successfully!
                float completionBonus = 10.0f;
                float efficiencyBonus = palletManager.GetFillPercentage() * 5.0f;
                AddReward(completionBonus + efficiencyBonus);
                EndEpisode();
                return;
            }
            
            // Get next box
            currentBox = GetNextBox();
        }
        else
        {
            // Invalid placement
            float penalty = rewardCalculator.CalculateReward(
                currentBox, placement, palletManager, false
            );
            AddReward(penalty);
            
            // Option 1: End episode on invalid placement (harder)
            EndEpisode();
            
            // Option 2: Give another chance (easier, good for early training)
            // AddReward(-0.5f);
            // (continue to next step)
        }
        
        // Small penalty for each step (encourages efficiency)
        AddReward(stepPenalty);
    }
    
    // Heuristic for manual testing
    public override void Heuristic(in ActionBuffers actionsOut)
    {
        // Allow manual control during testing
        var discreteActions = actionsOut.DiscreteActions;
        
        // Use keyboard/mouse for manual placement
        // This is useful for generating demonstrations
        discreteActions[0] = GetManualAction();
    }
    
    // Helper methods
    private Box GetNextBox()
    {
        if (remainingBoxes.Count > 0)
        {
            Box box = remainingBoxes[0];
            remainingBoxes.RemoveAt(0);
            return box;
        }
        return null;
    }
    
    private PlacementAction DecodeAction(int actionIndex)
    {
        // Convert flat action index to placement parameters
        // This depends on your action space discretization
        
        int gridResolution = 10;  // 10x10 grid
        int numRotations = 4;     // 0°, 90°, 180°, 270°
        
        int rotationIndex = actionIndex / (gridResolution * gridResolution);
        int xyIndex = actionIndex % (gridResolution * gridResolution);
        
        int xIndex = xyIndex / gridResolution;
        int yIndex = xyIndex % gridResolution;
        
        Vector3 position = new Vector3(
            xIndex / (float)gridResolution * palletManager.palletSize.x,
            0, // Z calculated based on height map
            yIndex / (float)gridResolution * palletManager.palletSize.z
        );
        
        int rotation = rotationIndex * 90;
        
        return new PlacementAction(position, rotation);
    }
    
    private int GetManualAction()
    {
        // Implement manual control for testing/demonstrations
        return 0;
    }
}
```

### Training Configuration (box_packing_config.yaml)

```yaml
behaviors:
  BoxPacker:
    trainer_type: ppo
    
    hyperparameters:
      batch_size: 2048
      buffer_size: 20480
      learning_rate: 3.0e-4
      beta: 5.0e-3          # Entropy bonus
      epsilon: 0.2          # PPO clip range
      lambd: 0.95           # GAE lambda
      num_epoch: 3
      learning_rate_schedule: linear
      
    network_settings:
      normalize: true
      hidden_units: 256
      num_layers: 3
      vis_encode_type: simple
      
    reward_signals:
      extrinsic:
        gamma: 0.99
        strength: 1.0
        
    keep_checkpoints: 5
    max_steps: 10000000
    time_horizon: 64
    summary_freq: 10000
    
    checkpoint_interval: 500000
    threaded: false
```

---

## Next Steps

### Immediate Actions (Phase 1)

1. **Set up Unity project**
   - Install ML-Agents Unity package
   - Create basic scene

2. **Implement core classes**
   - `PalletManager`: Track pallet state
   - `BoxSpawner`: Generate box sequences
   - `PlacementValidator`: Check valid placements
   - `BoxPackingAgent`: ML-Agents agent

3. **Test with heuristic**
   - Implement `Heuristic()` method
   - Manually test placement logic

4. **Configure training**
   - Set up Python environment
   - Create training config
   - Start initial training run

### Success Criteria

**Phase 1 Success**: Agent learns to pack 5-10 simple boxes with >70% efficiency

**Phase 2 Success**: Agent handles 20+ boxes with curriculum learning, achieving >80% efficiency

**Phase 3 Success**: Agent learns from demonstrations and surpasses heuristic expert performance

---

## Tips & Best Practices

### Training Tips

1. **Start Simple**: Begin with small problem instances (3-5 boxes)
2. **Visual Debugging**: Use Unity's visualization to understand agent behavior
3. **Monitor Metrics**: Track packing efficiency, invalid placement rate, episode length
4. **Reward Shaping**: Start with simple rewards, gradually add complexity
5. **Hyperparameter Tuning**: Adjust learning rate, batch size based on training stability

### Common Pitfalls

1. **Sparse Rewards**: If agent rarely gets positive rewards, training will be slow
   - Solution: Add intermediate rewards for partial progress

2. **Action Space Too Large**: Too many possible actions makes learning difficult
   - Solution: Discretize actions, use hierarchical actions

3. **Observation Space Too Complex**: Agent can't learn from too much irrelevant information
   - Solution: Focus on essential features, normalize observations

4. **Curriculum Too Steep**: Jumping difficulty too quickly
   - Solution: Smooth progression, ensure >50% success before advancing

### Debugging Strategies

1. **Test with random agent**: Verify environment doesn't give rewards randomly
2. **Test with heuristic agent**: Verify good performance is achievable
3. **Check reward distribution**: Ensure positive and negative rewards are balanced
4. **Visualize training**: Use TensorBoard to monitor learning curves
5. **Manual play**: Use `Heuristic()` to test agent manually

---

## Resources

### ML-Agents Documentation
- [ML-Agents GitHub](https://github.com/Unity-Technologies/ml-agents)
- [ML-Agents Documentation](https://docs.unity3d.com/Packages/com.unity.ml-agents@latest)
- [Training Configuration](https://github.com/Unity-Technologies/ml-agents/blob/main/docs/Training-Configuration-File.md)
- [Imitation Learning](https://github.com/Unity-Technologies/ml-agents/blob/main/docs/Training-Imitation-Learning.md)
- [Curriculum Learning](https://github.com/Unity-Technologies/ml-agents/blob/main/docs/Training-Curriculum-Learning.md)

### Reinforcement Learning Resources
- [OpenAI Spinning Up](https://spinningup.openai.com/)
- [PPO Paper](https://arxiv.org/abs/1707.06347)
- [GAIL Paper](https://arxiv.org/abs/1606.03476)

### 3D Bin Packing Resources
- Classic algorithms: First-Fit Decreasing, Best-Fit Decreasing
- RL for BPP papers: Various academic papers on applying RL to packing problems

---

## Appendix: Alternative Approaches

### A. Continuous Action Space
- Instead of discrete placement positions
- Output continuous (x, y, z, rotation) values
- Pros: More flexible, can place anywhere
- Cons: Harder to learn, may produce invalid placements
- Algorithm: Use SAC (Soft Actor-Critic) instead of PPO

### B. Graph Neural Network
- Represent boxes and placements as graphs
- Use GNN to learn spatial relationships
- Pros: Better generalization to different problem sizes
- Cons: More complex implementation

### C. Hierarchical RL
- High-level policy: Choose which box to place next
- Low-level policy: Choose where to place selected box
- Pros: Decomposes problem, easier to learn
- Cons: More complex training procedure

### D. Multi-Agent System
- Multiple agents cooperate to pack boxes
- Each agent specializes in different strategies
- Pros: Can learn diverse strategies
- Cons: Complex communication and coordination

---

## Conclusion

This design provides a roadmap for implementing a 3D Bin Packing agent using Unity ML-Agents. Start with Phase 1 to get a working prototype, then expand to curriculum learning and imitation learning in later phases.

The key to success is:
1. **Start simple** and iterate
2. **Monitor training** closely
3. **Visualize** agent behavior
4. **Reward shape** carefully
5. **Use curriculum** to gradually increase difficulty

Good luck with your project! Feel free to adapt this design based on your specific requirements and constraints.
