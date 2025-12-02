# Training Experiments Log

Track all training runs here to compare results and identify what works best.

## Experiment Template

Copy this template for each new experiment:

```markdown
### Experiment [Number]: [Brief Description]
**Date**: YYYY-MM-DD
**Run ID**: [run-id from mlagents-learn]
**Config**: [which JSON config file]
**Duration**: [steps or time]

**Settings:**
- Box Sizes: [min] to [max]
- Grid Resolution: [value]
- Max Boxes: [value]
- Other key changes: [list]

**Results:**
- Mean Reward: [value]
- Boxes Packed: [average per episode]
- Training Speed: [steps/sec]
- Pallet Utilization: [%]
- Success Rate: [%]

**Observations:**
- [What worked well]
- [What didn't work]
- [Surprises or unexpected behavior]

**Next Steps:**
- [What to try next based on results]
```

---

## Completed Experiments

### Experiment 1: Original Configuration (PROBLEM)
**Date**: 2025-12-01
**Run ID**: Bin_01, Bin_02, BoxPacking_Fixed_v2
**Config**: Default Unity Inspector settings
**Duration**: 140k steps (crashed)

**Settings:**
- Box Sizes: 10-50 units (TOO LARGE)
- Grid Resolution: 10
- Max Boxes: 20
- No action masking initially

**Results:**
- Mean Reward: -192 (stuck, no learning)
- Boxes Packed: 0-1 per episode
- Training Speed: Unknown
- Issue: Agent couldn't learn due to constant invalid placements

**Observations:**
- Agent was penalized for every action
- No successful placements
- Training completely stuck

**Next Steps:**
- Add action masking

---

### Experiment 2: With Action Masking (IMPROVEMENT)
**Date**: 2025-12-01
**Run ID**: BoxPacking_Fixed_v2
**Config**: Same as Exp 1 + action masking
**Duration**: 140k steps (crashed at 45 min)

**Settings:**
- Box Sizes: 10-50 units (STILL TOO LARGE)
- Grid Resolution: 10
- Max Boxes: 20
- Action masking: ENABLED

**Results:**
- Mean Reward: -21 (87% improvement!)
- Boxes Packed: 2-5 per episode (still too few)
- Training Speed: 52 steps/sec (too slow)
- Pallet Utilization: 20-40%
- Issue: Unity timeout after 45 minutes

**Observations:**
- Action masking works! Huge improvement from -192 to -21
- But boxes still too large - only 2-5 fit on pallet
- Performance bottleneck: 800 validation checks per step
- Episodes end with "no valid placements" penalty

**Analysis:**
- 50×50×50 box = 125,000 cubic units = 12.5% of pallet
- After 3-5 large boxes, pallet 40-60% full
- No more boxes fit → -5 penalty
- This explains -21 reward: ~3 boxes × 3 reward = +9, minus penalties

**Next Steps:**
- Fix performance (cache validation results)
- Reduce box sizes to 8-20 range
- Decision Requester component missing!

---

### Experiment 3: Performance Fixes Only
**Date**: 2025-12-01
**Run ID**: BoxPacking_Fixed_v4
**Config**: Same as Exp 2 + performance caching
**Duration**: 20k steps

**Settings:**
- Box Sizes: 10-50 units (STILL NOT FIXED)
- Grid Resolution: 10
- Max Boxes: 20
- Action masking: ENABLED + CACHED
- Performance: Eliminated duplicate validation checks

**Results:**
- Mean Reward: +1.368 (POSITIVE!)
- Boxes Packed: 0.5-1 per episode (worse than before?)
- Training Speed: ~90 steps/sec (better, but not great)
- Pallet Utilization: ~10-15%

**Observations:**
- Reward is positive now, which is good
- But only packing 0.5-1 box per episode on average
- Confirms boxes are WAY too large
- Performance slightly better but still slow

**Next Steps:**
- MUST FIX BOX SIZES to 8-20 range
- Add Decision Requester component
- Use JSON config system for tracking

---

## Planned Experiments

### Experiment 4: Proper Configuration (NEXT)
**Config**: `environment_config.json` or `environment_config_small_boxes.json`
**Target**: Demonstrate successful packing learning

**Settings:**
- Box Sizes: 8-20 units (FIXED!)
- Grid Resolution: 8 (performance)
- Max Boxes: 15
- Height Map Resolution: 8
- Decision Requester: ADDED

**Expected Results:**
- Mean Reward: +20 to +40
- Boxes Packed: 10-15 per episode
- Training Speed: 100-150 steps/sec
- Pallet Utilization: 60-80%
- Success Rate: 60-80%

**If successful:**
- Continue training to 500k+ steps
- Monitor pallet utilization improvement
- Check if agent learns layering strategies

**If not successful:**
- Try environment_config_small_boxes.json (even smaller boxes)
- Reduce grid resolution to 6
- Check Unity Console for errors

---

### Future Experiments to Try

1. **Curriculum Learning**
   - Start with small similar boxes
   - Gradually increase size variation
   - Increase number of boxes over time

2. **Different Generation Strategies**
   - SimilarSizes: easier to learn patterns
   - Graduated: largest-first or smallest-first
   - Curriculum: adaptive difficulty

3. **Grid Resolution Optimization**
   - Test 6, 8, 10, 12 resolutions
   - Balance between precision and speed

4. **Reward Shaping Experiments**
   - Try different shaping complexity values
   - Test with/without various bonus components
   - Find optimal balance

5. **Unity Build vs Editor**
   - Compare training speed
   - Check if reduces crashes
   - Expected: 3-5x faster

---

## Best Practices

1. **Always document BEFORE training**:
   - What config you're using
   - What you're testing
   - What you expect to happen

2. **Save training outputs**:
   - Copy terminal output to markdown files
   - Take screenshots of Unity visualizations
   - Export TensorBoard data

3. **One change at a time**:
   - Change only 1-2 parameters per experiment
   - Makes it easier to identify what helped/hurt

4. **Track performance metrics**:
   - Mean reward (most important)
   - Training speed (steps/sec)
   - Boxes packed per episode
   - Pallet utilization percentage

5. **Use version control**:
   - Commit config changes
   - Tag successful experiments
   - Can always revert to working configs

---

## Notes

- All configs are in `Config/` folder
- Use JSON for easy comparison and tracking
- TensorBoard data in `results/[run-id]/`
- Unity project can be reset to clean state anytime
