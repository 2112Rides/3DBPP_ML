# 3D Bin Packing with ML-Agents - Quick Start Guide

This is a rapid-start guide to get your 3D box packing ML-Agents environment up and running.

## 📦 What You've Received

**Unity C# Scripts** (7 files):
- `BoxPackingAgent.cs` - Main ML-Agents agent
- `PalletManager.cs` - Manages pallet state and spatial queries
- `BoxSpawner.cs` - Generates box sequences
- `PlacementValidator.cs` - Validates placements
- `RewardCalculator.cs` - Calculates rewards
- `VisualizationManager.cs` - Handles visualization
- `DataClasses.cs` - Box and PlacementAction classes

**Python Training Configs** (3 files):
- `BoxPacking_config.yaml` - Basic PPO configuration
- `BoxPacking_curriculum.yaml` - Curriculum learning setup
- `BoxPacking_imitation.yaml` - Imitation learning with BC/GAIL

**Python Scripts** (1 file):
- `train_box_packing.py` - Convenient training script

**Documentation** (2 files):
- `README.md` - Comprehensive documentation
- `3DBPP_MLAgents_Design.md` - Detailed design document

## 🚀 Setup in 5 Minutes

### Step 1: Unity Setup (2 minutes)

1. Create a new Unity scene
2. Create empty GameObject: "BoxPackingEnvironment"
3. Copy all `.cs` files to: `Assets/Scripts/BoxPacking/`
4. Add these components to "BoxPackingEnvironment":
   - PalletManager
   - BoxSpawner
   - PlacementValidator
   - RewardCalculator
   - VisualizationManager
   - BoxPackingAgent

5. In Inspector, connect references:
   - BoxPackingAgent → assign all the other components

6. Add ML-Agents Behavior Parameters component:
   - Behavior Name: "BoxPacker"
   - Vector Observation Space Size: 137 (or 37 if height map disabled)
   - Action Space: Discrete, Branch Size: 400 (10x10 grid × 4 rotations)

### Step 2: Python Setup (2 minutes)

```bash
# Install ML-Agents
pip install mlagents

# Create project structure
mkdir ml-agents-training
cd ml-agents-training
mkdir config demos results

# Copy files
# (Copy the .yaml and .py files to appropriate directories)
```

### Step 3: Test (1 minute)

1. In Unity, set Behavior Type to "Heuristic Only"
2. Press Play
3. Verify boxes spawn and agent attempts to place them

## 🎯 First Training Run

### Option 1: Simple Start

```bash
# In Unity Editor, press Play button and wait
# In terminal:
mlagents-learn config/BoxPacking_config.yaml --run-id FirstTest

# When prompted, press Play in Unity
```

### Option 2: With Training Script

```bash
python train_box_packing.py --mode basic --run-id FirstTest
```

### Option 3: Curriculum Learning (Recommended)

```bash
python train_box_packing.py --mode curriculum --run-id Curriculum_v1
```

## 📊 Monitor Progress

```bash
tensorboard --logdir results
# Open http://localhost:6006
```

## 🎓 Training Progression

**Week 1: Get it working**
- ✓ Basic environment running
- ✓ Agent learning simple cases (3-5 boxes)
- ✓ Reward increasing over time
- Target: 50% success rate

**Week 2: Improve performance**
- ✓ Curriculum learning implemented
- ✓ Agent handling 10-15 boxes
- ✓ Better reward shaping
- Target: 70% success rate, 70% efficiency

**Week 3: Advanced techniques**
- ✓ Collect demonstrations
- ✓ Imitation learning
- ✓ Fine-tune hyperparameters
- Target: 85% success rate, 80% efficiency

**Week 4: Optimization**
- ✓ Test different configurations
- ✓ Optimize for production
- ✓ Document best practices
- Target: 90%+ success rate, 85%+ efficiency

## 💡 Pro Tips

1. **Start Simple**: Begin with 3-5 similar-sized boxes
2. **Use Curriculum**: It's worth the setup time
3. **Monitor Often**: Check TensorBoard every hour
4. **Build Executable**: 10x faster than Unity Editor
5. **Parallel Training**: Use `--num-envs 4` for 4x speedup

## 🐛 Troubleshooting

**Agent not learning?**
- Check observations are normalized
- Verify reward is being calculated
- Start with simpler problem (fewer boxes)

**Training too slow?**
- Build standalone executable
- Use `--time-scale 20`
- Use `--num-envs` for parallel envs

**Weird behavior?**
- Check placement validation logic
- Verify coordinate systems match
- Add debug logging

## 📁 Next Steps

1. Read `README.md` for detailed documentation
2. Read `3DBPP_MLAgents_Design.md` for design rationale
3. Experiment with different configurations
4. Share your results!

## 🆘 Common First-Time Issues

### Issue: "Behavior BoxPacker not found"
**Fix**: Check Behavior Name in Unity matches config file

### Issue: "No observations received"
**Fix**: Verify CollectObservations is implemented correctly

### Issue: "Action space mismatch"
**Fix**: Ensure Discrete action branch size matches encoded actions

### Issue: "Training starts but no learning"
**Fix**: Check reward function is providing positive/negative feedback

## 📚 Key Files to Understand

**Must Read First:**
1. `README.md` - Overall documentation
2. `BoxPackingAgent.cs` - Core agent logic
3. `BoxPacking_config.yaml` - Training parameters

**Read Next:**
4. `RewardCalculator.cs` - Understand reward structure
5. `3DBPP_MLAgents_Design.md` - Deep dive into design

## ✅ Success Checklist

- [ ] Unity project set up with all scripts
- [ ] ML-Agents Python package installed
- [ ] First training run started
- [ ] TensorBoard showing metrics
- [ ] Agent learning (reward increasing)
- [ ] Checkpoints being saved
- [ ] Trained agent tested in Unity

## 🎉 You're Ready!

You now have everything you need to train a 3D box packing agent. Start with the basic configuration, monitor your progress, and gradually add complexity.

Good luck! 🚀

---

**Need Help?**
- Check ML-Agents documentation: https://github.com/Unity-Technologies/ml-agents
- Review the detailed README.md
- Debug with Unity's Console and Python's output

**Having Success?**
- Document your hyperparameters
- Share your best configurations
- Consider contributing improvements!
