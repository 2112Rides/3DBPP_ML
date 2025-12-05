Is DemoRecorder_Used2LoadDemos.md 
CORRECT?

(mlagentsRec) PS C:\Users\dexte\anaconda3\envs\FirstMLEnv\3DBPP_ML\3DBPP_ML> mlagents-learn Assets/Tasks/3DBPP/Configs/CornerPlacement_BC_Fixed.yaml --run-id=BC_fixed_v2

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
  ml-agents: 0.28.0,
  ml-agents-envs: 0.28.0,
  Communicator API: 1.5.0,
  PyTorch: 2.0.1+cu118
[INFO] Listening on port 5004. Start training by pressing the Play button in the Unity Editor.
[INFO] Connected to Unity environment with package version 2.0.2 and communication version 1.5.0
[INFO] Connected new brain: CornerPlacementAgent?team=0
[INFO] Hyperparameters for behavior name CornerPlacementAgent:
        trainer_type:   ppo
        hyperparameters:
          batch_size:   128
          buffer_size:  2048
          learning_rate:        0.0003
          beta: 0.01
          epsilon:      0.2
          lambd:        0.95
          num_epoch:    3
          learning_rate_schedule:       linear
          beta_schedule:        linear
          epsilon_schedule:     linear
        network_settings:
          normalize:    False
          hidden_units: 256
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
        checkpoint_interval:    500000
        max_steps:      100000
        time_horizon:   64
        summary_freq:   5000
        threaded:       False
        self_play:      None
        behavioral_cloning:
          demo_path:    Assets/Tasks/3DBPP/Demonstrations/CornerPADiscrete.demo
          steps:        50000
          strength:     0.5
          samples_per_update:   512
          num_epoch:    None
          batch_size:   None
C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\torch\networks.py:91: UserWarning: Creating a tensor from a list of numpy.ndarrays is extremely slow. Please consider converting the list to a single numpy.ndarray with numpy.array() before converting to a tensor. (Triggered internally at C:\actions-runner\_work\pytorch\pytorch\builder\windows\pytorch\torch\csrc\utils\tensor_new.cpp:248.)
  enc.update_normalization(torch.as_tensor(vec_input))
[WARNING] Restarting worker[0] after 'Communicator has exited.'
[INFO] Listening on port 5004. Start training by pressing the Play button in the Unity Editor.
[INFO] Connected to Unity environment with package version 2.0.2 and communication version 1.5.0
[INFO] Connected new brain: CornerPlacementAgent?team=0
[ERROR] Worker 0 exceeded the allowed number of restarts.
[INFO] Learning was interrupted. Please wait while the graph is generated.
============= Diagnostic Run torch.onnx.export version 2.0.1+cu118 =============
verbose: False, log level: Level.ERROR
======================= 0 NONE 0 NOTE 0 WARNING 0 ERROR ========================

[ERROR] SubprocessEnvManager had workers that didn't signal shutdown
Traceback (most recent call last):
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\torch\onnx\_internal\onnx_proto_utils.py", line 219, in _add_onnxscript_fn
    import onnx
ModuleNotFoundError: No module named 'onnx'

The above exception was the direct cause of the following exception:

Traceback (most recent call last):
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\runpy.py", line 194, in _run_module_as_main
    return _run_code(code, main_globals, None,
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\runpy.py", line 87, in _run_code
    exec(code, run_globals)
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\Scripts\mlagents-learn.exe\__main__.py", line 7, in <module>
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\learn.py", line 260, in main
    run_cli(parse_command_line())
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\learn.py", line 256, in run_cli
    run_training(run_seed, options, num_areas)
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\learn.py", line 132, in run_training
    tc.start_learning(env_manager)
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents_envs\timers.py", line 305, in wrapped
    return func(*args, **kwargs)
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\trainer_controller.py", line 201, in start_learning
    self._save_models()
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents_envs\timers.py", line 305, in wrapped
    return func(*args, **kwargs)
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\trainer_controller.py", line 80, in _save_models
    self.trainers[brain_name].save_model()
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\trainer\rl_trainer.py", line 185, in save_model
    model_checkpoint = self._checkpoint()
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents_envs\timers.py", line 305, in wrapped
    return func(*args, **kwargs)
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\trainer\rl_trainer.py", line 157, in _checkpoint
    export_path, auxillary_paths = self.model_saver.save_checkpoint(
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\model_saver\torch_model_saver.py", line 60, in save_checkpoint
    self.export(checkpoint_path, behavior_name)
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\model_saver\torch_model_saver.py", line 65, in export
    self.exporter.export_policy_model(output_filepath)
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\torch\model_serialization.py", line 164, in export_policy_model
    torch.onnx.export(
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\torch\onnx\utils.py", line 506, in export
    _export(
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\torch\onnx\utils.py", line 1620, in _export
    proto = onnx_proto_utils._add_onnxscript_fn(
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\torch\onnx\_internal\onnx_proto_utils.py", line 221, in _add_onnxscript_fn
    raise errors.OnnxExporterError("Module onnx is not installed!") from e
torch.onnx.errors.OnnxExporterError: Module onnx is not installed!