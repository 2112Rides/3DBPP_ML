# Unity Setup - REQUIRED Components

## ⚠️ CRITICAL: Decision Requester Component

**YOU MUST ADD THIS OR THE AGENT WON'T WORK!**

### What Happened:
When you pressed Play, nothing happened except the grid visualization appeared. This is because the **Decision Requester component is missing**.

### Why It's Needed:
- The Decision Requester tells the agent **when to make decisions**
- Without it, the agent never receives observations or chooses actions
- It acts like a "clock" that triggers the agent at regular intervals

### How to Add It:

1. **Select your Agent GameObject** in Unity Hierarchy (the one with BoxPackingAgent component)

2. **Add Component** → Search for "Decision Requester"

3. **Configure Settings:**
   ```
   Decision Period: 5
   Take Actions Between Decisions: ✓ (checked)
   ```

   - **Decision Period = 5** means the agent makes a decision every 5 FixedUpdate steps
   - Lower = faster decisions but more compute
   - Higher = slower but more deliberate

4. **Verify Setup:**
   - Your agent should now have these components:
     - BoxPackingAgent
     - **Decision Requester** ← NEW!
     - Behavior Parameters

## Complete Agent GameObject Setup Checklist

Your agent GameObject should have these components:

### ✅ Required Components:

1. **BoxPackingAgent** (your custom script)
   - All references filled in (PalletManager, BoxSpawner, etc.)

2. **Decision Requester** ⚠️ MUST HAVE!
   - Decision Period: 5
   - Take Actions Between Decisions: ✓

3. **Behavior Parameters**
   - Behavior Name: "BoxPacker"
   - Vector Observation Space Size: 137 (or your total)
   - Actions: Discrete, Branch 0 Size = 400 (or gridResolution²×4)
   - Behavior Type: Default
   - Team ID: 0
   - Use Child Sensors: ✓

### 📦 Component References on BoxPackingAgent:

Make sure these are all assigned:
- Pallet Manager → (your PalletManager GameObject)
- Box Spawner → (your BoxSpawner GameObject)
- Placement Validator → (your PlacementValidator GameObject)
- Reward Calculator → (your RewardCalculator GameObject)
- Visualization Manager → (your VisualizationManager GameObject or null if not using)

## Using JSON Configuration System

Instead of editing 20+ Inspector fields across multiple components, use JSON configs!

### Quick Start:

1. **Choose a config file** from `Config/` folder:
   - `environment_config.json` - Recommended default (boxes 8-20 units)
   - `environment_config_small_boxes.json` - Easier learning (boxes 5-15 units)
   - `environment_config_current_problem.json` - DON'T USE (shows what was wrong)

2. **Add EnvironmentConfig component:**
   - Select your main environment GameObject
   - Add Component → "Environment Config"
   - Set Config File Path: `Config/environment_config.json`
   - Check "Load On Start"

3. **That's it!** Settings will load automatically when you press Play

### Manual Configuration (If you prefer Inspector):

If you don't want to use JSON configs, here are the critical settings:

#### BoxSpawner:
```
Min Box Size: (8, 8, 8)
Max Box Size: (20, 20, 20)  ← NOT 50!
```

#### BoxPackingAgent:
```
Max Boxes Per Episode: 15
Grid Resolution: 8  ← NOT 10 (better performance)
Step Penalty: -0.01
End On Invalid Placement: ✓
Max Steps: 100
Box Preview Count: 5
Include Height Map: ✓
Height Map Resolution: 8  ← NOT 10
```

#### RewardCalculator:
```
Success Reward: 1.5
Invalid Placement Penalty: -1.0
Volume Weight: 0.8
Shaping Complexity: 1.0
Use Reward Shaping: ✓
```

#### PalletManager:
```
Pallet Size: (100, 100, 100)
Max Weight: 1000
```

## Why Box Sizes Matter - The Math:

### Current Problem (boxes 10-50):
```
Pallet Volume: 100×100×100 = 1,000,000 cubic units
Large Box: 50×50×50 = 125,000 cubic units = 12.5% of pallet
Result: Only 3-5 boxes fit!
Mean Reward: +1.3 (terrible)
```

### With Recommended Sizes (boxes 8-20):
```
Pallet Volume: 1,000,000 cubic units
Medium Box: 20×20×20 = 8,000 cubic units = 0.8% of pallet
Result: 15-20 boxes fit!
Mean Reward: +25 to +40 (good!)
```

## Training Workflow

1. **Apply Settings** (JSON or manual)
2. **Verify Decision Requester is added**
3. **In Anaconda PowerShell:**
   ```powershell
   conda activate mlagents
   cd path/to/3DBPP_ML
   mlagents-learn BoxPacking_config_optimized.yaml --run-id=BoxPacking_v1
   ```
4. **Wait for**: `[INFO] Listening on port 5004...`
5. **Press Play in Unity**
6. **Watch training**: Should see 10-15 boxes being placed

## Troubleshooting

### Problem: Agent doesn't move when I press Play
**Solution**: Add Decision Requester component!

### Problem: Only 2-5 boxes spawn
**Solution**: Boxes are too large. Use JSON config or reduce max box size to 20

### Problem: Mean reward is negative or very low (+1 to +5)
**Solution**: Same as above - boxes too large

### Problem: Training is very slow (< 100 steps/sec)
**Solutions**:
- Reduce Grid Resolution to 8 or 6
- Reduce Height Map Resolution to 5
- Set Visualize Actions to false
- Build Unity project instead of using Editor

### Problem: Unity crashes after 30-60 minutes
**Solutions**:
- Apply performance fixes (already done in code)
- Reduce grid resolution
- Build Unity executable
- Enable threaded: true in config.yaml

## Expected Good Training Results

With proper settings (boxes 8-20, decision requester added):

| Metric | Value |
|--------|-------|
| Boxes Packed | 10-15 per episode |
| Mean Reward | +20 to +40 |
| Training Speed | 100-200 steps/sec |
| Pallet Utilization | 60-80% |
| Episode Success | 60-80% |

## Files Reference

- **JSON Configs**: `Config/environment_config*.json`
- **Config Loader**: `Assets/Scripts/BoxPacking/EnvironmentConfig.cs`
- **Training Config**: `BoxPacking_config_optimized.yaml`
- **This Guide**: `UNITY_SETUP_REQUIRED.md`

## Next Steps

1. ✅ Add Decision Requester component
2. ✅ Choose and apply a JSON config
3. ✅ Verify all component references
4. ✅ Start training
5. ✅ Monitor rewards - should see +20 to +40 after 100k steps

---

**After fixing these issues, your agent should successfully learn to pack 10-15 boxes per episode with good utilization!**
