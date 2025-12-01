# Reward Scaling Recommendations for Action-Masked Training

## Current vs Recommended Reward Structure

### With Action Masking Enabled

Since the agent can no longer choose invalid placements, the reward structure shifts significantly:

| Component | Current Value | Recommended | Reason |
|-----------|--------------|-------------|---------|
| **Success Reward** | +1.0 | +1.5 | Stronger positive signal for valid placements |
| **Invalid Penalty** | -2.0 | -1.0 | Rarely used now; keep as safety net only |
| **Shaping Complexity** | 0.5 | 1.0 | Maximize reward shaping signals with masking |
| **Volume Weight** | 0.5 | 0.8 | Encourage packing larger boxes first |
| **Step Penalty** | -0.01 | -0.01 | Keep as is - encourages efficiency |
| **Completion Bonus** | +10.0 | +10.0 | Keep as is - strong completion incentive |

## Reward Component Analysis

### 1. Valid Placement Rewards (Per Box)

With current settings:
```
Base: +1.0
Volume: +0.0 to +0.5
Quality: +0.0 to +1.0 (support, flatness, etc.)
Strategic: +0.0 to +0.6 (corners, surfaces)
Stability: +0.0 to +0.3
Shaped multiplier: ×0.5 to ×1.0
────────────────────────────
Total: +1.0 to +2.5 per box
```

With recommended settings:
```
Base: +1.5
Volume: +0.0 to +0.8
Quality: +0.0 to +1.0
Strategic: +0.0 to +0.6
Stability: +0.0 to +0.3
Shaped multiplier: ×1.0
────────────────────────────
Total: +1.5 to +4.2 per box
```

### 2. Episode Rewards

For a successful episode packing 10 boxes in 50 steps:

**Current:**
```
10 boxes × ~2.0 avg = +20.0
Completion bonus    = +10.0
Efficiency (80%)    = +4.0
Speed bonus         = +1.5
Step penalties      = -0.5
────────────────────────────
Total              ≈ +35.0
```

**Recommended:**
```
10 boxes × ~3.0 avg = +30.0
Completion bonus    = +10.0
Efficiency (80%)    = +4.0
Speed bonus         = +1.5
Step penalties      = -0.5
────────────────────────────
Total              ≈ +45.0
```

### 3. Learning Signal Strength

| Metric | Current | Recommended | Impact |
|--------|---------|-------------|--------|
| Avg reward/box | +2.0 | +3.0 | +50% stronger per-action signal |
| Reward variance | Low | Medium | Better gradient signal |
| Completion ratio | 30:2 | 40:3 | Better balance |

## Implementation Changes

### Option 1: Unity Inspector (Quick - Recommended for Testing)

Adjust these values in the Unity Inspector on your RewardCalculator component:

1. **successReward**: 1.0 → **1.5**
2. **shapingComplexity**: 0.5 → **1.0**
3. **volumeWeight**: 0.5 → **0.8**
4. **invalidPlacementPenalty**: -2.0 → **-1.0**

### Option 2: Code Changes (Permanent - Recommended for Production)

Edit `RewardCalculator.cs` default values:

```csharp
[SerializeField] private float successReward = 1.5f;              // Was 1.0f
[SerializeField] private float invalidPlacementPenalty = -1.0f;   // Was -2.0f
[SerializeField] private float volumeWeight = 0.8f;               // Was 0.5f
[SerializeField] private float shapingComplexity = 1.0f;          // Was 0.5f
```

## Expected Training Improvements

### Before (Without Action Masking + Poor Rewards)
- Mean reward: -199 to -192
- Learning: Minimal
- Success rate: ~0%
- Invalid placements: 95%+

### After (With Action Masking + Current Rewards)
- Mean reward: +10 to +30
- Learning: Moderate
- Success rate: 30-50%
- Invalid placements: 0%

### After (With Action Masking + Optimized Rewards)
- Mean reward: +20 to +45
- Learning: **Fast**
- Success rate: 50-80%
- Invalid placements: 0%
- **Stronger reward signals = faster, more stable learning**

## Monitoring During Training

Watch these TensorBoard metrics:

1. **Environment/Cumulative Reward**
   - Should trend upward from 0 to +30-45 range
   - Variance should be moderate (std dev 5-15)

2. **Environment/Episode Length**
   - Should decrease as agent gets efficient
   - Target: 50-100 steps for 10 boxes

3. **Custom Metric: Boxes Packed**
   - Should increase from 1-2 to 8-10+ per episode

4. **Policy/Entropy**
   - Should start high (exploring) then decrease
   - Low entropy + high reward = learned policy

## Troubleshooting

### Reward too sparse (still not learning)
- Increase `successReward` to 2.0
- Increase `shapingComplexity` to 1.0
- Increase `volumeWeight` to 1.0

### Reward too dense (unstable learning)
- Reduce `shapingComplexity` to 0.7
- Reduce bonus weights (flatSurfaceBonus, etc.) by 50%

### Agent ignores quality metrics
- Increase quality weights (supportQualityWeight, stabilityWeight)
- Current values may be too small to influence policy

## Next Steps

1. **Start with Unity Inspector changes** (quick testing)
2. **Run training for 100k steps**
3. **Monitor TensorBoard** for improvement
4. **Adjust if needed** based on metrics
5. **Make code changes permanent** once satisfied
