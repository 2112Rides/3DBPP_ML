# PlacementAgent & PlacementTask - User Manual

## Overview

The **PlacementAgent** system provides a general-purpose ML-Agents framework for training agents to place boxes in configurable grid patterns. Unlike the specialized CornerPlacementAgent, this system supports arbitrary patterns (corners, center, edges, T-shape, L-shape, custom patterns) defined through an interactive visual grid editor.

## Components

### 1. PlacementAgent.cs
Main agent that controls box placement behavior.

**Location**: `Assets/Tasks/3DBPP/Agents/PlacementAgent.cs`

**Key Features**:
- 3 discrete action branches: Grid X, Grid Z, Rotation
- Auto-calculated box sizing to match grid cells
- Optional physics validation (disabled by default for grid-based tasks)
- Keyboard controls for heuristic demonstrations
- Proper episode reset handling

### 2. PlacementTask.cs
Task definition that manages target patterns and rewards.

**Location**: `Assets/Tasks/3DBPP/Curriculum/PlacementTask.cs`

**Key Features**:
- Configurable grid resolution (default: 8x8)
- Preset patterns: Corners, Center, Edges, T-Shape, L-Shape
- Custom pattern support via grid editor
- Save/load patterns as JSON files
- Real-time pattern evaluation with rewards

### 3. PlacementTaskEditor.cs
Custom Unity Inspector editor for visual pattern design.

**Location**: `Assets/Tasks/3DBPP/Curriculum/Editor/PlacementTaskEditor.cs`

**Key Features**:
- Interactive grid UI (click cells to toggle)
- Visual feedback (green = target, blue = occupied, gray = empty)
- Pattern save/load dialogs
- Real-time statistics display
- Grid orientation matches Unity 3D view

### 4. PatternData.cs
Serializable data class for pattern persistence.

**Location**: `Assets/Tasks/3DBPP/Curriculum/PatternData.cs`

## Setup Instructions

### Step 1: Create GameObject
1. Create new GameObject in scene: `PlacementAgent_GameObject`
2. Add component: `PlacementAgent`
3. Add component: `PlacementTask`
4. Add component: `Behavior Parameters` (ML-Agents)
5. Add component: `Demonstration Recorder` (ML-Agents)

### Step 2: Configure PlacementTask
1. Select the GameObject in hierarchy
2. In Inspector, find `PlacementTask` component
3. Set **Grid Resolution**: 8 (for 8x8 grid)
4. Set **Pallet Size**: Match your pallet dimensions (e.g., 100, 20, 100)
5. Choose **Preset Pattern** or design custom pattern:
   - Click cells in grid UI to toggle target cells
   - Green = target cell, Gray = empty
   - Grid orientation: Z=0 at bottom (back), Z increases upward (forward)

### Step 3: Configure PlacementAgent
1. In Inspector, find `PlacementAgent` component
2. Assign references:
   - **Pallet Manager**: Drag existing PalletManager from scene
   - **Box Spawner**: Drag existing BoxSpawner from scene
   - **Placement Validator**: Drag existing validator (optional)
   - **Task**: Should auto-populate with PlacementTask on same GameObject
3. Settings:
   - **Auto Calculate Box Size**: ✓ (recommended - matches grid cells)
   - **Box Height**: 20
   - **Max Boxes**: 10
   - **Grid Resolution**: 8 (must match PlacementTask)
   - **Enable Validation**: ☐ (unchecked for grid-based tasks)

### Step 4: Configure Behavior Parameters
1. In Inspector, find `Behavior Parameters` component
2. Set:
   - **Behavior Name**: `PlacementAgent`
   - **Vector Observation Space Size**: 69
     - Formula: 3 (box size) + (8×8) grid + 2 = 69
   - **Stacked Vectors**: 1
   - **Actions**:
     - **Continuous Actions**: 0
     - **Discrete Branches**: 3
   - **Branch 0 Size**: 8 (grid X positions)
   - **Branch 1 Size**: 8 (grid Z positions)
   - **Branch 2 Size**: 4 (rotations: 0°, 90°, 180°, 270°)
   - **Behavior Type**: Heuristic Only (for recording demos)

### Step 5: Configure Demonstration Recorder
1. In Inspector, find `Demonstration Recorder` component
2. Set:
   - **Record**: ☐ (uncheck initially)
   - **Num Steps To Record**: 500 (or desired length)
   - **Demonstration Directory**: `Assets/Demonstrations/`
   - **Demonstration Name**: `PlacementAgent_Demo`

## Controls (Heuristic Mode)

### Keyboard Controls
- **Arrow Keys**: Move grid cursor (X/Z position)
- **R**: Rotate box (cycles through 0°, 90°, 180°, 270°)
- **Space**: Place box (triggers ML-Agents action)

### Visual Feedback
- **Cyan wireframe**: Current cursor position (non-target cell)
- **Lime green wireframe**: Current cursor position (target cell)
- **Yellow boxes in Scene view**: Target cells (gizmo visualization)
- **Inspector grid colors**:
  - Green = target cell (not occupied)
  - Blue = target cell (occupied during play)
  - Gray = empty cell

## Recording Demonstrations

### Step 1: Prepare Scene
1. Set Behavior Type to **Heuristic Only**
2. Check **Record** in Demonstration Recorder
3. Press Play in Unity

### Step 2: Record Demonstrations
1. Use arrow keys to move cursor to target cells
2. Press Space to place boxes
3. Complete the pattern (all target cells)
4. Episode will auto-reset, continue recording more episodes
5. Press Stop when you have 5-10 successful episodes

### Step 3: Verify Recordings
- Check `Assets/Demonstrations/` folder
- File: `PlacementAgent_Demo.demo`
- Use ML-Agents Python API to inspect if needed

## Training the Agent

### Training Command

```bash
mlagents-learn config/placement_config.yaml --run-id=PlacementAgent_Run1
```

### Configuration File

Create `config/placement_config.yaml`:

```yaml
behaviors:
  PlacementAgent:
    trainer_type: ppo
    hyperparameters:
      batch_size: 128
      buffer_size: 2048
      learning_rate: 0.0003
      beta: 0.005
      epsilon: 0.2
      lambd: 0.95
      num_epoch: 3
      learning_rate_schedule: linear
    network_settings:
      normalize: false
      hidden_units: 256
      num_layers: 2
      vis_encode_type: simple
    reward_signals:
      extrinsic:
        gamma: 0.99
        strength: 1.0
    keep_checkpoints: 5
    max_steps: 500000
    time_horizon: 64
    summary_freq: 10000

    # Behavioral Cloning (use demonstrations)
    behavioral_cloning:
      demo_path: Assets/Demonstrations/PlacementAgent_Demo.demo
      strength: 0.5
      steps: 150000
```

### Training with Demonstrations (Recommended)

```bash
# With behavioral cloning from demonstrations
mlagents-learn config/placement_config.yaml --run-id=PlacementAgent_BC_Run1
```

### Training from Scratch (Alternative)

Remove the `behavioral_cloning` section from config and run:

```bash
mlagents-learn config/placement_config.yaml --run-id=PlacementAgent_Scratch_Run1
```

### Monitor Training

1. Open TensorBoard:
```bash
tensorboard --logdir results
```

2. Navigate to `http://localhost:6006`

3. Watch key metrics:
   - **Environment/Cumulative Reward**: Should increase over time
   - **Losses/Policy Loss**: Should decrease
   - **Policy/Entropy**: Should gradually decrease (exploration → exploitation)

### Using Trained Model

1. Training completes and saves model to `results/PlacementAgent_Run1/`
2. Copy `.onnx` file to `Assets/Models/`
3. In Unity:
   - Set Behavior Type to **Inference Only**
   - Drag .onnx file to **Model** field in Behavior Parameters
   - Press Play to watch trained agent perform

## Pattern Management

### Save Custom Pattern
1. Design pattern in inspector grid (click cells)
2. Click **Save Pattern** button
3. Enter pattern name and description
4. Pattern saved to `Assets/Tasks/3DBPP/Curriculum/Patterns/`

### Load Saved Pattern
1. Click **Load Pattern** button
2. Select pattern from popup menu
3. Grid updates with loaded pattern

### Pattern File Format
Patterns are saved as JSON:
```json
{
  "patternName": "My Custom Pattern",
  "gridResolution": 8,
  "cells": [false, false, true, ...],
  "description": "Custom pattern for testing"
}
```

## Reward System

### Rewards
- **+25**: Box placed on target cell (not previously occupied)
- **-1**: Invalid placement (when validation enabled)
- **0**: Box placed on non-target cell

### Success Criteria
Episode completes when:
- All target cells occupied (100% completion), OR
- Max boxes reached (default: 10)

### Performance Metrics
Available in logs and TensorBoard:
- `boxes_placed`: Total boxes placed in episode
- `target_cells_occupied`: Number of target cells filled
- `target_cells_total`: Total target cells in pattern
- Completion percentage: `(occupied / total) * 100%`

## Troubleshooting

### Issue: Spacebar not placing boxes
**Solution**: Check that:
- Behavior Parameters is configured correctly (3 branches: 8, 8, 4)
- Behavior Type is set to "Heuristic Only" or "Default"
- No errors in console

### Issue: Boxes not placing after first episode
**Solution**: This was fixed in latest version. Ensure you have:
- PlacementAgent.cs with `actionPending` and `spacePressed` reset in `ResetAgent()`
- PlacementTask.cs `ResetTask()` called in agent reset

### Issue: Box size doesn't match grid cells
**Solution**:
- Enable **Auto Calculate Box Size** in PlacementAgent
- Ensure **Grid Resolution** matches between PlacementAgent and PlacementTask
- Verify **Pallet Size** is set correctly

### Issue: Pattern appears flipped/inverted
**Solution**: Fixed in latest version. Grid now renders with Z=0 at bottom to match Unity 3D view.

### Issue: Training not improving
**Solutions**:
- Record more demonstrations (5-10 successful episodes)
- Increase `behavioral_cloning.strength` to 0.7-0.8
- Verify reward signals are working (check console logs)
- Reduce `max_steps` if agent is exploring too much
- Try different patterns (start simple: Corners or Center)

## Advanced Usage

### Multiple Grid Resolutions
To train on different grid sizes:
1. Create separate configs for each resolution
2. Adjust observation space size: 3 + (resolution²) + 2
3. Update Behavior Parameters discrete branch sizes

### Custom Reward Shaping
Edit `PlacementTask.cs` `EvaluatePlacement()` method:
```csharp
public float EvaluatePlacement(Vector3 position)
{
    int cellIndex = GetCellIndex(position);

    if (targetPattern[cellIndex] && !cellsOccupied[cellIndex]) {
        cellsOccupied[cellIndex] = true;
        targetCellsOccupied++;
        return TARGET_CELL_REWARD; // Modify reward here
    }

    // Add custom penalties or bonuses
    return 0f;
}
```

### Curriculum Learning
Train progressively on harder patterns:
1. Start with Corners (4 cells)
2. Move to Edges (24 cells for 8x8)
3. Finally complex custom patterns

## Architecture Details

### Action Space
- **Type**: Discrete (3 branches)
- **Branch 0**: Grid X position (0 to gridResolution-1)
- **Branch 1**: Grid Z position (0 to gridResolution-1)
- **Branch 2**: Rotation index (0=0°, 1=90°, 2=180°, 3=270°)
- **Total combinations**: 8 × 8 × 4 = 256 possible actions

### Observation Space
- **Box size** (3 values): Normalized current box dimensions
- **Grid state** (64 values for 8×8): Flattened grid, 1=target, 0=non-target
- **Progress** (2 values): Boxes placed, target cells occupied
- **Total**: 69 observations

### Decision Timing
- Uses **FixedUpdate()** for ML-Agents decision requests
- Synchronized with Unity physics timestep
- Compatible with DemonstrationRecorder
- Typical decision frequency: 50 Hz (every 0.02s)

## Files Modified/Created

### Created Files
- `Assets/Tasks/3DBPP/Agents/PlacementAgent.cs`
- `Assets/Tasks/3DBPP/Curriculum/PlacementTask.cs`
- `Assets/Tasks/3DBPP/Curriculum/Editor/PlacementTaskEditor.cs`
- `Assets/Tasks/3DBPP/Curriculum/PatternData.cs`
- `Assets/Tasks/3DBPP/README_PlacementAgent.md` (this file)

### Modified Files
- `Assets/LearningPipeline/Core/LearningAgent.cs` (added null check for episodeMetrics)

### Pattern Storage
- Default location: `Assets/Tasks/3DBPP/Curriculum/Patterns/`
- Format: JSON files (`.json`)
- Auto-populated in Load Pattern dropdown

## Version History

### v1.0 (Current)
- Initial implementation with grid-based placement
- Interactive visual pattern editor
- Pattern save/load system
- Auto-calculated box sizing
- Fixed coordinate system alignment
- Fixed episode reset bugs
- ML-Agents compliant decision timing

## Credits

Built on Unity ML-Agents framework for 3D Bin Packing Problem (3DBPP) research.
