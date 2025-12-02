Action Masking Output:

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