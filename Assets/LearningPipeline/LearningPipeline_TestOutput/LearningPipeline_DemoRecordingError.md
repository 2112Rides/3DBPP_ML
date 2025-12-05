LearningPipeline_DemoRecordingError

[KeyboardController] CornerPlacementDemo does not implement IInputMapper!
UnityEngine.Debug:LogError (object)
LearningPipeline.Imitation.KeyboardController:Awake () (at Assets/LearningPipeline/Imitation/KeyboardController.cs:55)

Couldn't connect to trainer on port 5004 using API version 1.5.0. Will perform inference instead.
UnityEngine.Debug:Log (object)
Unity.MLAgents.Academy:InitializeEnvironment () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:459)
Unity.MLAgents.Academy:LazyInitialize () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:279)
Unity.MLAgents.Academy:.ctor () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:248)
Unity.MLAgents.Academy/<>c:<.cctor>b__83_0 () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:117)
System.Lazy`1<Unity.MLAgents.Academy>:get_Value ()
Unity.MLAgents.Academy:get_Instance () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:132)
Unity.MLAgents.Agent:LazyInitialize () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:451)
Unity.MLAgents.Agent:OnEnable () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:365)

[LearningAgent] Task set to: 3DBPP_L1_CornerPlacement
UnityEngine.Debug:Log (object)
LearningPipeline.Core.LearningAgent:SetupTask (LearningPipeline.Core.ILearningTask) (at Assets/LearningPipeline/Core/LearningAgent.cs:34)
Tasks._3DBPP.Agents.CornerPlacementAgent:Initialize () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:47)
Unity.MLAgents.Agent:LazyInitialize () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:464)
Unity.MLAgents.Agent:OnEnable () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:365)

=== KEYBOARD CONTROLLER ACTIVE ===
UnityEngine.Debug:Log (object)
LearningPipeline.Imitation.KeyboardController:DisplayControls () (at Assets/LearningPipeline/Imitation/KeyboardController.cs:164)
LearningPipeline.Imitation.KeyboardController:Start () (at Assets/LearningPipeline/Imitation/KeyboardController.cs:74)

Toggle Recording: D
UnityEngine.Debug:Log (object)
LearningPipeline.Imitation.KeyboardController:DisplayControls () (at Assets/LearningPipeline/Imitation/KeyboardController.cs:165)
LearningPipeline.Imitation.KeyboardController:Start () (at Assets/LearningPipeline/Imitation/KeyboardController.cs:74)

Cancel Episode: Escape
UnityEngine.Debug:Log (object)
LearningPipeline.Imitation.KeyboardController:DisplayControls () (at Assets/LearningPipeline/Imitation/KeyboardController.cs:166)
LearningPipeline.Imitation.KeyboardController:Start () (at Assets/LearningPipeline/Imitation/KeyboardController.cs:74)

=================================
UnityEngine.Debug:Log (object)
LearningPipeline.Imitation.KeyboardController:DisplayControls () (at Assets/LearningPipeline/Imitation/KeyboardController.cs:171)
LearningPipeline.Imitation.KeyboardController:Start () (at Assets/LearningPipeline/Imitation/KeyboardController.cs:74)

Box 1/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:190)
Tasks._3DBPP.Agents.CornerPlacementAgent:ResetAgent () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:72)
LearningPipeline.Core.LearningAgent:OnEpisodeBegin () (at Assets/LearningPipeline/Core/LearningAgent.cs:49)
Unity.MLAgents.Agent:_AgentReset () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1299)
Unity.MLAgents.Academy:ForcedFullReset () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:548)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:562)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Rotation: 90°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:52)

Rotation: 180°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:52)

Rotation: 270°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:52)

Rotation: 0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:52)

<color=cyan>ACTION CONFIRMED:</color> Grid(7,6) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:59)

<color=cyan>ACTION CONFIRMED:</color> Grid(0,6) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:59)

<color=cyan>ACTION CONFIRMED:</color> Grid(0,0) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:59)

<color=cyan>ACTION CONFIRMED:</color> Grid(7,0) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:59)

<color=cyan>ACTION CONFIRMED:</color> Grid(7,0) Rot=90°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:59)

<color=cyan>ACTION CONFIRMED:</color> Grid(7,0) Rot=180°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:59)

<color=cyan>ACTION CONFIRMED:</color> Grid(7,0) Rot=270°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:59)

