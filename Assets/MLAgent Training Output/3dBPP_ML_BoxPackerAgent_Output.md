Action Masking Output:
*************************************************
After Grid Size = 4 tests
*************************************************
(mlagents) PS C:\Users\dexte\anaconda3\envs\FirstMLEnv\3DBPP_ML\3DBPP_ML> mlagents-learn BoxPacking_config_optimized.yaml --run-id=Experiment4_ProperConfig_02
2025-12-02 04:26:33.085328: I tensorflow/core/util/port.cc:153] oneDNN custom operations are on. You may see slightly different numerical results due to floating-point round-off errors from different computation orders. To turn them off, set the environment variable `TF_ENABLE_ONEDNN_OPTS=0`.
2025-12-02 04:26:33.982108: I tensorflow/core/util/port.cc:153] oneDNN custom operations are on. You may see slightly different numerical results due to floating-point round-off errors from different computation orders. To turn them off, set the environment variable `TF_ENABLE_ONEDNN_OPTS=0`.

            ┐  ╖
        ╓╖╬│╡  ││╬╖╖
    ╓╖╬│││││┘  ╬│││││╬╖
 ╖╬│││││╬╜        ╙╬│││││╖╖                               ╗╗╗
 ╬╬╬╬╖││╦╖        ╖╬││╗╣╣╣╬      ╟╣╣╬    ╟╣╣╣             ╜╜╜  ╟╣╣
 ╬╬╬╬╬╬╬╬╖│╬╖╖╓╬╪│╓╣╣╣╣╣╣╣╬      ╟╣╣╬    ╟╣╣╣ ╒╣╣╖╗╣╣╣╗   ╣╣╣ ╣╣╣╣╣╣ ╟╣╣╖   ╣╣╣
 ╬╬╬╬┐  ╙╬╬╬╬│╓╣╣╣╝╜  ╫╣╣╣╬      ╟╣╣╬    ╟╣╣╣ ╟╣╣╣╙ ╙╣╣╣  ╣╣╣ ╙╟╣╣╜╙  ╫╣╣  ╟╣╣
 ╬╬╬╬┐     ╙╬╬╣╣      ╫╣╣╣╬      ╟╣╣╬    ╟╣╣╣ ╟╣╣╬   ╣╣╣  ╣╣╣  ╟╣╣     ╣╣╣┌╣╣╜
 ╬╬╬╜       ╬╬╣╣      ╙╝╣╣╬      ╙╣╣╣╗╖╓╗╣╣╣╜ ╟╣╣╬   ╣╣╣  ╣╣╣  ╟╣╣╦╓    ╣╣╣╣╣
 ╙   ╓╦╖    ╬╬╣╣   ╓╗╗╖            ╙╝╣╣╣╣╝╜   ╘╝╝╜   ╝╝╝  ╝╝╝   ╙╣╣╣    ╟╣╣╣
   ╩╬╬╬╬╬╬╦╦╬╬╣╣╗╣╣╣╣╣╣╣╝                                             ╫╣╣╣╣
      ╙╬╬╬╬╬╬╬╣╣╣╣╣╣╝╜
          ╙╬╬╬╣╣╣╜
             ╙

 Version information:
  ml-agents: 1.1.0,
  ml-agents-envs: 1.1.0,
  Communicator API: 1.5.0,
  PyTorch: 2.2.2+cu121
2025-12-02 04:26:39.951093: I tensorflow/core/util/port.cc:153] oneDNN custom operations are on. You may see slightly different numerical results due to floating-point round-off errors from different computation orders. To turn them off, set the environment variable `TF_ENABLE_ONEDNN_OPTS=0`.
2025-12-02 04:26:41.620086: I tensorflow/core/util/port.cc:153] oneDNN custom operations are on. You may see slightly different numerical results due to floating-point round-off errors from different computation orders. To turn them off, set the environment variable `TF_ENABLE_ONEDNN_OPTS=0`.
[INFO] Listening on port 5004. Start training by pressing the Play button in the Unity Editor.
[INFO] Connected to Unity environment with package version 2.0.2 and communication version 1.5.0
[INFO] Connected new brain: BoxPacker?team=0
[INFO] Hyperparameters for behavior name BoxPacker: 
        trainer_type:   ppo
        hyperparameters:
          batch_size:   2048
          buffer_size:  20480
          learning_rate:        0.0005
          beta: 0.01
          epsilon:      0.2
          lambd:        0.95
          num_epoch:    3
          shared_critic:        False
          learning_rate_schedule:       linear
          beta_schedule:        linear
          epsilon_schedule:     linear
        checkpoint_interval:    250000
        network_settings:
          normalize:    True
          hidden_units: 256
          num_layers:   3
          vis_encode_type:      simple
          memory:       None
          goal_conditioning_type:       hyper
          deterministic:        False
        reward_signals:
          extrinsic:
            gamma:      0.99
            strength:   1.0
            network_settings:
              normalize:        False
              hidden_units:     128
              num_layers:       2
              vis_encode_type:  simple
              memory:   None
              goal_conditioning_type:   hyper
              deterministic:    False
        init_path:      None
        keep_checkpoints:       10
        even_checkpoints:       False
        max_steps:      2000000
        time_horizon:   64
        summary_freq:   10000
        threaded:       False
        self_play:      None
        behavioral_cloning:     None
[INFO] BoxPacker. Step: 10000. Time Elapsed: 211.864 s. Mean Reward: 0.867. Std of Reward: 1.442. Training.
[INFO] BoxPacker. Step: 20000. Time Elapsed: 383.819 s. Mean Reward: 0.868. Std of Reward: 1.416. Training.
[INFO] BoxPacker. Step: 30000. Time Elapsed: 585.386 s. Mean Reward: 1.203. Std of Reward: 1.313. Training.
[INFO] BoxPacker. Step: 40000. Time Elapsed: 768.993 s. Mean Reward: 1.264. Std of Reward: 1.310. Training.
[INFO] BoxPacker. Step: 50000. Time Elapsed: 949.302 s. Mean Reward: 1.499. Std of Reward: 1.131. Training.
[INFO] BoxPacker. Step: 60000. Time Elapsed: 1129.214 s. Mean Reward: 1.542. Std of Reward: 1.078. Training.
[INFO] BoxPacker. Step: 70000. Time Elapsed: 1320.639 s. Mean Reward: 1.653. Std of Reward: 0.981. Training.
[INFO] BoxPacker. Step: 80000. Time Elapsed: 1525.940 s. Mean Reward: 1.661. Std of Reward: 0.929. Training.
[INFO] BoxPacker. Step: 90000. Time Elapsed: 1725.228 s. Mean Reward: 1.723. Std of Reward: 0.876. Training.
[INFO] BoxPacker. Step: 100000. Time Elapsed: 1916.539 s. Mean Reward: 1.745. Std of Reward: 0.883. Training.
[INFO] BoxPacker. Step: 110000. Time Elapsed: 2112.052 s. Mean Reward: 1.755. Std of Reward: 0.844. Training.
[INFO] BoxPacker. Step: 120000. Time Elapsed: 2308.652 s. Mean Reward: 1.771. Std of Reward: 0.832. Training.
[INFO] BoxPacker. Step: 130000. Time Elapsed: 2501.605 s. Mean Reward: 1.768. Std of Reward: 0.800. Training.
[INFO] BoxPacker. Step: 140000. Time Elapsed: 2696.441 s. Mean Reward: 1.783. Std of Reward: 0.806. Training.
[INFO] BoxPacker. Step: 150000. Time Elapsed: 2897.588 s. Mean Reward: 1.780. Std of Reward: 0.780. Training.
[INFO] BoxPacker. Step: 160000. Time Elapsed: 3088.856 s. Mean Reward: 1.799. Std of Reward: 0.792. Training.
[INFO] BoxPacker. Step: 170000. Time Elapsed: 3284.931 s. Mean Reward: 1.795. Std of Reward: 0.795. Training.
[INFO] BoxPacker. Step: 180000. Time Elapsed: 3482.121 s. Mean Reward: 1.808. Std of Reward: 0.786. Training.
[INFO] BoxPacker. Step: 190000. Time Elapsed: 3676.926 s. Mean Reward: 1.808. Std of Reward: 0.786. Training.
[INFO] BoxPacker. Step: 200000. Time Elapsed: 3870.920 s. Mean Reward: 1.820. Std of Reward: 0.790. Training.
[INFO] BoxPacker. Step: 210000. Time Elapsed: 4068.899 s. Mean Reward: 1.793. Std of Reward: 0.757. Training.
[INFO] BoxPacker. Step: 220000. Time Elapsed: 4259.567 s. Mean Reward: 1.808. Std of Reward: 0.758. Training.
[INFO] BoxPacker. Step: 230000. Time Elapsed: 4453.940 s. Mean Reward: 1.819. Std of Reward: 0.767. Training.
[INFO] BoxPacker. Step: 240000. Time Elapsed: 4646.053 s. Mean Reward: 1.825. Std of Reward: 0.782. Training.
[INFO] BoxPacker. Step: 250000. Time Elapsed: 4842.839 s. Mean Reward: 1.835. Std of Reward: 0.775. Training.
[INFO] Exported results\Experiment4_ProperConfig_02\BoxPacker\BoxPacker-249999.onnx
[INFO] BoxPacker. Step: 260000. Time Elapsed: 5035.860 s. Mean Reward: 1.839. Std of Reward: 0.797. Training.
[INFO] BoxPacker. Step: 270000. Time Elapsed: 5231.690 s. Mean Reward: 1.818. Std of Reward: 0.738. Training.
[INFO] BoxPacker. Step: 280000. Time Elapsed: 5426.919 s. Mean Reward: 1.826. Std of Reward: 0.757. Training.
[INFO] BoxPacker. Step: 290000. Time Elapsed: 5623.970 s. Mean Reward: 1.827. Std of Reward: 0.743. Training.
[INFO] BoxPacker. Step: 300000. Time Elapsed: 5816.084 s. Mean Reward: 1.839. Std of Reward: 0.769. Training.
[INFO] BoxPacker. Step: 310000. Time Elapsed: 6016.368 s. Mean Reward: 1.853. Std of Reward: 0.787. Training.
[INFO] BoxPacker. Step: 320000. Time Elapsed: 6207.988 s. Mean Reward: 1.844. Std of Reward: 0.760. Training.
[INFO] BoxPacker. Step: 330000. Time Elapsed: 6401.580 s. Mean Reward: 1.844. Std of Reward: 0.766. Training.
[INFO] BoxPacker. Step: 340000. Time Elapsed: 6595.411 s. Mean Reward: 1.855. Std of Reward: 0.789. Training.
[INFO] BoxPacker. Step: 350000. Time Elapsed: 6792.375 s. Mean Reward: 1.848. Std of Reward: 0.787. Training.
[INFO] BoxPacker. Step: 360000. Time Elapsed: 6983.880 s. Mean Reward: 1.842. Std of Reward: 0.758. Training.
[INFO] Learning was interrupted. Please wait while the graph is generated.
[INFO] Exported results\Experiment4_ProperConfig_02\BoxPacker\BoxPacker-364903.onnx
[INFO] Copied results\Experiment4_ProperConfig_02\BoxPacker\BoxPacker-364903.onnx to results\Experiment4_ProperConfig_02\BoxPacker.onnx.
(mlagents) PS C:\Users\dexte\anaconda3\envs\FirstMLEnv\3DBPP_ML\3DBPP_ML> 


*************************************************
5th run Environment Config
*************************************************
(mlagents) PS C:\Users\dexte\anaconda3\envs\FirstMLEnv\3DBPP_ML\3DBPP_ML> mlagents-learn BoxPacking_config_optimized.yaml --run-id=Experiment4_ProperConfig
2025-12-01 23:46:25.470810: I tensorflow/core/util/port.cc:153] oneDNN custom operations are on. You may see slightly different numerical results due to floating-point round-off errors from different computation orders. To turn them off, set the environment variable `TF_ENABLE_ONEDNN_OPTS=0`.
2025-12-01 23:46:26.820705: I tensorflow/core/util/port.cc:153] oneDNN custom operations are on. You may see slightly different numerical results due to floating-point round-off errors from different computation orders. To turn them off, set the environment variable `TF_ENABLE_ONEDNN_OPTS=0`.

            ┐  ╖
        ╓╖╬│╡  ││╬╖╖
    ╓╖╬│││││┘  ╬│││││╬╖
 ╖╬│││││╬╜        ╙╬│││││╖╖                               ╗╗╗
 ╬╬╬╬╖││╦╖        ╖╬││╗╣╣╣╬      ╟╣╣╬    ╟╣╣╣             ╜╜╜  ╟╣╣
 ╬╬╬╬╬╬╬╬╖│╬╖╖╓╬╪│╓╣╣╣╣╣╣╣╬      ╟╣╣╬    ╟╣╣╣ ╒╣╣╖╗╣╣╣╗   ╣╣╣ ╣╣╣╣╣╣ ╟╣╣╖   ╣╣╣
 ╬╬╬╬┐  ╙╬╬╬╬│╓╣╣╣╝╜  ╫╣╣╣╬      ╟╣╣╬    ╟╣╣╣ ╟╣╣╣╙ ╙╣╣╣  ╣╣╣ ╙╟╣╣╜╙  ╫╣╣  ╟╣╣
 ╬╬╬╬┐     ╙╬╬╣╣      ╫╣╣╣╬      ╟╣╣╬    ╟╣╣╣ ╟╣╣╬   ╣╣╣  ╣╣╣  ╟╣╣     ╣╣╣┌╣╣╜
 ╬╬╬╜       ╬╬╣╣      ╙╝╣╣╬      ╙╣╣╣╗╖╓╗╣╣╣╜ ╟╣╣╬   ╣╣╣  ╣╣╣  ╟╣╣╦╓    ╣╣╣╣╣
 ╙   ╓╦╖    ╬╬╣╣   ╓╗╗╖            ╙╝╣╣╣╣╝╜   ╘╝╝╜   ╝╝╝  ╝╝╝   ╙╣╣╣    ╟╣╣╣
   ╩╬╬╬╬╬╬╦╦╬╬╣╣╗╣╣╣╣╣╣╣╝                                             ╫╣╣╣╣
      ╙╬╬╬╬╬╬╬╣╣╣╣╣╣╝╜
          ╙╬╬╬╣╣╣╜
             ╙

 Version information:
  ml-agents: 1.1.0,
  ml-agents-envs: 1.1.0,
  Communicator API: 1.5.0,
  PyTorch: 2.2.2+cu121
2025-12-01 23:46:32.065501: I tensorflow/core/util/port.cc:153] oneDNN custom operations are on. You may see slightly different numerical results due to floating-point round-off errors from different computation orders. To turn them off, set the environment variable `TF_ENABLE_ONEDNN_OPTS=0`.
2025-12-01 23:46:33.015398: I tensorflow/core/util/port.cc:153] oneDNN custom operations are on. You may see slightly different numerical results due to floating-point round-off errors from different computation orders. To turn them off, set the environment variable `TF_ENABLE_ONEDNN_OPTS=0`.
[INFO] Listening on port 5004. Start training by pressing the Play button in the Unity Editor.
[INFO] Connected to Unity environment with package version 2.0.2 and communication version 1.5.0
[INFO] Connected new brain: BoxPacker?team=0
[INFO] Hyperparameters for behavior name BoxPacker: 
        trainer_type:   ppo
        hyperparameters:
          batch_size:   2048
          buffer_size:  20480
          learning_rate:        0.0005
          beta: 0.01
          epsilon:      0.2
          lambd:        0.95
          num_epoch:    3
          shared_critic:        False
          learning_rate_schedule:       linear
          beta_schedule:        linear
          epsilon_schedule:     linear
        checkpoint_interval:    250000
        network_settings:
          normalize:    True
          hidden_units: 256
          num_layers:   3
          vis_encode_type:      simple
          memory:       None
          goal_conditioning_type:       hyper
          deterministic:        False
        reward_signals:
          extrinsic:
            gamma:      0.99
            strength:   1.0
            network_settings:
              normalize:        False
              hidden_units:     128
              num_layers:       2
              vis_encode_type:  simple
              memory:   None
              goal_conditioning_type:   hyper
              deterministic:    False
        init_path:      None
        keep_checkpoints:       10
        even_checkpoints:       False
        max_steps:      2000000
        time_horizon:   64
        summary_freq:   10000
        threaded:       False
        self_play:      None
        behavioral_cloning:     None
[INFO] BoxPacker. Step: 10000. Time Elapsed: 231.932 s. Mean Reward: 1.325. Std of Reward: 1.257. Training.
[INFO] BoxPacker. Step: 20000. Time Elapsed: 472.880 s. Mean Reward: 1.338. Std of Reward: 1.240. Training.
[INFO] BoxPacker. Step: 30000. Time Elapsed: 704.060 s. Mean Reward: 1.563. Std of Reward: 1.074. Training.
[INFO] BoxPacker. Step: 40000. Time Elapsed: 935.724 s. Mean Reward: 1.572. Std of Reward: 1.050. Training.
[INFO] BoxPacker. Step: 50000. Time Elapsed: 1163.499 s. Mean Reward: 1.734. Std of Reward: 0.893. Training.
[INFO] BoxPacker. Step: 60000. Time Elapsed: 1390.221 s. Mean Reward: 1.729. Std of Reward: 0.840. Training.
[INFO] BoxPacker. Step: 70000. Time Elapsed: 1604.538 s. Mean Reward: 1.780. Std of Reward: 0.824. Training.
[INFO] BoxPacker. Step: 80000. Time Elapsed: 1832.550 s. Mean Reward: 1.790. Std of Reward: 0.818. Training.
[INFO] BoxPacker. Step: 90000. Time Elapsed: 2085.772 s. Mean Reward: 1.812. Std of Reward: 0.805. Training.
[INFO] BoxPacker. Step: 100000. Time Elapsed: 2320.461 s. Mean Reward: 1.799. Std of Reward: 0.782. Training.
[INFO] BoxPacker. Step: 110000. Time Elapsed: 2545.094 s. Mean Reward: 1.803. Std of Reward: 0.773. Training.
[INFO] BoxPacker. Step: 120000. Time Elapsed: 2776.103 s. Mean Reward: 1.815. Std of Reward: 0.791. Training.
[INFO] BoxPacker. Step: 130000. Time Elapsed: 3008.310 s. Mean Reward: 1.815. Std of Reward: 0.760. Training.
[INFO] BoxPacker. Step: 140000. Time Elapsed: 3260.189 s. Mean Reward: 1.824. Std of Reward: 0.764. Training.
[INFO] BoxPacker. Step: 150000. Time Elapsed: 3500.914 s. Mean Reward: 1.837. Std of Reward: 0.770. Training.
[INFO] BoxPacker. Step: 160000. Time Elapsed: 3735.086 s. Mean Reward: 1.834. Std of Reward: 0.763. Training.
[INFO] BoxPacker. Step: 170000. Time Elapsed: 3975.697 s. Mean Reward: 1.839. Std of Reward: 0.774. Training.
[WARNING] Restarting worker[0] after 'The Unity environment took too long to respond. Make sure that :
         The environment does not need user interaction to launch
         The Agents' Behavior Parameters > Behavior Type is set to "Default"
         The environment and the Python interface have compatible versions.
         If you're running on a headless server without graphics support, turn off display by either passing --no-graphics option or build your Unity executable as server build.'
2025-12-02 00:56:03.858710: I tensorflow/core/util/port.cc:153] oneDNN custom operations are on. You may see slightly different numerical results due to floating-point round-off errors from different computation orders. To turn them off, set the environment variable `TF_ENABLE_ONEDNN_OPTS=0`.
2025-12-02 00:56:08.425912: I tensorflow/core/util/port.cc:153] oneDNN custom operations are on. You may see slightly different numerical results due to floating-point round-off errors from different computation orders. To turn them off, set the environment variable `TF_ENABLE_ONEDNN_OPTS=0`.
[INFO] Listening on port 5004. Start training by pressing the Play button in the Unity Editor.
[INFO] Exported results\Experiment4_ProperConfig\BoxPacker\BoxPacker-175133.onnx
[INFO] Copied results\Experiment4_ProperConfig\BoxPacker\BoxPacker-175133.onnx to results\Experiment4_ProperConfig\BoxPacker.onnx.
Traceback (most recent call last):
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\runpy.py", line 196, in _run_module_as_main
    return _run_code(code, main_globals, None,
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\runpy.py", line 86, in _run_code
    exec(code, run_globals)
  File "C:\Users\dexte\anaconda3\envs\mlagents\Scripts\mlagents-learn.exe\__main__.py", line 7, in <module>        
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents\trainers\learn.py", line 270, in main    
    run_cli(parse_command_line())
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents\trainers\learn.py", line 266, in run_cli 
    run_training(run_seed, options, num_areas)
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents\trainers\learn.py", line 138, in run_training
    tc.start_learning(env_manager)
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents_envs\timers.py", line 305, in wrapped
    return func(*args, **kwargs)
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents\trainers\trainer_controller.py", line 175, in start_learning
    n_steps = self.advance(env_manager)
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents_envs\timers.py", line 305, in wrapped    
    return func(*args, **kwargs)
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents\trainers\trainer_controller.py", line 233, in advance
    new_step_infos = env_manager.get_steps()
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents\trainers\env_manager.py", line 124, in get_steps
    new_step_infos = self._step()
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents\trainers\subprocess_env_manager.py", line 420, in _step
    self._restart_failed_workers(step)
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents\trainers\subprocess_env_manager.py", line 328, in _restart_failed_workers
    self.reset(self.env_parameters)
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents\trainers\env_manager.py", line 68, in reset
    self.first_step_infos = self._reset_env(config)
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents\trainers\subprocess_env_manager.py", line 446, in _reset_env
    ew.previous_step = EnvironmentStep(ew.recv().payload, ew.worker_id, {}, {})
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents\trainers\subprocess_env_manager.py", line 101, in recv
    raise env_exception
mlagents_envs.exception.UnityTimeOutException: The Unity environment took too long to respond. Make sure that :    
         The environment does not need user interaction to launch
         The Agents' Behavior Parameters > Behavior Type is set to "Default"
         The environment and the Python interface have compatible versions.
         If you're running on a headless server without graphics support, turn off display by either passing --no-graphics option or build your Unity executable as server build.
(mlagents) PS C:\Users\dexte\anaconda3\envs\FirstMLEnv\3DBPP_ML\3DBPP_ML> 



**************
V4 Output
***********************
dexte\anaconda3\envs\FirstMLEnv\3DBPP_ML\3DBPP_ML>mlagents-learn BoxPacking_config_optimized.yaml --run-id=BoxPacking_Fixed_v4
2025-12-01 22:25:44.480672: I tensorflow/core/util/port.cc:153] oneDNN custom operations are on. You may see slightly different numerical results due to floating-point round-off errors from different computation orders. To turn them off, set the environment variable `TF_ENABLE_ONEDNN_OPTS=0`.
2025-12-01 22:25:45.274339: I tensorflow/core/util/port.cc:153] oneDNN custom operations are on. You may see slightly different numerical results due to floating-point round-off errors from different computation orders. To turn them off, set the environment variable `TF_ENABLE_ONEDNN_OPTS=0`.

            ┐  ╖
        ╓╖╬│╡  ││╬╖╖
    ╓╖╬│││││┘  ╬│││││╬╖
 ╖╬│││││╬╜        ╙╬│││││╖╖                               ╗╗╗
 ╬╬╬╬╖││╦╖        ╖╬││╗╣╣╣╬      ╟╣╣╬    ╟╣╣╣             ╜╜╜  ╟╣╣
 ╬╬╬╬╬╬╬╬╖│╬╖╖╓╬╪│╓╣╣╣╣╣╣╣╬      ╟╣╣╬    ╟╣╣╣ ╒╣╣╖╗╣╣╣╗   ╣╣╣ ╣╣╣╣╣╣ ╟╣╣╖   ╣╣╣
 ╬╬╬╬┐  ╙╬╬╬╬│╓╣╣╣╝╜  ╫╣╣╣╬      ╟╣╣╬    ╟╣╣╣ ╟╣╣╣╙ ╙╣╣╣  ╣╣╣ ╙╟╣╣╜╙  ╫╣╣  ╟╣╣
 ╬╬╬╬┐     ╙╬╬╣╣      ╫╣╣╣╬      ╟╣╣╬    ╟╣╣╣ ╟╣╣╬   ╣╣╣  ╣╣╣  ╟╣╣     ╣╣╣┌╣╣╜
 ╬╬╬╜       ╬╬╣╣      ╙╝╣╣╬      ╙╣╣╣╗╖╓╗╣╣╣╜ ╟╣╣╬   ╣╣╣  ╣╣╣  ╟╣╣╦╓    ╣╣╣╣╣
 ╙   ╓╦╖    ╬╬╣╣   ╓╗╗╖            ╙╝╣╣╣╣╝╜   ╘╝╝╜   ╝╝╝  ╝╝╝   ╙╣╣╣    ╟╣╣╣
   ╩╬╬╬╬╬╬╦╦╬╬╣╣╗╣╣╣╣╣╣╣╝                                             ╫╣╣╣╣
      ╙╬╬╬╬╬╬╬╣╣╣╣╣╣╝╜
          ╙╬╬╬╣╣╣╜
             ╙

 Version information:
  ml-agents: 1.1.0,
  ml-agents-envs: 1.1.0,
  Communicator API: 1.5.0,
  PyTorch: 2.2.2+cu121
2025-12-01 22:25:48.910613: I tensorflow/core/util/port.cc:153] oneDNN custom operations are on. You may see slightly different numerical results due to floating-point round-off errors from different computation orders. To turn them off, set the environment variable `TF_ENABLE_ONEDNN_OPTS=0`.
2025-12-01 22:25:49.792098: I tensorflow/core/util/port.cc:153] oneDNN custom operations are on. You may see slightly different numerical results due to floating-point round-off errors from different computation orders. To turn them off, set the environment variable `TF_ENABLE_ONEDNN_OPTS=0`.
[INFO] Listening on port 5004. Start training by pressing the Play button in the Unity Editor.
[INFO] Connected to Unity environment with package version 2.0.2 and communication version 1.5.0
[INFO] Connected new brain: BoxPacker?team=0
[INFO] Hyperparameters for behavior name BoxPacker: 
        trainer_type:   ppo
        hyperparameters:
          batch_size:   2048
          buffer_size:  20480
          learning_rate:        0.0005
          beta: 0.01
          epsilon:      0.2
          lambd:        0.95
          num_epoch:    3
          shared_critic:        False
          learning_rate_schedule:       linear
          beta_schedule:        linear
          epsilon_schedule:     linear
        checkpoint_interval:    250000
        network_settings:
          normalize:    True
          hidden_units: 256
          num_layers:   3
          vis_encode_type:      simple
          memory:       None
          goal_conditioning_type:       hyper
          deterministic:        False
        reward_signals:
          extrinsic:
            gamma:      0.99
            strength:   1.0
            network_settings:
              normalize:        False
              hidden_units:     128
              num_layers:       2
              vis_encode_type:  simple
              memory:   None
              goal_conditioning_type:   hyper
              deterministic:    False
        init_path:      None
        keep_checkpoints:       10
        even_checkpoints:       False
        max_steps:      2000000
        time_horizon:   64
        summary_freq:   10000
        threaded:       False
        self_play:      None
        behavioral_cloning:     None
[INFO] BoxPacker. Step: 10000. Time Elapsed: 214.908 s. Mean Reward: 1.368. Std of Reward: 1.262. Training.
[INFO] BoxPacker. Step: 20000. Time Elapsed: 398.600 s. Mean Reward: 1.365. Std of Reward: 1.272. Training.
[INFO] BoxPacker. Step: 30000. Time Elapsed: 592.613 s. Mean Reward: 1.596. Std of Reward: 1.081. Training.
[INFO] BoxPacker. Step: 40000. Time Elapsed: 768.965 s. Mean Reward: 1.615. Std of Reward: 1.074. Training.

*******************************************************************

*******************************************************************
V3
*******************************************************************
Theres no V3

*******************************************************************
V2
*******************************************************************

(mlagents) PS C:\Users\dexte\anaconda3\envs\FirstMLEnv\3DBPP_ML\3DBPP_ML> mlagents-learn BoxPacking_config_optimized.yaml --run-id=BoxPacking_Fixed_v2
2025-12-01 14:22:45.688929: I tensorflow/core/util/port.cc:153] oneDNN custom operations are on. You may see slightly different numerical results due to floating-point round-off errors from different computation orders. To turn them off, set the environment variable `TF_ENABLE_ONEDNN_OPTS=0`.
2025-12-01 14:22:47.415255: I tensorflow/core/util/port.cc:153] oneDNN custom operations are on. You may see slightly different numerical results due to floating-point round-off errors from different computation orders. To turn them off, set the environment variable `TF_ENABLE_ONEDNN_OPTS=0`.

            ┐  ╖
        ╓╖╬│╡  ││╬╖╖
    ╓╖╬│││││┘  ╬│││││╬╖
 ╖╬│││││╬╜        ╙╬│││││╖╖                               ╗╗╗
 ╬╬╬╬╖││╦╖        ╖╬││╗╣╣╣╬      ╟╣╣╬    ╟╣╣╣             ╜╜╜  ╟╣╣
 ╬╬╬╬╬╬╬╬╖│╬╖╖╓╬╪│╓╣╣╣╣╣╣╣╬      ╟╣╣╬    ╟╣╣╣ ╒╣╣╖╗╣╣╣╗   ╣╣╣ ╣╣╣╣╣╣ ╟╣╣╖   ╣╣╣
 ╬╬╬╬┐  ╙╬╬╬╬│╓╣╣╣╝╜  ╫╣╣╣╬      ╟╣╣╬    ╟╣╣╣ ╟╣╣╣╙ ╙╣╣╣  ╣╣╣ ╙╟╣╣╜╙  ╫╣╣  ╟╣╣
 ╬╬╬╬┐     ╙╬╬╣╣      ╫╣╣╣╬      ╟╣╣╬    ╟╣╣╣ ╟╣╣╬   ╣╣╣  ╣╣╣  ╟╣╣     ╣╣╣┌╣╣╜
 ╬╬╬╜       ╬╬╣╣      ╙╝╣╣╬      ╙╣╣╣╗╖╓╗╣╣╣╜ ╟╣╣╬   ╣╣╣  ╣╣╣  ╟╣╣╦╓    ╣╣╣╣╣
 ╙   ╓╦╖    ╬╬╣╣   ╓╗╗╖            ╙╝╣╣╣╣╝╜   ╘╝╝╜   ╝╝╝  ╝╝╝   ╙╣╣╣    ╟╣╣╣
   ╩╬╬╬╬╬╬╦╦╬╬╣╣╗╣╣╣╣╣╣╣╝                                             ╫╣╣╣╣
      ╙╬╬╬╬╬╬╬╣╣╣╣╣╣╝╜
          ╙╬╬╬╣╣╣╜
             ╙

 Version information:
  ml-agents: 1.1.0,
  ml-agents-envs: 1.1.0,
  Communicator API: 1.5.0,
  PyTorch: 2.2.2+cu121
2025-12-01 14:22:52.953283: I tensorflow/core/util/port.cc:153] oneDNN custom operations are on. You may see slightly different numerical results due to floating-point round-off errors from different computation orders. To turn them off, set the environment variable `TF_ENABLE_ONEDNN_OPTS=0`.
2025-12-01 14:22:54.226570: I tensorflow/core/util/port.cc:153] oneDNN custom operations are on. You may see slightly different numerical results due to floating-point round-off errors from different computation orders. To turn them off, set the environment variable `TF_ENABLE_ONEDNN_OPTS=0`.
[INFO] Listening on port 5004. Start training by pressing the Play button in the Unity Editor.
[INFO] Connected to Unity environment with package version 2.0.2 and communication version 1.5.0
[INFO] Connected new brain: BoxPacker?team=0
[INFO] Hyperparameters for behavior name BoxPacker:
        trainer_type:   ppo
        hyperparameters:
          batch_size:   2048
          buffer_size:  20480
          learning_rate:        0.0005
          beta: 0.01
          epsilon:      0.2
          lambd:        0.95
          num_epoch:    3
          shared_critic:        False
          learning_rate_schedule:       linear
          beta_schedule:        linear
          epsilon_schedule:     linear
        checkpoint_interval:    250000
        network_settings:
          normalize:    True
          hidden_units: 256
          num_layers:   3
          vis_encode_type:      simple
          memory:       None
          goal_conditioning_type:       hyper
          deterministic:        False
        reward_signals:
          extrinsic:
            gamma:      0.99
            strength:   1.0
            network_settings:
              normalize:        False
              hidden_units:     128
              num_layers:       2
              vis_encode_type:  simple
              memory:   None
              goal_conditioning_type:   hyper
              deterministic:    False
        init_path:      None
        keep_checkpoints:       10
        even_checkpoints:       False
        max_steps:      2000000
        time_horizon:   64
        summary_freq:   10000
        threaded:       False
        self_play:      None
        behavioral_cloning:     None
[INFO] BoxPacker. Step: 10000. Time Elapsed: 237.958 s. Mean Reward: -21.683. Std of Reward: 9.804. Training.
[INFO] BoxPacker. Step: 20000. Time Elapsed: 448.255 s. Mean Reward: -21.780. Std of Reward: 9.802. Training.
[INFO] BoxPacker. Step: 30000. Time Elapsed: 683.628 s. Mean Reward: -21.462. Std of Reward: 9.956. Training.
[INFO] BoxPacker. Step: 40000. Time Elapsed: 895.898 s. Mean Reward: -21.292. Std of Reward: 9.946. Training.
[INFO] BoxPacker. Step: 50000. Time Elapsed: 1100.304 s. Mean Reward: -21.064. Std of Reward: 9.887. Training.
[INFO] BoxPacker. Step: 60000. Time Elapsed: 1285.045 s. Mean Reward: -21.345. Std of Reward: 9.842. Training.
[INFO] BoxPacker. Step: 70000. Time Elapsed: 1463.663 s. Mean Reward: -21.214. Std of Reward: 9.846. Training.
[INFO] BoxPacker. Step: 80000. Time Elapsed: 1654.688 s. Mean Reward: -21.085. Std of Reward: 9.890. Training.
[INFO] BoxPacker. Step: 90000. Time Elapsed: 1838.113 s. Mean Reward: -21.267. Std of Reward: 10.134. Training.
[INFO] BoxPacker. Step: 100000. Time Elapsed: 2017.779 s. Mean Reward: -21.217. Std of Reward: 9.964. Training.
[INFO] BoxPacker. Step: 110000. Time Elapsed: 2188.289 s. Mean Reward: -21.056. Std of Reward: 10.132. Training.
[INFO] BoxPacker. Step: 120000. Time Elapsed: 2356.795 s. Mean Reward: -21.260. Std of Reward: 10.191. Training.
[INFO] BoxPacker. Step: 130000. Time Elapsed: 2526.693 s. Mean Reward: -20.466. Std of Reward: 9.667. Training.
[INFO] BoxPacker. Step: 140000. Time Elapsed: 2692.432 s. Mean Reward: -20.625. Std of Reward: 10.089. Training.
[WARNING] Restarting worker[0] after 'The Unity environment took too long to respond. Make sure that :
         The environment does not need user interaction to launch
         The Agents' Behavior Parameters > Behavior Type is set to "Default"
         The environment and the Python interface have compatible versions.
         If you're running on a headless server without graphics support, turn off display by either passing --no-graphics option or build your Unity executable as server build.'
2025-12-01 15:09:28.612525: I tensorflow/core/util/port.cc:153] oneDNN custom operations are on. You may see slightly different numerical results due to floating-point round-off errors from different computation orders. To turn them off, set the environment variable `TF_ENABLE_ONEDNN_OPTS=0`.
2025-12-01 15:09:30.577505: I tensorflow/core/util/port.cc:153] oneDNN custom operations are on. You may see slightly different numerical results due to floating-point round-off errors from different computation orders. To turn them off, set the environment variable `TF_ENABLE_ONEDNN_OPTS=0`.
[INFO] Listening on port 5004. Start training by pressing the Play button in the Unity Editor.
[INFO] Exported results\BoxPacking_Fixed_v2\BoxPacker\BoxPacker-142340.onnx
[INFO] Copied results\BoxPacking_Fixed_v2\BoxPacker\BoxPacker-142340.onnx to results\BoxPacking_Fixed_v2\BoxPacker.onnx.
Traceback (most recent call last):
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\runpy.py", line 196, in _run_module_as_main
    return _run_code(code, main_globals, None,
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\runpy.py", line 86, in _run_code
    exec(code, run_globals)
  File "C:\Users\dexte\anaconda3\envs\mlagents\Scripts\mlagents-learn.exe\__main__.py", line 7, in <module>
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents\trainers\learn.py", line 270, in main
    run_cli(parse_command_line())
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents\trainers\learn.py", line 266, in run_cli
    run_training(run_seed, options, num_areas)
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents\trainers\learn.py", line 138, in run_training
    tc.start_learning(env_manager)
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents_envs\timers.py", line 305, in wrapped
    return func(*args, **kwargs)
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents\trainers\trainer_controller.py", line 175, in start_learning
    n_steps = self.advance(env_manager)
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents_envs\timers.py", line 305, in wrapped
    return func(*args, **kwargs)
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents\trainers\trainer_controller.py", line 233, in advance
    new_step_infos = env_manager.get_steps()
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents\trainers\env_manager.py", line 124, in get_steps
    new_step_infos = self._step()
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents\trainers\subprocess_env_manager.py", line 420, in _step
    self._restart_failed_workers(step)
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents\trainers\subprocess_env_manager.py", line 328, in _restart_failed_workers
    self.reset(self.env_parameters)
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents\trainers\env_manager.py", line 68, in reset
    self.first_step_infos = self._reset_env(config)
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents\trainers\subprocess_env_manager.py", line 446, in _reset_env
    ew.previous_step = EnvironmentStep(ew.recv().payload, ew.worker_id, {}, {})
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents\trainers\subprocess_env_manager.py", line 101, in recv
    raise env_exception
mlagents_envs.exception.UnityTimeOutException: The Unity environment took too long to respond. Make sure that :
         The environment does not need user interaction to launch
         The Agents' Behavior Parameters > Behavior Type is set to "Default"
         The environment and the Python interface have compatible versions.
         If you're running on a headless server without graphics support, turn off display by either passing --no-graphics option or build your Unity executable as server build.
(mlagents) PS C:\Users\dexte\anaconda3\envs\FirstMLEnv\3DBPP_ML\3DBPP_ML>