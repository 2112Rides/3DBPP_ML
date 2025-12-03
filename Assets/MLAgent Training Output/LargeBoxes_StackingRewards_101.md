LargeBoxes_StackingRewards_101

(mlagents) PS C:\Users\dexte\anaconda3\envs\FirstMLEnv\3DBPP_ML\3DBPP_ML> mlagents-learn BoxPacking_config_optimized.yaml --run-id=LargeBoxes_StackingRewards_101
2025-12-02 20:23:20.346204: I tensorflow/core/util/port.cc:153] oneDNN custom operations are on. You may see slightly different numerical results due to floating-point round-off errors from different computation orders. To turn them off, set the environment variable `TF_ENABLE_ONEDNN_OPTS=0`.
2025-12-02 20:23:21.222720: I tensorflow/core/util/port.cc:153] oneDNN custom operations are on. You may see slightly different numerical results due to floating-point round-off errors from different computation orders. To turn them off, set the environment variable `TF_ENABLE_ONEDNN_OPTS=0`.

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
2025-12-02 20:23:26.229451: I tensorflow/core/util/port.cc:153] oneDNN custom operations are on. You may see slightly different numerical results due to floating-point round-off errors from different computation orders. To turn them off, set the environment variable `TF_ENABLE_ONEDNN_OPTS=0`.
2025-12-02 20:23:27.344874: I tensorflow/core/util/port.cc:153] oneDNN custom operations are on. You may see slightly different numerical results due to floating-point round-off errors from different computation orders. To turn them off, set the environment variable `TF_ENABLE_ONEDNN_OPTS=0`.
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
[INFO] BoxPacker. Step: 10000. Time Elapsed: 164.032 s. Mean Reward: 9.519. Std of Reward: 11.683. Training.
[INFO] BoxPacker. Step: 20000. Time Elapsed: 299.992 s. Mean Reward: 9.250. Std of Reward: 10.646. Training.
[INFO] BoxPacker. Step: 30000. Time Elapsed: 442.649 s. Mean Reward: 9.721. Std of Reward: 11.725. Training.
[INFO] BoxPacker. Step: 40000. Time Elapsed: 578.750 s. Mean Reward: 10.264. Std of Reward: 11.720. Training.
[INFO] BoxPacker. Step: 50000. Time Elapsed: 721.788 s. Mean Reward: 11.658. Std of Reward: 11.404. Training.
[INFO] BoxPacker. Step: 60000. Time Elapsed: 858.526 s. Mean Reward: 11.890. Std of Reward: 10.557. Training.
[INFO] BoxPacker. Step: 70000. Time Elapsed: 1000.938 s. Mean Reward: 11.933. Std of Reward: 10.916. Training.
[INFO] BoxPacker. Step: 80000. Time Elapsed: 1138.956 s. Mean Reward: 12.786. Std of Reward: 10.753. Training.
[INFO] BoxPacker. Step: 90000. Time Elapsed: 1280.782 s. Mean Reward: 13.375. Std of Reward: 10.030. Training.
[INFO] BoxPacker. Step: 100000. Time Elapsed: 1420.519 s. Mean Reward: 14.083. Std of Reward: 10.433. Training.
[INFO] BoxPacker. Step: 110000. Time Elapsed: 1565.925 s. Mean Reward: 14.502. Std of Reward: 9.726. Training.
[INFO] BoxPacker. Step: 120000. Time Elapsed: 1704.909 s. Mean Reward: 16.125. Std of Reward: 9.341. Training.
[INFO] BoxPacker. Step: 130000. Time Elapsed: 1851.546 s. Mean Reward: 16.734. Std of Reward: 9.723. Training.
[INFO] BoxPacker. Step: 140000. Time Elapsed: 1994.048 s. Mean Reward: 17.636. Std of Reward: 9.377. Training.
[INFO] BoxPacker. Step: 150000. Time Elapsed: 2141.714 s. Mean Reward: 17.846. Std of Reward: 9.353. Training.
[WARNING] Restarting worker[0] after 'Communicator has exited.'
2025-12-02 21:00:05.162100: I tensorflow/core/util/port.cc:153] oneDNN custom operations are on. You may see slightly different numerical results due to floating-point round-off errors from different computation orders. To turn them off, set the environment variable `TF_ENABLE_ONEDNN_OPTS=0`.
2025-12-02 21:00:06.837403: I tensorflow/core/util/port.cc:153] oneDNN custom operations are on. You may see slightly different numerical results due to floating-point round-off errors from different computation orders. To turn them off, set the environment variable `TF_ENABLE_ONEDNN_OPTS=0`.
[INFO] Listening on port 5004. Start training by pressing the Play button in the Unity Editor.