# 3DBPP Corner Placement - Demo Recording

## Recent Fixes (Latest Session)

**Critical Issues Resolved:**
1. **Box placement mismatch** - Placed boxes now match cursor position/rotation/scale exactly
   - Fixed: PlacementAction expects corner position, not center position
   - DecodeAction() now converts cursor center → box corner correctly

2. **Corner detection failing** - Corners now correctly register as occupied
   - Fixed: EvaluatePlacement() now receives box center position (not corner)
   - CornerPlacementTask checks if box CENTER is in corner zone
   - Yellow corners turn green when boxes placed correctly

3. **Component assignment** - KeyboardController automatically finds IInputMapper
   - No manual assignment needed
   - Uses GetComponent pattern (standard Unity approach)

4. **Episode auto-completing** - Removed auto-triggering Decision Requester
   - KeyboardController manually requests decisions only on space bar press
   - Full control over placement timing

5. **Geometry issues** - Grid boundaries and cursor positioning fixed
   - Boxes constrained to pallet (no overhang)
   - Cursor properly aligned with corners

## Quick Setup (5 minutes)

### Step 1: Create Shared Components (One-Time Setup)

**Create separate GameObjects for components shared between agents:**

1. Create empty GameObject: `3DBPP_SharedComponents`
2. Create child GameObject: `PalletManager_Shared`
   - Add `PalletManager` component
   - Configure pallet size (100, 100, 100)
3. Create child GameObject: `BoxSpawner_Shared`
   - Add `BoxSpawner` component
4. Create child GameObject: `PlacementValidator_Shared`
   - Add `PlacementValidator` component

**These components can now be referenced by both your old BoxPackingAgent and new CornerPlacementAgent!**

### Step 2: Create Demo Recording GameObject

1. Create empty GameObject: `CornerPlacementDemo`
2. Add these components (in this order):
   - `CornerPlacementAgent` (from Tasks/3DBPP/Agents/)
   - `CornerPlacementTask` (from Tasks/3DBPP/Curriculum/)
   - `BinPackingInputMapper` (from Tasks/3DBPP/Configs/)
   - `KeyboardController` (from LearningPipeline/Imitation/)
   - `DemonstrationRecorder` (from ML-Agents → Add Component → Demonstration Recorder)

**DO NOT add Decision Requester!** KeyboardController now manually requests decisions only when you press space bar.

### Step 3: Assign References

**On CornerPlacementAgent:**
- Pallet Manager → Drag the **PalletManager_Shared** GameObject (or its PalletManager component)
- Box Spawner → Drag the **BoxSpawner_Shared** GameObject (or its BoxSpawner component)
- Placement Validator → Drag the **PlacementValidator_Shared** GameObject (or its PlacementValidator component)
- Task → Drag the **CornerPlacementTask component** from CornerPlacementDemo
- Fixed Box Size → (20, 20, 20)
- Max Boxes → 4

**On KeyboardController:**
- **NO MANUAL ASSIGNMENT NEEDED!** KeyboardController now automatically finds the IInputMapper component on the same GameObject
- Show Input Hints → ✓ (checked)
- You should see console message: "[KeyboardController] Found IInputMapper: BinPackingInputMapper"

**On BinPackingInputMapper:**
- Pallet Size → (100, 100, 100)
- Box Size → (20, 20, 20)
- Grid Resolution → 8

**On DemonstrationRecorder:**
- Demonstration Name → "CornerPlacement"
- Demonstration Directory → "Assets/Tasks/3DBPP/Demonstrations"

### Step 4: Configure Behavior Parameters

**Behavior Parameters (on CornerPlacementAgent):**
- Behavior Name → "CornerPlacementAgent"
- **Behavior Type** → **Heuristic Only** ← CRITICAL for keyboard control!
- **Vector Observation Space Size → 8** ← MUST BE 8!
  - Box size (3) + Corners (4) + Progress (1) = 8 total
  - **IMPORTANT:** Setting this to any other value (like 11) will break training!
- Actions:
  - Discrete Branches: 1
  - Branch 0 Size: 256 (8×8 grid × 4 rotations)

**IMPORTANT:** If you see a Decision Requester component, **REMOVE IT** or set Decision Period to 999.
KeyboardController now manually calls RequestDecision() only when you press space bar. This prevents automatic box placement.

### Step 5: Press Play!

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

### On-Screen Display:

**While Recording (top-right):**
- Red "● RECORDING" indicator
- Actions: [count]
- Episodes: [count] ← **NEW: Track how many demos recorded!**

**When Not Recording (top-right, small yellow text):**
- Episodes Completed: [count] ← **Persists between recording sessions**

### Recording Workflow:

1. **Press D** to start recording
   - Red "● RECORDING" appears top-right
   - Action counter shows
   - Episode counter shows

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

### ❌ Two Behavior Parameters components / Agent conflicts
**PROBLEM:** You have multiple agents active in the scene (CornerPlacementAgent + old BoxPackingAgent)
**SYMPTOMS:** Boxes not placing, actions not responding, confusing console messages
**FIX:**
- Find the old **BoxPackingEnvironment** GameObject in your scene
- **Disable it** (uncheck the checkbox at top of Inspector)
- Only CornerPlacementDemo should be active for demo recording

### ❌ "CornerPlacementDemo does not implement IInputMapper!" error
**PROBLEM:** You assigned the GameObject instead of the component
**FIX:**
- In KeyboardController, Input Mapper Behaviour field:
- Delete current assignment
- Drag the **BinPackingInputMapper component** (not GameObject!)
- Should show "BinPackingInputMapper (Bin Packing Input Mapper)"

### ❌ Episode ends immediately / Boxes place automatically without space bar
**PROBLEM:** Decision Requester is auto-triggering OnActionReceived() every few frames
**SYMPTOMS:**
- Episode completes as soon as you press Play
- Corners go green when cursor enters them (not when you press space)
- All 4 boxes placed instantly
**FIX:**
- **REMOVE Decision Requester component** (or set Decision Period to 999)
- KeyboardController now manually calls RequestDecision() only when you press space bar
- This ensures boxes only place when you confirm the action

### ❌ Actions confirmed but boxes not placing
**PROBLEM:** Behavior Type is set to "Default" or "Inference Only"
**FIX:**
- On CornerPlacementAgent → Behavior Parameters
- Set **Behavior Type** → **Heuristic Only**
- This enables keyboard control

### ❌ Cannot assign BinPackingInputMapper to KeyboardController
**FIXED** - KeyboardController now uses GetComponent to automatically find IInputMapper on the same GameObject
- No manual assignment needed
- Just ensure BinPackingInputMapper is on the same GameObject as KeyboardController
- Console will show: "[KeyboardController] Found IInputMapper: BinPackingInputMapper"

### ❌ Yellow corners are outside pallet bounds
**FIXED** - corners now positioned inside pallet

### ❌ Cyan cursor floating in air
**FIXED** - cursor now at ground level

### ❌ Cyan cursor not centered in corner zone
**FIXED** - grid-to-world mapping now accounts for box size and aligns with corner positions

### ❌ Box overhangs pallet edges
**FIXED** - grid boundaries now constrain placements to prevent overhang
- Grid positions now map to valid box centers (10,10) to (90,90) for 20x20 boxes
- Each grid cell represents one box width

### ❌ Placed box doesn't match cursor position/rotation/scale
**FIXED** - CornerPlacementAgent.DecodeAction() now correctly converts cursor CENTER position to box CORNER position
- PalletManager expects PlacementAction.position to be the box corner (not center)
- Cursor draws at center for visualization
- DecodeAction now subtracts half box size to get corner position
- Placed box position, rotation, and scale now match cursor exactly

### ❌ Corners not registering as occupied when boxes placed
**FIXED** - OnActionReceived() now passes box CENTER position to task.EvaluatePlacement()
- CornerPlacementTask.GetCornerIndex() checks if box CENTER is in corner zone
- placement.position is corner, so we add half box size to get center
- Example: Corner (0,0,80) + half size (10,0,10) = Center (10,0,90) → Front-Left corner ✓
- Corners now correctly turn green when occupied

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
