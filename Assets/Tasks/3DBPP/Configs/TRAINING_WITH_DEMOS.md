# Training with Behavioral Cloning

## You've Recorded Demos! Now Let's Train 🎉

Your demonstration file (`CornerPlacement.demo`, 11kb) contains your expert demonstrations of corner placement strategy. Now we'll train an agent to learn from them.

---

## Step 1: Prepare Unity Scene for Training

**Switch from Demo Recording to Training Mode:**

### On CornerPlacementDemo GameObject:

1. **Change Behavior Type:**
   - Behavior Parameters → Behavior Type → **Default** (was "Heuristic Only")
   - This allows the agent to receive actions from the trainer

2. **Add Decision Requester (Required for Training!):**
   - Add Component → ML-Agents → Decision Requester
   - Decision Period: 5
   - Take Actions Between Decisions: ✓
   - NOTE: We removed this for demo recording, but it's REQUIRED for training

3. **Disable KeyboardController (Optional but Recommended):**
   - Uncheck the KeyboardController component
   - Prevents accidental keyboard interference during training

4. **Verify DemonstrationRecorder:**
   - You can disable this component during training (demos already recorded)

### Create Multiple Training Instances (Optional - Faster Training):

For faster training, duplicate CornerPlacementDemo:
1. Duplicate CornerPlacementDemo → Name it CornerPlacementDemo_2, _3, etc.
2. Spread them out spatially so they don't overlap
3. Each instance trains in parallel (10x agents = 10x faster!)

### Disable Old Agent:
- Make sure **BoxPackingEnvironment** is still disabled

---

## Step 2: Start Training

Open PowerShell in your project directory and run:

```powershell
cd "C:\Users\dexte\anaconda3\envs\FirstMLEnv\3DBPP_ML\3DBPP_ML"

conda activate mlagents

mlagents-learn Assets/Tasks/3DBPP/Configs/CornerPlacement_BC.yaml --run-id=CornerPlacement_BC_v1
```

**When prompted:** Press Play in Unity Editor

---

## Step 3: Monitor Training

### Watch TensorBoard:
```powershell
# In a new PowerShell window:
conda activate mlagents
cd "C:\Users\dexte\anaconda3\envs\FirstMLEnv\3DBPP_ML\3DBPP_ML"
tensorboard --logdir results
```

Open browser to: http://localhost:6006

### Key Metrics to Watch:

1. **Environment/Cumulative Reward**
   - Should quickly reach ~75-100 (25 per corner × 4 corners)
   - BC helps it learn faster than from scratch

2. **Losses/Behavioral Cloning Loss**
   - Should decrease rapidly in first 50k steps
   - Agent is learning to mimic your demonstrations

3. **Policy/Learning Rate**
   - Will decrease linearly from 3e-4 to 0
   - Standard for stable learning

4. **Environment/Episode Length**
   - Should stabilize around 20-40 steps
   - Time to place 4 boxes

---

## What's Happening During Training?

### Phase 1: Behavioral Cloning (Steps 0-50k)
- Agent watches your demos and learns to mimic them
- "Strength 0.5" means 50% demo imitation, 50% exploration
- Should quickly learn corner placement strategy

### Phase 2: PPO Refinement (Steps 50k-200k)
- Agent continues with pure reinforcement learning
- Refines strategy based on rewards
- May discover better placement patterns

---

## Expected Results:

**With Behavioral Cloning:**
- Mean reward ~80-100 by 20k steps (vs 100k+ without demos)
- Agent learns corner placement immediately
- Stable performance throughout training
- **5x faster convergence!**

**Without Behavioral Cloning:**
- Random exploration for first 50-100k steps
- Eventual discovery of corner strategy
- More erratic early performance

---

## Troubleshooting:

### ❌ "No demonstrations found at path" or "FileNotFoundError"
**FIX:**
- Check demo file exists at `Assets/Tasks/3DBPP/Demonstrations/CornerPlacement.demo`
- Verify YAML config has: `demo_path: Assets/Tasks/3DBPP/Demonstrations/CornerPlacement.demo`
- Path must start with `Assets/`, not `Tasks/`

### ❌ Vector Observation Space Size mismatch
**SYMPTOMS:** Negative rewards, agent not learning, demo loading fails
**FIX:**
- Behavior Parameters → Vector Observation Space Size → **Must be 8**
- NOT 11 or any other value!
- If wrong, you must re-record demos with correct value

### ❌ Agent not moving / stuck
**FIX:** Ensure Behavior Type = "Default" (not "Heuristic Only")

### ❌ "Decision Requester not found" warning
**FIX:** Add Decision Requester component back (required for training)

### ❌ Very low initial reward
**EXPECTED:** First few episodes may be random while agent loads demo patterns

### ❌ BC Loss not decreasing
**CHECK:**
- Demo file size > 0
- Behavior name matches: "CornerPlacementAgent"
- Demo was recorded with same agent

---

## After Training Completes:

Your trained model will be saved to:
```
results/CornerPlacement_BC_v1/CornerPlacementAgent.onnx
```

### To Use the Trained Model:

1. Select CornerPlacementDemo in Hierarchy
2. Behavior Parameters → Model → Drag the .onnx file
3. Behavior Type → Inference Only
4. Press Play - watch your agent perform corner placement autonomously!

---

## Next Steps:

After successful corner placement training:

1. **Record more demos** - 10-15 episodes gives even better results
2. **Lesson 2: Single Layer Fill** - Next curriculum task
3. **Compare with/without BC** - Train without demos to see the difference
4. **Scale up complexity** - Move to multi-box, multi-layer tasks

---

**You've successfully set up the first imitation learning pipeline!** 🚀

This is the foundation for teaching agents complex 3DBPP strategies through demonstration rather than random exploration.
