3dBPP MLAgent output



> Hello  Claude, I dont know if you remember but we put together some training for an ML Agent in Unity. It seemed to work functionaly. But I     
am not sure it really worked in training an ML agent. Here is the output:
(base) PS C:\Users\dexte> conda activate mlagents
(mlagents) PS C:\Users\dexte> cd .\anaconda3\envs\FirstMLEnv\3DBPP_ML\3DBPP_ML\
(mlagents) PS C:\Users\dexte\anaconda3\envs\FirstMLEnv\3DBPP_ML\3DBPP_ML> mlagents-learn --run-id Bin_02
2025-11-26 03:15:29.111820: I tensorflow/core/util/port.cc:153] oneDNN custom operations are on. You may see slightly different numerical results due to floating-point round-off errors from different computation orders. To turn them off, set the environment variable `TF_ENABLE_ONEDNN_OPTS=0`.
2025-11-26 03:15:31.492992: I tensorflow/core/util/port.cc:153] oneDNN custom operations are on. You may see slightly different numerical results due to floating-point round-off errors from different computation orders. To turn them off, set the environment variable `TF_ENABLE_ONEDNN_OPTS=0`.

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
2025-11-26 03:15:42.341423: I tensorflow/core/util/port.cc:153] oneDNN custom operations are on. You may see slightly different numerical results due to floating-point round-off errors from different computation orders. To turn them off, set the environment variable `TF_ENABLE_ONEDNN_OPTS=0`.
2025-11-26 03:15:44.764525: I tensorflow/core/util/port.cc:153] oneDNN custom operations are on. You may see slightly different numerical results due to floating-point round-off errors from different computation orders. To turn them off, set the environment variable `TF_ENABLE_ONEDNN_OPTS=0`.
[INFO] Listening on port 5004. Start training by pressing the Play button in the Unity Editor.
[INFO] Connected to Unity environment with package version 2.0.2 and communication version 1.5.0
[INFO] Connected new brain: BoxPacker?team=0
[WARNING] Behavior name BoxPacker does not match any behaviors specified in the trainer configuration file. A default configuration will be used.
[INFO] Hyperparameters for behavior name BoxPacker:
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
        checkpoint_interval:    500000
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
        max_steps:      500000
        time_horizon:   64
        summary_freq:   50000
        threaded:       False
        self_play:      None
        behavioral_cloning:     None
[INFO] BoxPacker. Step: 50000. Time Elapsed: 1153.836 s. Mean Reward: -198.986. Std of Reward: 76.837. Training.
[INFO] BoxPacker. Step: 100000. Time Elapsed: 2266.215 s. Mean Reward: -192.984. Std of Reward: 4.131. Training.
[INFO] BoxPacker. Step: 150000. Time Elapsed: 3340.279 s. Mean Reward: -192.830. Std of Reward: 4.021. Training.
[INFO] BoxPacker. Step: 200000. Time Elapsed: 4409.049 s. Mean Reward: -192.733. Std of Reward: 4.103. Training.
[INFO] BoxPacker. Step: 250000. Time Elapsed: 5479.214 s. Mean Reward: -192.505. Std of Reward: 4.165. Training.
[INFO] BoxPacker. Step: 300000. Time Elapsed: 6545.075 s. Mean Reward: -192.428. Std of Reward: 4.062. Training.
[INFO] BoxPacker. Step: 350000. Time Elapsed: 7617.330 s. Mean Reward: -192.267. Std of Reward: 4.178. Training.
[INFO] BoxPacker. Step: 400000. Time Elapsed: 8688.824 s. Mean Reward: -192.073. Std of Reward: 4.066. Training.
[INFO] BoxPacker. Step: 450000. Time Elapsed: 9758.439 s. Mean Reward: -191.838. Std of Reward: 4.101. Training.
[INFO] BoxPacker. Step: 500000. Time Elapsed: 10833.774 s. Mean Reward: -191.632. Std of Reward: 4.106. Training.
[INFO] Exported results\Bin_02\BoxPacker\BoxPacker-499994.onnx
[INFO] Exported results\Bin_02\BoxPacker\BoxPacker-500014.onnx
[INFO] Copied results\Bin_02\BoxPacker\BoxPacker-500014.onnx to results\Bin_02\BoxPacker.onnx.
(mlagents) PS C:\Users\dexte\anaconda3\envs\FirstMLEnv\3DBPP_ML\3DBPP_ML> 