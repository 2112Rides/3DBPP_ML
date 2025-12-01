# 3D Box Packing with Unity ML-Agents

A reinforcement learning system for learning optimal 3D box packing/palletization strategies using Unity ML-Agents.

## 📋 Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Requirements](#requirements)
- [Installation](#installation)
- [Quick Start](#quick-start)
- [Project Structure](#project-structure)
- [Training Modes](#training-modes)
- [Configuration](#configuration)
- [Monitoring Training](#monitoring-training)
- [Tips & Troubleshooting](#tips--troubleshooting)

## 🎯 Overview

This project implements a machine learning agent that learns to efficiently pack 3D boxes onto pallets. The agent uses reinforcement learning (PPO algorithm) and can be enhanced with curriculum learning and imitation learning techniques.

**Key Capabilities:**
- Learn packing strategies through trial and error
- Start with simple problems and progress to complex ones (curriculum learning)
- Learn from expert demonstrations (imitation learning)
- Handle mixed box sizes and shapes
- Optimize for packing efficiency and stability

## ✨ Features

### Core Features
- **PPO-based Learning**: State-of-the-art reinforcement learning algorithm
- **Flexible Observation Space**: Height maps, box properties, and spatial context
- **Smart Action Space**: Discretized placement positions with rotations
- **Rich Reward Shaping**: Volume efficiency, stability, surface quality, and more

### Advanced Features
- **Curriculum Learning**: Gradually increase difficulty as agent improves
- **Imitation Learning**: Learn from human or heuristic demonstrations
- **Behavior Cloning**: Pre-train on expert demonstrations
- **GAIL**: Generative adversarial imitation learning

### Visualization
- Real-time packing visualization
- Height map display
- Placement highlighting
- Training statistics overlay

## 📦 Requirements

### Unity Side
- Unity 2020.3 LTS or later
- ML-Agents Unity Package (Release 23 or later)

### Python Side
- Python 3.8 or later
- mlagents 1.1.0 or later
- PyTorch 1.8.0 or later
- NumPy
- TensorBoard (for monitoring)

## 🚀 Installation

### Step 1: Install Python Dependencies

```bash
# Create virtual environment (recommended)
python -m venv venv
source venv/bin/activate  # On Windows: venv\Scripts\activate

# Install ML-Agents
pip install mlagents

# Verify installation
mlagents-learn --help
```

### Step 2: Set Up Unity Project

1. Create new Unity project or use existing one
2. Install ML-Agents Unity Package:
   - Window → Package Manager
   - Add package from git URL: `com.unity.ml-agents`
   - Version: 4.0.0 or later

3. Copy C# scripts to your Unity project:
   ```
   Assets/
   └── Scripts/
       └── BoxPacking/
           ├── BoxPackingAgent.cs
           ├── PalletManager.cs
           ├── BoxSpawner.cs
           ├── PlacementValidator.cs
           ├── RewardCalculator.cs
           ├── VisualizationManager.cs
           └── DataClasses.cs
   ```

4. Create the environment:
   - Create empty GameObject named "BoxPackingEnvironment"
   - Add all component scripts
   - Configure in Inspector

5. Build the executable:
   - File → Build Settings
   - Add your scene
   - Build executable (for training)

### Step 3: Set Up Python Training Environment

```bash
# Create project structure
mkdir ml-agents-training
cd ml-agents-training
mkdir config demos results

# Copy configuration files
cp BoxPacking_config.yaml config/
cp BoxPacking_curriculum.yaml config/
cp BoxPacking_imitation.yaml config/

# Copy training script
cp train_box_packing.py .
chmod +x train_box_packing.py
```

## 🎮 Quick Start

### 1. Test in Unity (Manual Control)

Before training, test that everything works:

1. Open Unity project
2. Set agent Behavior Type to "Heuristic Only"
3. Press Play
4. Use manual controls to place boxes
5. Verify rewards and observations are working

### 2. Basic Training

Start with basic PPO training:

```bash
python train_box_packing.py --mode basic --run-id FirstTrain
```

Or use mlagents-learn directly:

```bash
mlagents-learn config/BoxPacking_config.yaml --run-id FirstTrain
```

When prompted, press Play in Unity Editor.

### 3. Monitor Training

Open TensorBoard to watch training progress:

```bash
tensorboard --logdir results
```

Then open http://localhost:6006 in your browser.

### 4. Test Trained Agent

1. In Unity, set agent Behavior Type to "Inference Only"
2. Load your trained model (.onnx file from results/)
3. Press Play to see agent in action

## 📁 Project Structure

```
project/
├── Unity/
│   └── Assets/
│       └── Scripts/
│           └── BoxPacking/
│               ├── BoxPackingAgent.cs          # Main agent
│               ├── PalletManager.cs            # Pallet state management
│               ├── BoxSpawner.cs               # Box generation
│               ├── PlacementValidator.cs       # Validation logic
│               ├── RewardCalculator.cs         # Reward calculation
│               ├── VisualizationManager.cs     # Visualization
│               └── DataClasses.cs              # Box, PlacementAction
│
└── ml-agents-training/
    ├── config/
    │   ├── BoxPacking_config.yaml          # Basic training config
    │   ├── BoxPacking_curriculum.yaml      # Curriculum config
    │   └── BoxPacking_imitation.yaml       # Imitation config
    ├── demos/
    │   └── BoxPacking_expert.demo          # Expert demonstrations
    ├── results/
    │   └── [training runs]/
    ├── train_box_packing.py                # Training script
    └── README.md                           # This file
```

## 🎓 Training Modes

### 1. Basic PPO Training

**When to use**: Starting point, no demonstrations available

```bash
python train_box_packing.py --mode basic --run-id Basic_v1
```

**Expected results**:
- Training time: 2-4 hours (depends on hardware)
- Success rate: 60-80% after 1M steps
- Packing efficiency: 70-85%

### 2. Curriculum Learning

**When to use**: Agent struggles with full problem complexity

```bash
python train_box_packing.py --mode curriculum --run-id Curriculum_v1
```

**How it works**:
- Starts with 3 simple boxes
- Gradually increases to 20 complex boxes
- Advances based on performance thresholds

**Expected results**:
- Training time: 3-6 hours
- Success rate: 70-90%
- Packing efficiency: 75-90%
- Better generalization

### 3. Imitation Learning

**When to use**: You have expert demonstrations or heuristic baseline

#### Step 3a: Collect Demonstrations

**Option A: Manual Demonstrations**

1. In Unity, add `Demonstration Recorder` component to agent
2. Set demonstration name: "BoxPacking_expert"
3. Set directory: "demos"
4. Check "Record" checkbox
5. Play and manually pack 50-100 episodes
6. Copy .demo file to Python project

**Option B: Heuristic Demonstrations**

1. Implement rule-based packing in `Heuristic()` method
2. Follow steps above to record
3. Can generate thousands of demos quickly

**Example Heuristic** (First-Fit Decreasing):
```csharp
public override void Heuristic(in ActionBuffers actionsOut)
{
    // Simple rule: place box at lowest available position
    int bestAction = 0;
    float lowestHeight = float.MaxValue;
    
    for (int i = 0; i < numPossibleActions; i++)
    {
        PlacementAction placement = DecodeAction(i);
        if (IsValidPlacement(placement))
        {
            if (placement.position.y < lowestHeight)
            {
                lowestHeight = placement.position.y;
                bestAction = i;
            }
        }
    }
    
    actionsOut.DiscreteActions[0] = bestAction;
}
```

#### Step 3b: Train with Imitation

```bash
python train_box_packing.py --mode imitation --run-id Imitation_v1
```

**Expected results**:
- Faster initial learning
- Higher initial success rate (70-80%)
- Can surpass demonstrations with enough training

## ⚙️ Configuration

### Hyperparameter Tuning

Key hyperparameters in `BoxPacking_config.yaml`:

```yaml
hyperparameters:
  learning_rate: 3.0e-4      # Higher = faster but less stable
  batch_size: 2048           # Larger = more stable, slower
  buffer_size: 20480         # 10x batch_size recommended
  beta: 5.0e-3               # Exploration (higher = more exploration)
  epsilon: 0.2               # PPO clip (0.1-0.3 typical)
```

### Reward Tuning

Adjust reward weights in `RewardCalculator.cs`:

```csharp
[SerializeField] private float volumeWeight = 0.5f;
[SerializeField] private float stabilityWeight = 0.3f;
[SerializeField] private float flatSurfaceBonus = 0.5f;
```

**Tips**:
- Start with simple rewards (volume only)
- Add complexity gradually
- Use TensorBoard to monitor reward components
- Balance short-term vs long-term rewards

### Observation Space

Current observations (~137 values with height map):
- Pallet state: 7 values
- Current box: 7 values
- Next boxes preview: 20 values
- Episode context: 3 values
- Height map: 100 values (10×10 grid)

**To reduce observation space**:
- Disable height map: Set `includeHeightMap = false`
- Reduce preview count: Lower `boxPreviewCount`

**To add observations**:
- Box properties (fragility, stacking limits)
- Center of mass calculations
- Weight distribution
- Historical success rate

## 📊 Monitoring Training

### TensorBoard Metrics

**Key metrics to watch**:

1. **Environment/Cumulative Reward**
   - Should increase over time
   - Plateaus indicate convergence or learning difficulties

2. **Environment/Episode Length**
   - Should decrease as agent learns efficiency
   - Long episodes = agent taking unnecessary actions

3. **Policy/Learning Rate**
   - Should decay over time (if using linear schedule)
   - Can adjust schedule if needed

4. **Losses/Policy Loss**
   - Should be relatively stable
   - Large spikes indicate instability

5. **Policy/Entropy**
   - Measures exploration
   - Should decrease as agent becomes more confident

### Success Criteria

**Minimum viable performance**:
- ✓ 50% success rate (all boxes packed)
- ✓ 60% average packing efficiency
- ✓ Stable policy (low variance in rewards)

**Good performance**:
- ✓ 80% success rate
- ✓ 75% average packing efficiency
- ✓ Robust to different box configurations

**Excellent performance**:
- ✓ 95% success rate
- ✓ 85%+ average packing efficiency
- ✓ Generalizes to unseen configurations
- ✓ Surpasses heuristic baselines

## 💡 Tips & Troubleshooting

### Training Tips

1. **Start Small**
   - Begin with 3-5 boxes
   - Use similar-sized boxes
   - Gradually increase complexity

2. **Use Curriculum Learning**
   - Significantly improves sample efficiency
   - Better final performance
   - More robust policies

3. **Increase Training Speed**
   - Use `--time-scale 20` for faster simulation
   - Use `--num-envs 4` for parallel training
   - Build standalone executable (faster than Editor)

4. **Monitor Regularly**
   - Check TensorBoard every 100k steps
   - Watch for reward plateaus
   - Adjust hyperparameters if needed

5. **Save Checkpoints**
   - Training can take hours/days
   - Checkpoints saved every 500k steps
   - Keep last 5 checkpoints (configurable)

### Common Issues

#### Issue: Agent doesn't learn (reward stays flat)

**Solutions**:
- Simplify reward function
- Reduce problem complexity
- Increase learning rate
- Check for bugs in reward calculation
- Verify observations are correct

#### Issue: Training is unstable (reward oscillates)

**Solutions**:
- Decrease learning rate
- Increase batch size
- Reduce epsilon (PPO clip range)
- Add reward clipping

#### Issue: Agent learns slowly

**Solutions**:
- Use curriculum learning
- Provide demonstrations (imitation learning)
- Increase learning rate carefully
- Reduce observation space if too large
- Increase buffer size

#### Issue: Agent overfits to training scenarios

**Solutions**:
- Increase box variation in training
- Use multiple parallel environments
- Add randomization to pallet size
- Train for more steps

#### Issue: Agent gets stuck in local optimum

**Solutions**:
- Increase entropy coefficient (beta)
- Add curiosity-driven exploration
- Use epsilon-greedy exploration during training
- Restart training with different seed

### Performance Optimization

**Unity Side**:
- Build executable for training (10x faster than Editor)
- Disable unnecessary rendering
- Use simple shapes/materials
- Reduce physics simulation quality

**Training Side**:
- Use GPU for training (automatic with PyTorch)
- Increase `--num-envs` for parallel training
- Use `--time-scale` to speed up Unity simulation
- Train on dedicated machine

## 📚 Additional Resources

### ML-Agents Documentation
- [Official ML-Agents Documentation](https://github.com/Unity-Technologies/ml-agents/tree/main/docs)
- [Training Configuration](https://github.com/Unity-Technologies/ml-agents/blob/main/docs/Training-Configuration-File.md)
- [Curriculum Learning](https://github.com/Unity-Technologies/ml-agents/blob/main/docs/Training-Curriculum-Learning.md)
- [Imitation Learning](https://github.com/Unity-Technologies/ml-agents/blob/main/docs/Training-Imitation-Learning.md)

### Reinforcement Learning
- [OpenAI Spinning Up](https://spinningup.openai.com/)
- [PPO Paper](https://arxiv.org/abs/1707.06347)
- [GAIL Paper](https://arxiv.org/abs/1606.03476)

### 3D Bin Packing
- Classic algorithms: First-Fit, Best-Fit, Next-Fit
- Heuristics: Bottom-Left-Fill, Largest-First
- Research papers on RL for bin packing

## 🤝 Contributing

Contributions welcome! Areas for improvement:
- Advanced reward shaping
- More sophisticated heuristics
- Multi-pallet scenarios
- Different box constraints (fragility, orientation)
- Better visualization tools

## 📄 License

This project is provided as-is for educational and research purposes.

## 🙏 Acknowledgments

- Unity ML-Agents team for the excellent toolkit
- OpenAI for PPO algorithm
- Research community for RL advancements

---

**Happy Training! 🎉**

For questions or issues, please check the ML-Agents documentation or create an issue in the repository.
