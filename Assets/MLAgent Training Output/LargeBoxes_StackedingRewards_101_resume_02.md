LargeBoxes_StackedingRewards_101_resume

____________________________________________________________________________________________________________________________________________________________________________________________
2nd RESUME run
____________________________________________________________________________________________________________________________________________________________________________________________
(mlagents) PS C:\Users\dexte\anaconda3\envs\FirstMLEnv\3DBPP_ML\3DBPP_ML> mlagents-learn BoxPacking_config_optimized.yaml
 --run-id=LargeBoxes_StackingRewards_101 --resume
2025-12-03 01:42:43.993287: I tensorflow/core/util/port.cc:153] oneDNN custom operations are on. You may see slightly different numerical results due to floating-point round-off errors from different computation orders. To turn them off, set the environment variable `TF_ENABLE_ONEDNN_OPTS=0`.
2025-12-03 01:42:45.537563: I tensorflow/core/util/port.cc:153] oneDNN custom operations are on. You may see slightly different numerical results due to floating-point round-off errors from different computation orders. To turn them off, set the environment variable `TF_ENABLE_ONEDNN_OPTS=0`.

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
2025-12-03 01:42:51.107340: I tensorflow/core/util/port.cc:153] oneDNN custom operations are on. You may see slightly different numerical results due to floating-point round-off errors from different computation orders. To turn them off, set the environment variable `TF_ENABLE_ONEDNN_OPTS=0`.
2025-12-03 01:42:52.220692: I tensorflow/core/util/port.cc:153] oneDNN custom operations are on. You may see slightly different numerical results due to floating-point round-off errors from different computation orders. To turn them off, set the environment variable `TF_ENABLE_ONEDNN_OPTS=0`.
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
[INFO] Resuming from results\LargeBoxes_StackingRewards_101\BoxPacker.
[INFO] Resuming training from step 249988.
[INFO] BoxPacker. Step: 250000. Time Elapsed: 14.630 s. Mean Reward: 12.027. Std of Reward: 0.000. Training.
[INFO] Exported results\LargeBoxes_StackingRewards_101\BoxPacker\BoxPacker-249998.onnx
[INFO] BoxPacker. Step: 260000. Time Elapsed: 216.728 s. Mean Reward: 20.265. Std of Reward: 9.617. Training.
[INFO] BoxPacker. Step: 270000. Time Elapsed: 404.712 s. Mean Reward: 20.543. Std of Reward: 10.088. Training.
[INFO] BoxPacker. Step: 280000. Time Elapsed: 597.360 s. Mean Reward: 20.816. Std of Reward: 9.968. Training.
[INFO] BoxPacker. Step: 290000. Time Elapsed: 758.690 s. Mean Reward: 20.795. Std of Reward: 10.002. Training.
[INFO] BoxPacker. Step: 300000. Time Elapsed: 908.819 s. Mean Reward: 21.367. Std of Reward: 10.168. Training.
[INFO] BoxPacker. Step: 310000. Time Elapsed: 1054.670 s. Mean Reward: 20.851. Std of Reward: 9.944. Training.
[INFO] BoxPacker. Step: 320000. Time Elapsed: 1261.857 s. Mean Reward: 21.454. Std of Reward: 10.019. Training.
[INFO] BoxPacker. Step: 330000. Time Elapsed: 1457.482 s. Mean Reward: 21.462. Std of Reward: 10.235. Training.
[INFO] BoxPacker. Step: 340000. Time Elapsed: 1653.880 s. Mean Reward: 22.204. Std of Reward: 10.107. Training.
[INFO] BoxPacker. Step: 350000. Time Elapsed: 1834.232 s. Mean Reward: 21.720. Std of Reward: 10.111. Training.
[INFO] BoxPacker. Step: 360000. Time Elapsed: 2041.203 s. Mean Reward: 22.884. Std of Reward: 10.243. Training.
[INFO] BoxPacker. Step: 370000. Time Elapsed: 2230.972 s. Mean Reward: 22.470. Std of Reward: 9.855. Training.
[INFO] BoxPacker. Step: 380000. Time Elapsed: 2397.193 s. Mean Reward: 22.748. Std of Reward: 10.335. Training.
[INFO] BoxPacker. Step: 390000. Time Elapsed: 2573.379 s. Mean Reward: 23.276. Std of Reward: 10.861. Training.
[INFO] BoxPacker. Step: 400000. Time Elapsed: 2733.713 s. Mean Reward: 23.300. Std of Reward: 10.466. Training.
[INFO] BoxPacker. Step: 410000. Time Elapsed: 2896.119 s. Mean Reward: 22.911. Std of Reward: 10.766. Training.
[INFO] BoxPacker. Step: 420000. Time Elapsed: 3024.000 s. Mean Reward: 23.009. Std of Reward: 10.566. Training.
[INFO] BoxPacker. Step: 430000. Time Elapsed: 3150.559 s. Mean Reward: 23.545. Std of Reward: 10.225. Training.
[INFO] BoxPacker. Step: 440000. Time Elapsed: 3288.535 s. Mean Reward: 23.451. Std of Reward: 10.273. Training.
[INFO] BoxPacker. Step: 450000. Time Elapsed: 3438.041 s. Mean Reward: 23.487. Std of Reward: 10.358. Training.
[INFO] BoxPacker. Step: 460000. Time Elapsed: 3606.523 s. Mean Reward: 24.084. Std of Reward: 10.345. Training.


____________________________________________________________________________________________________________________________________________________________________________________________
1st RESUME run
____________________________________________________________________________________________________________________________________________________________________________________________

(mlagents) PS C:\Users\dexte\anaconda3\envs\FirstMLEnv\3DBPP_ML\3DBPP_ML> mlagents-learn BoxPacking_config_optimized.yaml --run-id=LargeBoxes_StackingRewards_101 --resume
2025-12-02 21:12:26.855930: I tensorflow/core/util/port.cc:153] oneDNN custom operations are on. You may see slightly different numerical results due to floating-point round-off errors from different computation orders. To turn them off, set the environment variable `TF_ENABLE_ONEDNN_OPTS=0`.
2025-12-02 21:12:28.174261: I tensorflow/core/util/port.cc:153] oneDNN custom operations are on. You may see slightly different numerical results due to floating-point round-off errors from different computation orders. To turn them off, set the environment variable `TF_ENABLE_ONEDNN_OPTS=0`.

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
2025-12-02 21:12:32.666812: I tensorflow/core/util/port.cc:153] oneDNN custom operations are on. You may see slightly different numerical results due to floating-point round-off errors from different computation orders. To turn them off, set the environment variable `TF_ENABLE_ONEDNN_OPTS=0`.
2025-12-02 21:12:33.635827: I tensorflow/core/util/port.cc:153] oneDNN custom operations are on. You may see slightly different numerical results due to floating-point round-off errors from different computation orders. To turn them off, set the environment variable `TF_ENABLE_ONEDNN_OPTS=0`.
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
[INFO] Resuming from results\LargeBoxes_StackingRewards_101\BoxPacker.
[INFO] Resuming training from step 153299.
[INFO] BoxPacker. Step: 160000. Time Elapsed: 136.020 s. Mean Reward: 18.186. Std of Reward: 9.671. Training.
[INFO] BoxPacker. Step: 170000. Time Elapsed: 284.055 s. Mean Reward: 18.098. Std of Reward: 9.433. Training.
[INFO] BoxPacker. Step: 180000. Time Elapsed: 436.400 s. Mean Reward: 18.490. Std of Reward: 9.617. Training.
[INFO] BoxPacker. Step: 190000. Time Elapsed: 588.216 s. Mean Reward: 18.651. Std of Reward: 9.304. Training.
[INFO] BoxPacker. Step: 200000. Time Elapsed: 743.635 s. Mean Reward: 19.265. Std of Reward: 9.763. Training.
[INFO] BoxPacker. Step: 210000. Time Elapsed: 891.107 s. Mean Reward: 19.716. Std of Reward: 9.599. Training.
[INFO] BoxPacker. Step: 220000. Time Elapsed: 1042.361 s. Mean Reward: 20.629. Std of Reward: 9.941. Training.
[INFO] BoxPacker. Step: 230000. Time Elapsed: 1191.182 s. Mean Reward: 20.143. Std of Reward: 9.638. Training.
[INFO] BoxPacker. Step: 240000. Time Elapsed: 1350.971 s. Mean Reward: 20.193. Std of Reward: 10.217. Training.
[INFO] BoxPacker. Step: 250000. Time Elapsed: 1500.532 s. Mean Reward: 20.510. Std of Reward: 9.951. Training.
[INFO] Exported results\LargeBoxes_StackingRewards_101\BoxPacker\BoxPacker-249988.onnx
[INFO] BoxPacker. Step: 260000. Time Elapsed: 1655.158 s. Mean Reward: 21.064. Std of Reward: 10.061. Training.
[INFO] BoxPacker. Step: 270000. Time Elapsed: 1804.028 s. Mean Reward: 20.859. Std of Reward: 9.752. Training.
[INFO] BoxPacker. Step: 280000. Time Elapsed: 1959.815 s. Mean Reward: 21.001. Std of Reward: 9.655. Training.
[INFO] BoxPacker. Step: 290000. Time Elapsed: 2107.822 s. Mean Reward: 21.303. Std of Reward: 10.398. Training.
[INFO] BoxPacker. Step: 300000. Time Elapsed: 2262.616 s. Mean Reward: 21.944. Std of Reward: 10.521. Training.
[INFO] BoxPacker. Step: 310000. Time Elapsed: 2414.613 s. Mean Reward: 22.204. Std of Reward: 10.129. Training.
[INFO] BoxPacker. Step: 320000. Time Elapsed: 2572.387 s. Mean Reward: 21.505. Std of Reward: 10.252. Training.
[INFO] BoxPacker. Step: 330000. Time Elapsed: 2723.459 s. Mean Reward: 22.078. Std of Reward: 10.228. Training.
[INFO] BoxPacker. Step: 340000. Time Elapsed: 2879.100 s. Mean Reward: 22.656. Std of Reward: 10.124. Training.
[INFO] BoxPacker. Step: 350000. Time Elapsed: 3029.833 s. Mean Reward: 22.505. Std of Reward: 10.221. Training.
[INFO] BoxPacker. Step: 360000. Time Elapsed: 3189.640 s. Mean Reward: 22.356. Std of Reward: 10.421. Training.
[INFO] BoxPacker. Step: 370000. Time Elapsed: 3340.202 s. Mean Reward: 22.786. Std of Reward: 10.438. Training.
[INFO] BoxPacker. Step: 380000. Time Elapsed: 3498.754 s. Mean Reward: 22.614. Std of Reward: 10.194. Training.
[WARNING] Restarting worker[0] after 'Communicator has exited.'
2025-12-02 22:11:53.600942: I tensorflow/core/util/port.cc:153] oneDNN custom operations are on. You may see slightly different numerical results due to floating-point round-off errors from different computation orders. To turn them off, set the environment variable `TF_ENABLE_ONEDNN_OPTS=0`.
2025-12-02 22:11:56.032464: I tensorflow/core/util/port.cc:153] oneDNN custom operations are on. You may see slightly different numerical results due to floating-point round-off errors from different computation orders. To turn them off, set the environment variable `TF_ENABLE_ONEDNN_OPTS=0`.
[INFO] Listening on port 5004. Start training by pressing the Play button in the Unity Editor.
[INFO] Learning was interrupted. Please wait while the graph is generated.
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
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents\trainers\trainer_controller.py", line 200, in start_learning
    self._save_models()
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents_envs\timers.py", line 305, in wrapped
    return func(*args, **kwargs)
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents\trainers\trainer_controller.py", line 80, in _save_models
    self.trainers[brain_name].save_model()
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents\trainers\trainer\rl_trainer.py", line 172, in save_model
    model_checkpoint = self._checkpoint()
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents_envs\timers.py", line 305, in wrapped
    return func(*args, **kwargs)
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents\trainers\trainer\rl_trainer.py", line 144, in _checkpoint
    export_path, auxillary_paths = self.model_saver.save_checkpoint(
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents\trainers\model_saver\torch_model_saver.py", line 53, in save_checkpoint
    state_dict = {
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents\trainers\model_saver\torch_model_saver.py", line 54, in <dictcomp>
    name: module.state_dict() for name, module in self.modules.items()
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\torch\_compile.py", line 24, in inner
    return torch._dynamo.disable(fn, recursive)(*args, **kwargs)
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\torch\_dynamo\decorators.py", line 46, in disable       
    return DisableContext()(fn)
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\torch\_dynamo\eval_frame.py", line 592, in __init__     
    def __init__(self):
KeyboardInterrupt
(mlagents) PS C:\Users\dexte\anaconda3\envs\FirstMLEnv\3DBPP_ML\3DBPP_ML> ^C