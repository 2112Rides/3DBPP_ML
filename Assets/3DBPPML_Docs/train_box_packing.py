#!/usr/bin/env python3
"""
Training Script for 3D Box Packing ML-Agents Environment

This script provides a convenient way to start training with different configurations.

Usage:
    # Basic training
    python train_box_packing.py --mode basic
    
    # Training with curriculum learning
    python train_box_packing.py --mode curriculum
    
    # Training with imitation learning
    python train_box_packing.py --mode imitation
    
    # Resume training
    python train_box_packing.py --mode basic --resume --run-id MyPreviousRun
"""

import argparse
import subprocess
import sys
from pathlib import Path


class BoxPackingTrainer:
    """Wrapper for ML-Agents training with 3D Box Packing environment"""
    
    def __init__(self):
        self.project_root = Path(__file__).parent
        self.config_dir = self.project_root / "config"
        self.results_dir = self.project_root / "results"
        self.demos_dir = self.project_root / "demos"
        
        # Ensure directories exist
        self.config_dir.mkdir(exist_ok=True)
        self.results_dir.mkdir(exist_ok=True)
        self.demos_dir.mkdir(exist_ok=True)
    
    def train_basic(self, run_id="BoxPacking_Basic", resume=False, force=False, 
                   time_scale=1.0, num_envs=1):
        """Train with basic PPO configuration"""
        
        config_path = self.config_dir / "BoxPacking_config.yaml"
        
        if not config_path.exists():
            print(f"Error: Configuration file not found: {config_path}")
            print("Make sure BoxPacking_config.yaml is in the config/ directory")
            return False
        
        cmd = [
            "mlagents-learn",
            str(config_path),
            "--run-id", run_id,
            "--num-envs", str(num_envs),
            "--time-scale", str(time_scale)
        ]
        
        if resume:
            cmd.append("--resume")
        if force:
            cmd.append("--force")
        
        print(f"Starting basic training with run ID: {run_id}")
        print(f"Command: {' '.join(cmd)}")
        print("-" * 80)
        
        return self._run_command(cmd)
    
    def train_curriculum(self, run_id="BoxPacking_Curriculum", resume=False, 
                        force=False, time_scale=1.0, num_envs=1):
        """Train with curriculum learning"""
        
        config_path = self.config_dir / "BoxPacking_config.yaml"
        curriculum_path = self.config_dir / "BoxPacking_curriculum.yaml"
        
        if not config_path.exists():
            print(f"Error: Configuration file not found: {config_path}")
            return False
        
        if not curriculum_path.exists():
            print(f"Error: Curriculum file not found: {curriculum_path}")
            return False
        
        cmd = [
            "mlagents-learn",
            str(config_path),
            "--curriculum", str(curriculum_path),
            "--run-id", run_id,
            "--num-envs", str(num_envs),
            "--time-scale", str(time_scale)
        ]
        
        if resume:
            cmd.append("--resume")
        if force:
            cmd.append("--force")
        
        print(f"Starting curriculum training with run ID: {run_id}")
        print(f"Command: {' '.join(cmd)}")
        print("-" * 80)
        
        return self._run_command(cmd)
    
    def train_imitation(self, run_id="BoxPacking_Imitation", resume=False, 
                       force=False, time_scale=1.0, num_envs=1):
        """Train with imitation learning (BC + GAIL)"""
        
        config_path = self.config_dir / "BoxPacking_imitation.yaml"
        demo_path = self.demos_dir / "BoxPacking_expert.demo"
        
        if not config_path.exists():
            print(f"Error: Configuration file not found: {config_path}")
            return False
        
        if not demo_path.exists():
            print(f"Warning: Demonstration file not found: {demo_path}")
            print("Imitation learning requires demonstration data.")
            print("Please record demonstrations first using Unity's Demonstration Recorder.")
            response = input("Continue anyway? (y/n): ")
            if response.lower() != 'y':
                return False
        
        cmd = [
            "mlagents-learn",
            str(config_path),
            "--run-id", run_id,
            "--num-envs", str(num_envs),
            "--time-scale", str(time_scale)
        ]
        
        if resume:
            cmd.append("--resume")
        if force:
            cmd.append("--force")
        
        print(f"Starting imitation learning with run ID: {run_id}")
        print(f"Command: {' '.join(cmd)}")
        print("-" * 80)
        
        return self._run_command(cmd)
    
    def _run_command(self, cmd):
        """Execute a command and handle output"""
        try:
            # Run command and stream output
            process = subprocess.Popen(
                cmd,
                stdout=subprocess.PIPE,
                stderr=subprocess.STDOUT,
                universal_newlines=True,
                bufsize=1
            )
            
            # Print output in real-time
            for line in process.stdout:
                print(line, end='')
            
            process.wait()
            
            if process.returncode == 0:
                print("\nTraining completed successfully!")
                return True
            else:
                print(f"\nTraining failed with return code: {process.returncode}")
                return False
                
        except KeyboardInterrupt:
            print("\n\nTraining interrupted by user")
            process.terminate()
            return False
        except Exception as e:
            print(f"\nError during training: {e}")
            return False
    
    def check_setup(self):
        """Check if ML-Agents is installed and configured properly"""
        
        print("Checking ML-Agents setup...")
        print("-" * 80)
        
        # Check if mlagents-learn is available
        try:
            result = subprocess.run(
                ["mlagents-learn", "--help"],
                capture_output=True,
                text=True,
                timeout=5
            )
            if result.returncode == 0:
                print("✓ ML-Agents is installed")
            else:
                print("✗ ML-Agents installation issue")
                return False
        except FileNotFoundError:
            print("✗ ML-Agents is not installed")
            print("\nInstall with: pip install mlagents")
            return False
        except Exception as e:
            print(f"✗ Error checking ML-Agents: {e}")
            return False
        
        # Check configuration files
        configs = [
            ("Basic Config", self.config_dir / "BoxPacking_config.yaml"),
            ("Curriculum Config", self.config_dir / "BoxPacking_curriculum.yaml"),
            ("Imitation Config", self.config_dir / "BoxPacking_imitation.yaml")
        ]
        
        for name, path in configs:
            if path.exists():
                print(f"✓ {name} found: {path}")
            else:
                print(f"✗ {name} not found: {path}")
        
        # Check for demonstrations
        demo_path = self.demos_dir / "BoxPacking_expert.demo"
        if demo_path.exists():
            print(f"✓ Demonstration file found: {demo_path}")
        else:
            print(f"✗ Demonstration file not found: {demo_path}")
            print("  (Only needed for imitation learning)")
        
        print("-" * 80)
        print("Setup check complete!")
        return True


def main():
    parser = argparse.ArgumentParser(
        description="Train 3D Box Packing ML-Agents",
        formatter_class=argparse.RawDescriptionHelpFormatter,
        epilog="""
Examples:
  # Basic training
  python train_box_packing.py --mode basic --run-id MyFirstTry
  
  # Curriculum learning
  python train_box_packing.py --mode curriculum --num-envs 4
  
  # Imitation learning
  python train_box_packing.py --mode imitation --time-scale 20
  
  # Resume previous training
  python train_box_packing.py --mode basic --run-id MyFirstTry --resume
  
  # Check setup
  python train_box_packing.py --check
        """
    )
    
    parser.add_argument(
        "--mode",
        choices=["basic", "curriculum", "imitation"],
        default="basic",
        help="Training mode to use"
    )
    
    parser.add_argument(
        "--run-id",
        type=str,
        default=None,
        help="Unique identifier for this training run"
    )
    
    parser.add_argument(
        "--resume",
        action="store_true",
        help="Resume from previous training run"
    )
    
    parser.add_argument(
        "--force",
        action="store_true",
        help="Force overwrite existing run"
    )
    
    parser.add_argument(
        "--time-scale",
        type=float,
        default=1.0,
        help="Time scale for Unity simulation (higher = faster)"
    )
    
    parser.add_argument(
        "--num-envs",
        type=int,
        default=1,
        help="Number of parallel environments"
    )
    
    parser.add_argument(
        "--check",
        action="store_true",
        help="Check ML-Agents setup and exit"
    )
    
    args = parser.parse_args()
    
    trainer = BoxPackingTrainer()
    
    # Check setup if requested
    if args.check:
        trainer.check_setup()
        return
    
    # Generate default run ID if not provided
    if args.run_id is None:
        from datetime import datetime
        timestamp = datetime.now().strftime("%Y%m%d_%H%M%S")
        args.run_id = f"BoxPacking_{args.mode}_{timestamp}"
    
    # Run training based on mode
    if args.mode == "basic":
        success = trainer.train_basic(
            run_id=args.run_id,
            resume=args.resume,
            force=args.force,
            time_scale=args.time_scale,
            num_envs=args.num_envs
        )
    elif args.mode == "curriculum":
        success = trainer.train_curriculum(
            run_id=args.run_id,
            resume=args.resume,
            force=args.force,
            time_scale=args.time_scale,
            num_envs=args.num_envs
        )
    elif args.mode == "imitation":
        success = trainer.train_imitation(
            run_id=args.run_id,
            resume=args.resume,
            force=args.force,
            time_scale=args.time_scale,
            num_envs=args.num_envs
        )
    
    sys.exit(0 if success else 1)


if __name__ == "__main__":
    main()
