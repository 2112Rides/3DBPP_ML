DemoTraining_Error


(mlagents) PS C:\Users\dexte\anaconda3\envs\FirstMLEnv\3DBPP_ML\3DBPP_ML> mlagents-learn Assets/Tasks/3DBPP/Configs/CornerPlacement_BC.yaml --run-id=CornerPlacement_BC_v2 --force
2025-12-04 05:25:10.303589: I tensorflow/core/util/port.cc:153] oneDNN custom operations are on. You may see slightly different numerical results due to floating-point round-off errors from different computation orders. To turn them off, set the environment variable `TF_ENABLE_ONEDNN_OPTS=0`.
2025-12-04 05:25:12.475472: I tensorflow/core/util/port.cc:153] oneDNN custom operations are on. You may see slightly different numerical results due to floating-point round-off errors from different computation orders. To turn them off, set the environment variable `TF_ENABLE_ONEDNN_OPTS=0`.

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
2025-12-04 05:25:19.425510: I tensorflow/core/util/port.cc:153] oneDNN custom operations are on. You may see slightly different numerical results due to floating-point round-off errors from different computation orders. To turn them off, set the environment variable `TF_ENABLE_ONEDNN_OPTS=0`.
2025-12-04 05:25:20.617920: I tensorflow/core/util/port.cc:153] oneDNN custom operations are on. You may see slightly different numerical results due to floating-point round-off errors from different computation orders. To turn them off, set the environment variable `TF_ENABLE_ONEDNN_OPTS=0`.
[INFO] Listening on port 5004. Start training by pressing the Play button in the Unity Editor.
[INFO] Connected to Unity environment with package version 2.0.2 and communication version 1.5.0
[INFO] Connected new brain: CornerPlacementAgent?team=0
[INFO] Hyperparameters for behavior name CornerPlacementAgent: 
        trainer_type:   ppo
        hyperparameters:
          batch_size:   1024
          buffer_size:  10240
          learning_rate:        0.0003
          beta: 0.005
          epsilon:      0.2
          lambd:        0.95
          num_epoch:    3
          shared_critic:        False
          learning_rate_schedule:       linear
          beta_schedule:        linear
          epsilon_schedule:     linear
        checkpoint_interval:    50000
        network_settings:
          normalize:    False
          hidden_units: 128
          num_layers:   2
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
        keep_checkpoints:       5
        even_checkpoints:       False
        max_steps:      200000
        time_horizon:   64
        summary_freq:   10000
        threaded:       False
        self_play:      None
        behavioral_cloning:
          demo_path:    Tasks/3DBPP/Demonstrations/CornerPlacement.demo
          steps:        50000
          strength:     0.5
          samples_per_update:   512
          num_epoch:    None
          batch_size:   None
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
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents\trainers\trainer_controller.py", line 172, in start_learning
    self._reset_env(env_manager)
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents_envs\timers.py", line 305, in wrapped
    return func(*args, **kwargs)
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents\trainers\trainer_controller.py", line 107, in _reset_env
    self._register_new_behaviors(env_manager, env_manager.first_step_infos)
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents\trainers\trainer_controller.py", line 267, in _register_new_behaviors
    self._create_trainers_and_managers(env_manager, new_behavior_ids)
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents\trainers\trainer_controller.py", line 165, in _create_trainers_and_managers
    self._create_trainer_and_manager(env_manager, behavior_id)
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents\trainers\trainer_controller.py", line 141, in _create_trainer_and_manager
    trainer.add_policy(parsed_behavior_id, policy)
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents\trainers\trainer\on_policy_trainer.py", line 135, in add_policy
    self.optimizer = self.create_optimizer()
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents\trainers\ppo\trainer.py", line 168, in create_optimizer
    return TorchPPOOptimizer(  # type: ignore
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents\trainers\ppo\optimizer_torch.py", line 46, in __init__
    super().__init__(policy, trainer_settings)
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents\trainers\optimizer\torch_optimizer.py", line 38, in __init__
    self.bc_module = BCModule(
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents\trainers\torch_entities\components\bc\module.py", line 44, in __init__
    _, self.demonstration_buffer = demo_to_buffer(
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents_envs\timers.py", line 305, in wrapped
    return func(*args, **kwargs)
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents\trainers\demo_loader.py", line 114, in demo_to_buffer
    behavior_spec, info_action_pair, _ = load_demonstration(file_path)
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents_envs\timers.py", line 305, in wrapped
    return func(*args, **kwargs)
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents\trainers\demo_loader.py", line 184, in load_demonstration
    file_paths = get_demo_files(file_path)
  File "C:\Users\dexte\anaconda3\envs\mlagents\lib\site-packages\mlagents\trainers\demo_loader.py", line 168, in get_demo_files
    raise FileNotFoundError(
FileNotFoundError: The demonstration file or directory Tasks/3DBPP/Demonstrations/CornerPlacement.demo does not exist.   
(mlagents) PS C:\Users\dexte\anaconda3\envs\FirstMLEnv\3DBPP_ML\3DBPP_ML>