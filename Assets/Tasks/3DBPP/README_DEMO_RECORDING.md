# 3DBPP Corner Placement - Demo Recording Tonight!

## Quick Setup (5 minutes)

### Step 1: Create GameObject in Unity

1. Create empty GameObject: `CornerPlacementDemo`
2. Add these components (in this order):
   - `CornerPlacementAgent` (from Tasks/3DBPP/Agents/)
   - `CornerPlacementTask` (from Tasks/3DBPP/Curriculum/)
   - `BinPackingInputMapper` (from Tasks/3DBPP/Configs/)
   - `KeyboardController` (from LearningPipeline/Imitation/)
   - `DemonstrationRecorder` (from ML-Agents → Add Component → Demonstration Recorder)

### Step 2: Assign References

**On CornerPlacementAgent:**
- Pallet Manager → (your existing PalletManager)
- Box Spawner → (your existing BoxSpawner)
- Placement Validator → (your existing PlacementValidator)
- Task → (the CornerPlacementTask on this GameObject)

**On KeyboardController:**
- Input Mapper Behaviour → (the BinPackingInputMapper on this GameObject)
- Show Input Hints → ✓ (checked)

**On DemonstrationRecorder:**
- Demonstration Name → "CornerPlacement"
- Demonstration Directory → "Assets/Tasks/3DBPP/Demonstrations"

### Step 3: Configure Demo Recorder

**Behavior Parameters (on CornerPlacementAgent):**
- Behavior Name → "CornerPlacementAgent"
- Vector Observation Space Size → 11
  - Box size (3) + Corners (4) + Progress (1) = 8 total
  - (May need adjustment - check console on Play)
- Actions:
  - Discrete Branches: 1
  - Branch 0 Size: 256 (8×8 grid × 4 rotations)

### Step 4: Press Play!

Press Play in Unity Editor

**You should see:**
- Console message: "[LearningAgent] Task set to: 3DBPP_L1_CornerPlacement"
- Console message: "Box 1/4 ready"
- Yellow corner zones in Scene view
- Cyan cursor at grid center

---

## Recording Your First Demo

### Controls:
- **Arrow Keys** → Move grid cursor
- **R** → Rotate box
- **SPACE** → Place box
- **D** → Toggle recording ON/OFF
- **ESC** → Cancel episode

### Recording Workflow:

1. **Press D** to start recording
   - Red "● RECORDING" appears top-right
   - Action counter shows

2. **Place 4 boxes in corners:**
   - Use arrows to move cursor to corner
   - Press SPACE to place
   - Yellow corner turns GREEN when occupied
   - Repeat for all 4 corners

3. **Episode ends automatically** when 4 corners filled
   - Demo saved to `Assets/Tasks/3DBPP/Demonstrations/CornerPlacement.demo`

4. **Press D** to stop recording

### Tips:
- Start with **back-left corner** (0, 0)
- Move to **back-right** (x=max, z=0)
- Then **front-left** (x=0, z=max)
- Finally **front-right** (x=max, z=max)
- Watch console for "Corner X occupied!" messages

---

## What You're Teaching the Agent

**Strategy:** Place boxes in corners first (fundamental 3DBPP principle)

**Why this matters:**
- Corners provide maximum support
- Creates stable base for future layers
- Standard bin packing heuristic
- Simple but effective baseline

**After 10-15 demos**, the agent will learn this strategy through behavioral cloning!

---

## Training with Your Demos (Tomorrow)

```yaml
# CornerPlacement_BC.yaml
behaviors:
  CornerPlacementAgent:
    trainer_type: ppo

    behavioral_cloning:
      demo_path: Tasks/3DBPP/Demonstrations/CornerPlacement.demo
      steps: 50000
      strength: 0.5
      samples_per_update: 512

    hyperparameters:
      learning_rate: 3.0e-4
      batch_size: 1024
      buffer_size: 10240

    max_steps: 200000
```

Train:
```powershell
mlagents-learn CornerPlacement_BC.yaml --run-id=CornerPlacement_BC_v1
```

**Expected results:**
- Agent learns corner placement in ~20k steps (vs 100k+ from scratch)
- Mean reward quickly reaches +80-100 (4 corners × 25 reward each)
- Visual behavior matches your demonstrations

---

## Troubleshooting

### "No current box" error
- Check BoxSpawner is assigned and initialized

### "Invalid placement" every time
- Check PlacementValidator is assigned
- Make sure pallet size matches (100×100×100)

### Recording not saving
- Verify demonstration directory exists
- Check DemonstrationRecorder component is active

### Cursor not visible
- Check Scene view (not Game view)
- Cyan wire cube should be visible

### Action space mismatch
- If you see errors about action size, adjust Vector Observation Space Size

---

## Next Steps (After Recording)

1. **Record 10-15 demo episodes** (20-30 minutes total)
2. **Verify demos** - Check file size > 0 in Demonstrations folder
3. **Configure training YAML** (template above)
4. **Launch training with BC**
5. **Compare to from-scratch training** (your existing BoxPackingAgent)
6. **Move to Lesson 2** - Single Layer Fill

---

**You're about to record your first RL demonstrations!** 🎥

This corner placement task is intentionally simple - perfect for validating the entire pipeline works before moving to complex tasks.

Good luck tonight! 🚀
