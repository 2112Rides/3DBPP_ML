Demos_NOT_Loading_CornerPANewHeur.md
_______________________________________________________________________________________________________________________
Anaconda PowerShell output:
_______________________________________________________________________________________________________________________
 Version information:
  ml-agents: 0.28.0,
  ml-agents-envs: 0.28.0,
  Communicator API: 1.5.0,
  PyTorch: 2.0.1+cu118
[INFO] Listening on port 5004. Start training by pressing the Play button in the Unity Editor.
[INFO] Connected to Unity environment with package version 2.0.2 and communication version 1.5.0
[INFO] Connected new brain: CornerPlacementAgent?team=0
← NO DEMO LOADING MESSAGES HERE!!!!!!!!!! ←
[INFO] Hyperparameters for behavior name CornerPlacementAgent:
        trainer_type:   ppo
        hyperparameters:


_______________________________________________________________________________________________________________________
Unity console output:
_______________________________________________________________________________________________________________________
[LearningAgent] Task set to: 3DBPP_L1_CornerPlacement
UnityEngine.Debug:Log (object)
LearningPipeline.Core.LearningAgent:SetupTask (LearningPipeline.Core.ILearningTask) (at Assets/LearningPipeline/Core/LearningAgent.cs:34)
Tasks._3DBPP.Agents.CornerPlacementAgent:Initialize () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:65)
Unity.MLAgents.Agent:LazyInitialize () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:464)
Unity.MLAgents.Agent:OnEnable () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:365)

=== CORNER PLACEMENT AGENT ===
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:Initialize () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:83)
Unity.MLAgents.Agent:LazyInitialize () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:464)
Unity.MLAgents.Agent:OnEnable () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:365)

Arrow Keys: Move cursor
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:Initialize () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:84)
Unity.MLAgents.Agent:LazyInitialize () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:464)
Unity.MLAgents.Agent:OnEnable () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:365)

R: Rotate box
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:Initialize () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:85)
Unity.MLAgents.Agent:LazyInitialize () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:464)
Unity.MLAgents.Agent:OnEnable () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:365)

Space: Place box
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:Initialize () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:86)
Unity.MLAgents.Agent:LazyInitialize () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:464)
Unity.MLAgents.Agent:OnEnable () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:365)

==============================
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:Initialize () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:87)
Unity.MLAgents.Agent:LazyInitialize () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:464)
Unity.MLAgents.Agent:OnEnable () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:365)

Box 1/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:298)
Tasks._3DBPP.Agents.CornerPlacementAgent:ResetAgent () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:164)
LearningPipeline.Core.LearningAgent:OnEpisodeBegin () (at Assets/LearningPipeline/Core/LearningAgent.cs:49)
Unity.MLAgents.Agent:_AgentReset () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1299)
Unity.MLAgents.Academy:ForcedFullReset () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:548)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:562)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=green>Corner 2 occupied!</color> (1/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:222)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 2/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:298)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:243)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Invalid placement attempted
UnityEngine.Debug:LogWarning (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:249)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=red>Box not in corner!</color> Position: (32.86, 0.00, 21.43)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:105)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:222)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

