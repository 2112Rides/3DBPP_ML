DemoRecording_mlagentRec 

Unity output to console during recording:

______________________________________________________________________________________________________________________________________________________________________________________________________________________
 New Heuristic Function - New Python Env : mlagentRec

 The resulting *.demo file is only 4kb:
 3DBPP_ML\Assets\Tasks\3DBPP\Demonstrations\CornerPANewHeur.demo
______________________________________________________________________________________________________________________________________________________________________________________________________________________
There were two Cyan Box Cursors. Both responded to keyboard input. One was created at the center of the pallet as it should be. The other was created in the left back corner. The following is the Heuristic console output:

<color=yellow>HEURISTIC CALLED #1:</color> Action=56 (Grid:7,0 Rot:0°)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:275)
Unity.MLAgents.Actuators.VectorActuator:Heuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:83)
Unity.MLAgents.Actuators.VectorActuator:Unity.MLAgents.Actuators.IHeuristicProvider.Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&)
Unity.MLAgents.Actuators.ActuatorManager:ApplyHeuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:250)
Unity.MLAgents.Policies.HeuristicPolicy:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Policies/HeuristicPolicy.cs:49)
Unity.MLAgents.Agent:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1360)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:578)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=yellow>HEURISTIC CALLED #2:</color> Action=63 (Grid:7,7 Rot:0°)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:275)
Unity.MLAgents.Actuators.VectorActuator:Heuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:83)
Unity.MLAgents.Actuators.VectorActuator:Unity.MLAgents.Actuators.IHeuristicProvider.Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&)
Unity.MLAgents.Actuators.ActuatorManager:ApplyHeuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:250)
Unity.MLAgents.Policies.HeuristicPolicy:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Policies/HeuristicPolicy.cs:49)
Unity.MLAgents.Agent:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1360)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:578)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=yellow>HEURISTIC CALLED #3:</color> Action=63 (Grid:7,7 Rot:0°)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:275)
Unity.MLAgents.Actuators.VectorActuator:Heuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:83)
Unity.MLAgents.Actuators.VectorActuator:Unity.MLAgents.Actuators.IHeuristicProvider.Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&)
Unity.MLAgents.Actuators.ActuatorManager:ApplyHeuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:250)
Unity.MLAgents.Policies.HeuristicPolicy:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Policies/HeuristicPolicy.cs:49)
Unity.MLAgents.Agent:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1360)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:578)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=yellow>HEURISTIC CALLED #4:</color> Action=7 (Grid:0,7 Rot:0°)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:275)
Unity.MLAgents.Actuators.VectorActuator:Heuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:83)
Unity.MLAgents.Actuators.VectorActuator:Unity.MLAgents.Actuators.IHeuristicProvider.Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&)
Unity.MLAgents.Actuators.ActuatorManager:ApplyHeuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:250)
Unity.MLAgents.Policies.HeuristicPolicy:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Policies/HeuristicPolicy.cs:49)
Unity.MLAgents.Agent:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1360)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:578)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=yellow>HEURISTIC CALLED #5:</color> Action=0 (Grid:0,0 Rot:0°)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:275)
Unity.MLAgents.Actuators.VectorActuator:Heuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:83)
Unity.MLAgents.Actuators.VectorActuator:Unity.MLAgents.Actuators.IHeuristicProvider.Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&)
Unity.MLAgents.Actuators.ActuatorManager:ApplyHeuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:250)
Unity.MLAgents.Policies.HeuristicPolicy:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Policies/HeuristicPolicy.cs:49)
Unity.MLAgents.Agent:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1360)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:578)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=yellow>HEURISTIC CALLED #6:</color> Action=60 (Grid:7,4 Rot:0°)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:275)
Unity.MLAgents.Actuators.VectorActuator:Heuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:83)
Unity.MLAgents.Actuators.VectorActuator:Unity.MLAgents.Actuators.IHeuristicProvider.Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&)
Unity.MLAgents.Actuators.ActuatorManager:ApplyHeuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:250)
Unity.MLAgents.Policies.HeuristicPolicy:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Policies/HeuristicPolicy.cs:49)
Unity.MLAgents.Agent:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1360)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:578)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=yellow>HEURISTIC CALLED #7:</color> Action=63 (Grid:7,7 Rot:0°)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:275)
Unity.MLAgents.Actuators.VectorActuator:Heuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:83)
Unity.MLAgents.Actuators.VectorActuator:Unity.MLAgents.Actuators.IHeuristicProvider.Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&)
Unity.MLAgents.Actuators.ActuatorManager:ApplyHeuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:250)
Unity.MLAgents.Policies.HeuristicPolicy:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Policies/HeuristicPolicy.cs:49)
Unity.MLAgents.Agent:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1360)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:578)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=yellow>HEURISTIC CALLED #8:</color> Action=7 (Grid:0,7 Rot:0°)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:275)
Unity.MLAgents.Actuators.VectorActuator:Heuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:83)
Unity.MLAgents.Actuators.VectorActuator:Unity.MLAgents.Actuators.IHeuristicProvider.Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&)
Unity.MLAgents.Actuators.ActuatorManager:ApplyHeuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:250)
Unity.MLAgents.Policies.HeuristicPolicy:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Policies/HeuristicPolicy.cs:49)
Unity.MLAgents.Agent:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1360)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:578)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=yellow>HEURISTIC CALLED #9:</color> Action=0 (Grid:0,0 Rot:0°)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:275)
Unity.MLAgents.Actuators.VectorActuator:Heuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:83)
Unity.MLAgents.Actuators.VectorActuator:Unity.MLAgents.Actuators.IHeuristicProvider.Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&)
Unity.MLAgents.Actuators.ActuatorManager:ApplyHeuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:250)
Unity.MLAgents.Policies.HeuristicPolicy:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Policies/HeuristicPolicy.cs:49)
Unity.MLAgents.Agent:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1360)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:578)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=yellow>HEURISTIC CALLED #10:</color> Action=56 (Grid:7,0 Rot:0°)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:275)
Unity.MLAgents.Actuators.VectorActuator:Heuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:83)
Unity.MLAgents.Actuators.VectorActuator:Unity.MLAgents.Actuators.IHeuristicProvider.Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&)
Unity.MLAgents.Actuators.ActuatorManager:ApplyHeuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:250)
Unity.MLAgents.Policies.HeuristicPolicy:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Policies/HeuristicPolicy.cs:49)
Unity.MLAgents.Agent:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1360)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:578)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=yellow>HEURISTIC CALLED #11:</color> Action=63 (Grid:7,7 Rot:0°)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:275)
Unity.MLAgents.Actuators.VectorActuator:Heuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:83)
Unity.MLAgents.Actuators.VectorActuator:Unity.MLAgents.Actuators.IHeuristicProvider.Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&)
Unity.MLAgents.Actuators.ActuatorManager:ApplyHeuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:250)
Unity.MLAgents.Policies.HeuristicPolicy:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Policies/HeuristicPolicy.cs:49)
Unity.MLAgents.Agent:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1360)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:578)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=yellow>HEURISTIC CALLED #12:</color> Action=7 (Grid:0,7 Rot:0°)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:275)
Unity.MLAgents.Actuators.VectorActuator:Heuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:83)
Unity.MLAgents.Actuators.VectorActuator:Unity.MLAgents.Actuators.IHeuristicProvider.Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&)
Unity.MLAgents.Actuators.ActuatorManager:ApplyHeuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:250)
Unity.MLAgents.Policies.HeuristicPolicy:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Policies/HeuristicPolicy.cs:49)
Unity.MLAgents.Agent:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1360)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:578)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=yellow>HEURISTIC CALLED #13:</color> Action=0 (Grid:0,0 Rot:0°)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:275)
Unity.MLAgents.Actuators.VectorActuator:Heuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:83)
Unity.MLAgents.Actuators.VectorActuator:Unity.MLAgents.Actuators.IHeuristicProvider.Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&)
Unity.MLAgents.Actuators.ActuatorManager:ApplyHeuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:250)
Unity.MLAgents.Policies.HeuristicPolicy:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Policies/HeuristicPolicy.cs:49)
Unity.MLAgents.Agent:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1360)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:578)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=yellow>HEURISTIC CALLED #14:</color> Action=56 (Grid:7,0 Rot:0°)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:275)
Unity.MLAgents.Actuators.VectorActuator:Heuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:83)
Unity.MLAgents.Actuators.VectorActuator:Unity.MLAgents.Actuators.IHeuristicProvider.Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&)
Unity.MLAgents.Actuators.ActuatorManager:ApplyHeuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:250)
Unity.MLAgents.Policies.HeuristicPolicy:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Policies/HeuristicPolicy.cs:49)
Unity.MLAgents.Agent:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1360)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:578)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=yellow>HEURISTIC CALLED #15:</color> Action=63 (Grid:7,7 Rot:0°)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:275)
Unity.MLAgents.Actuators.VectorActuator:Heuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:83)
Unity.MLAgents.Actuators.VectorActuator:Unity.MLAgents.Actuators.IHeuristicProvider.Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&)
Unity.MLAgents.Actuators.ActuatorManager:ApplyHeuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:250)
Unity.MLAgents.Policies.HeuristicPolicy:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Policies/HeuristicPolicy.cs:49)
Unity.MLAgents.Agent:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1360)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:578)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=yellow>HEURISTIC CALLED #16:</color> Action=7 (Grid:0,7 Rot:0°)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:275)
Unity.MLAgents.Actuators.VectorActuator:Heuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:83)
Unity.MLAgents.Actuators.VectorActuator:Unity.MLAgents.Actuators.IHeuristicProvider.Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&)
Unity.MLAgents.Actuators.ActuatorManager:ApplyHeuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:250)
Unity.MLAgents.Policies.HeuristicPolicy:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Policies/HeuristicPolicy.cs:49)
Unity.MLAgents.Agent:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1360)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:578)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=yellow>HEURISTIC CALLED #17:</color> Action=0 (Grid:0,0 Rot:0°)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:275)
Unity.MLAgents.Actuators.VectorActuator:Heuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:83)
Unity.MLAgents.Actuators.VectorActuator:Unity.MLAgents.Actuators.IHeuristicProvider.Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&)
Unity.MLAgents.Actuators.ActuatorManager:ApplyHeuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:250)
Unity.MLAgents.Policies.HeuristicPolicy:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Policies/HeuristicPolicy.cs:49)
Unity.MLAgents.Agent:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1360)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:578)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=yellow>HEURISTIC CALLED #18:</color> Action=7 (Grid:0,7 Rot:0°)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:275)
Unity.MLAgents.Actuators.VectorActuator:Heuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:83)
Unity.MLAgents.Actuators.VectorActuator:Unity.MLAgents.Actuators.IHeuristicProvider.Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&)
Unity.MLAgents.Actuators.ActuatorManager:ApplyHeuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:250)
Unity.MLAgents.Policies.HeuristicPolicy:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Policies/HeuristicPolicy.cs:49)
Unity.MLAgents.Agent:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1360)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:578)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=yellow>HEURISTIC CALLED #19:</color> Action=63 (Grid:7,7 Rot:0°)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:275)
Unity.MLAgents.Actuators.VectorActuator:Heuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:83)
Unity.MLAgents.Actuators.VectorActuator:Unity.MLAgents.Actuators.IHeuristicProvider.Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&)
Unity.MLAgents.Actuators.ActuatorManager:ApplyHeuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:250)
Unity.MLAgents.Policies.HeuristicPolicy:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Policies/HeuristicPolicy.cs:49)
Unity.MLAgents.Agent:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1360)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:578)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=yellow>HEURISTIC CALLED #20:</color> Action=56 (Grid:7,0 Rot:0°)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:275)
Unity.MLAgents.Actuators.VectorActuator:Heuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:83)
Unity.MLAgents.Actuators.VectorActuator:Unity.MLAgents.Actuators.IHeuristicProvider.Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&)
Unity.MLAgents.Actuators.ActuatorManager:ApplyHeuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:250)
Unity.MLAgents.Policies.HeuristicPolicy:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Policies/HeuristicPolicy.cs:49)
Unity.MLAgents.Agent:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1360)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:578)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=yellow>HEURISTIC CALLED #21:</color> Action=0 (Grid:0,0 Rot:0°)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:275)
Unity.MLAgents.Actuators.VectorActuator:Heuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:83)
Unity.MLAgents.Actuators.VectorActuator:Unity.MLAgents.Actuators.IHeuristicProvider.Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&)
Unity.MLAgents.Actuators.ActuatorManager:ApplyHeuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:250)
Unity.MLAgents.Policies.HeuristicPolicy:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Policies/HeuristicPolicy.cs:49)
Unity.MLAgents.Agent:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1360)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:578)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=yellow>HEURISTIC CALLED #22:</color> Action=36 (Grid:4,4 Rot:0°)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:275)
Unity.MLAgents.Actuators.VectorActuator:Heuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:83)
Unity.MLAgents.Actuators.VectorActuator:Unity.MLAgents.Actuators.IHeuristicProvider.Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&)
Unity.MLAgents.Actuators.ActuatorManager:ApplyHeuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:250)
Unity.MLAgents.Policies.HeuristicPolicy:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Policies/HeuristicPolicy.cs:49)
Unity.MLAgents.Agent:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1360)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:578)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=yellow>HEURISTIC CALLED #23:</color> Action=63 (Grid:7,7 Rot:0°)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:275)
Unity.MLAgents.Actuators.VectorActuator:Heuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:83)
Unity.MLAgents.Actuators.VectorActuator:Unity.MLAgents.Actuators.IHeuristicProvider.Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&)
Unity.MLAgents.Actuators.ActuatorManager:ApplyHeuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:250)
Unity.MLAgents.Policies.HeuristicPolicy:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Policies/HeuristicPolicy.cs:49)
Unity.MLAgents.Agent:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1360)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:578)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=yellow>HEURISTIC CALLED #24:</color> Action=56 (Grid:7,0 Rot:0°)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:275)
Unity.MLAgents.Actuators.VectorActuator:Heuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:83)
Unity.MLAgents.Actuators.VectorActuator:Unity.MLAgents.Actuators.IHeuristicProvider.Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&)
Unity.MLAgents.Actuators.ActuatorManager:ApplyHeuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:250)
Unity.MLAgents.Policies.HeuristicPolicy:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Policies/HeuristicPolicy.cs:49)
Unity.MLAgents.Agent:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1360)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:578)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=yellow>HEURISTIC CALLED #25:</color> Action=0 (Grid:0,0 Rot:0°)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:275)
Unity.MLAgents.Actuators.VectorActuator:Heuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:83)
Unity.MLAgents.Actuators.VectorActuator:Unity.MLAgents.Actuators.IHeuristicProvider.Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&)
Unity.MLAgents.Actuators.ActuatorManager:ApplyHeuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:250)
Unity.MLAgents.Policies.HeuristicPolicy:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Policies/HeuristicPolicy.cs:49)
Unity.MLAgents.Agent:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1360)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:578)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=yellow>HEURISTIC CALLED #26:</color> Action=0 (Grid:0,0 Rot:0°)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:275)
Unity.MLAgents.Actuators.VectorActuator:Heuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:83)
Unity.MLAgents.Actuators.VectorActuator:Unity.MLAgents.Actuators.IHeuristicProvider.Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&)
Unity.MLAgents.Actuators.ActuatorManager:ApplyHeuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:250)
Unity.MLAgents.Policies.HeuristicPolicy:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Policies/HeuristicPolicy.cs:49)
Unity.MLAgents.Agent:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1360)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:578)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=yellow>HEURISTIC CALLED #27:</color> Action=0 (Grid:0,0 Rot:0°)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:275)
Unity.MLAgents.Actuators.VectorActuator:Heuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:83)
Unity.MLAgents.Actuators.VectorActuator:Unity.MLAgents.Actuators.IHeuristicProvider.Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&)
Unity.MLAgents.Actuators.ActuatorManager:ApplyHeuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:250)
Unity.MLAgents.Policies.HeuristicPolicy:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Policies/HeuristicPolicy.cs:49)
Unity.MLAgents.Agent:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1360)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:578)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=yellow>HEURISTIC CALLED #28:</color> Action=7 (Grid:0,7 Rot:0°)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:275)
Unity.MLAgents.Actuators.VectorActuator:Heuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:83)
Unity.MLAgents.Actuators.VectorActuator:Unity.MLAgents.Actuators.IHeuristicProvider.Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&)
Unity.MLAgents.Actuators.ActuatorManager:ApplyHeuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:250)
Unity.MLAgents.Policies.HeuristicPolicy:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Policies/HeuristicPolicy.cs:49)
Unity.MLAgents.Agent:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1360)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:578)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=yellow>HEURISTIC CALLED #29:</color> Action=7 (Grid:0,7 Rot:0°)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:275)
Unity.MLAgents.Actuators.VectorActuator:Heuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:83)
Unity.MLAgents.Actuators.VectorActuator:Unity.MLAgents.Actuators.IHeuristicProvider.Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&)
Unity.MLAgents.Actuators.ActuatorManager:ApplyHeuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:250)
Unity.MLAgents.Policies.HeuristicPolicy:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Policies/HeuristicPolicy.cs:49)
Unity.MLAgents.Agent:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1360)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:578)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=yellow>HEURISTIC CALLED #30:</color> Action=63 (Grid:7,7 Rot:0°)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:275)
Unity.MLAgents.Actuators.VectorActuator:Heuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:83)
Unity.MLAgents.Actuators.VectorActuator:Unity.MLAgents.Actuators.IHeuristicProvider.Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&)
Unity.MLAgents.Actuators.ActuatorManager:ApplyHeuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:250)
Unity.MLAgents.Policies.HeuristicPolicy:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Policies/HeuristicPolicy.cs:49)
Unity.MLAgents.Agent:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1360)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:578)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=yellow>HEURISTIC CALLED #31:</color> Action=63 (Grid:7,7 Rot:0°)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:275)
Unity.MLAgents.Actuators.VectorActuator:Heuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:83)
Unity.MLAgents.Actuators.VectorActuator:Unity.MLAgents.Actuators.IHeuristicProvider.Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&)
Unity.MLAgents.Actuators.ActuatorManager:ApplyHeuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:250)
Unity.MLAgents.Policies.HeuristicPolicy:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Policies/HeuristicPolicy.cs:49)
Unity.MLAgents.Agent:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1360)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:578)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=yellow>HEURISTIC CALLED #32:</color> Action=56 (Grid:7,0 Rot:0°)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:275)
Unity.MLAgents.Actuators.VectorActuator:Heuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:83)
Unity.MLAgents.Actuators.VectorActuator:Unity.MLAgents.Actuators.IHeuristicProvider.Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&)
Unity.MLAgents.Actuators.ActuatorManager:ApplyHeuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:250)
Unity.MLAgents.Policies.HeuristicPolicy:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Policies/HeuristicPolicy.cs:49)
Unity.MLAgents.Agent:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1360)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:578)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=yellow>HEURISTIC CALLED #33:</color> Action=36 (Grid:4,4 Rot:0°)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:275)
Unity.MLAgents.Actuators.VectorActuator:Heuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:83)
Unity.MLAgents.Actuators.VectorActuator:Unity.MLAgents.Actuators.IHeuristicProvider.Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&)
Unity.MLAgents.Actuators.ActuatorManager:ApplyHeuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:250)
Unity.MLAgents.Policies.HeuristicPolicy:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Policies/HeuristicPolicy.cs:49)
Unity.MLAgents.Agent:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1360)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:578)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=yellow>HEURISTIC CALLED #34:</color> Action=56 (Grid:7,0 Rot:0°)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:275)
Unity.MLAgents.Actuators.VectorActuator:Heuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:83)
Unity.MLAgents.Actuators.VectorActuator:Unity.MLAgents.Actuators.IHeuristicProvider.Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&)
Unity.MLAgents.Actuators.ActuatorManager:ApplyHeuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:250)
Unity.MLAgents.Policies.HeuristicPolicy:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Policies/HeuristicPolicy.cs:49)
Unity.MLAgents.Agent:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1360)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:578)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=yellow>HEURISTIC CALLED #35:</color> Action=63 (Grid:7,7 Rot:0°)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:275)
Unity.MLAgents.Actuators.VectorActuator:Heuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:83)
Unity.MLAgents.Actuators.VectorActuator:Unity.MLAgents.Actuators.IHeuristicProvider.Heuristic (Unity.MLAgents.Actuators.ActionBuffers modreq(System.Runtime.InteropServices.InAttribute)&)
Unity.MLAgents.Actuators.ActuatorManager:ApplyHeuristic (Unity.MLAgents.Actuators.ActionBuffers&) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:250)
Unity.MLAgents.Policies.HeuristicPolicy:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Policies/HeuristicPolicy.cs:49)
Unity.MLAgents.Agent:DecideAction () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1360)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:578)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

**********************************************************************************
**********************************************************************************

**********************************************************************************
**********************************************************************************

**********************************************************************************
**********************************************************************************

**********************************************************************************
**********************************************************************************

**********************************************************************************
**********************************************************************************

**********************************************************************************
**********************************************************************************

**********************************************************************************
**********************************************************************************

**********************************************************************************
**********************************************************************************








______________________________________________________________________________________________________________________________________________________________________________________________________________________
First Run - New Python Env : mlagentRec - 
______________________________________________________________________________________________________________________________________________________________________________________________________________________
[KeyboardController] Found IInputMapper: BinPackingInputMapper
UnityEngine.Debug:Log (object)
LearningPipeline.Imitation.KeyboardController:Awake () (at Assets/LearningPipeline/Imitation/KeyboardController.cs:53)

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
LearningPipeline.Imitation.KeyboardController:DisplayControls () (at Assets/LearningPipeline/Imitation/KeyboardController.cs:175)
LearningPipeline.Imitation.KeyboardController:Start () (at Assets/LearningPipeline/Imitation/KeyboardController.cs:78)

Toggle Recording: D
UnityEngine.Debug:Log (object)
LearningPipeline.Imitation.KeyboardController:DisplayControls () (at Assets/LearningPipeline/Imitation/KeyboardController.cs:176)
LearningPipeline.Imitation.KeyboardController:Start () (at Assets/LearningPipeline/Imitation/KeyboardController.cs:78)

Cancel Episode: Escape
UnityEngine.Debug:Log (object)
LearningPipeline.Imitation.KeyboardController:DisplayControls () (at Assets/LearningPipeline/Imitation/KeyboardController.cs:177)
LearningPipeline.Imitation.KeyboardController:Start () (at Assets/LearningPipeline/Imitation/KeyboardController.cs:78)

Current Input State: Grid: (4, 4) | World: (55.7, 55.7) | Rotation: 0° | [SPACE] to place
UnityEngine.Debug:Log (object)
LearningPipeline.Imitation.KeyboardController:DisplayControls () (at Assets/LearningPipeline/Imitation/KeyboardController.cs:180)
LearningPipeline.Imitation.KeyboardController:Start () (at Assets/LearningPipeline/Imitation/KeyboardController.cs:78)

=================================
UnityEngine.Debug:Log (object)
LearningPipeline.Imitation.KeyboardController:DisplayControls () (at Assets/LearningPipeline/Imitation/KeyboardController.cs:182)
LearningPipeline.Imitation.KeyboardController:Start () (at Assets/LearningPipeline/Imitation/KeyboardController.cs:78)

Box 1/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:ResetAgent () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:72)
LearningPipeline.Core.LearningAgent:OnEpisodeBegin () (at Assets/LearningPipeline/Core/LearningAgent.cs:49)
Unity.MLAgents.Agent:_AgentReset () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1299)
Unity.MLAgents.Academy:ForcedFullReset () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:548)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:562)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=green>[RECORDING STARTED]</color> Press D to stop
UnityEngine.Debug:Log (object)
LearningPipeline.Imitation.KeyboardController:ToggleRecording () (at Assets/LearningPipeline/Imitation/KeyboardController.cs:157)
LearningPipeline.Imitation.KeyboardController:Update () (at Assets/LearningPipeline/Imitation/KeyboardController.cs:88)

<color=cyan>ACTION CONFIRMED:</color> Grid(7,0) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 1 occupied!</color> (1/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 2/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(7,7) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 3 occupied!</color> (2/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 3/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(0,7) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 2 occupied!</color> (3/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 4/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(0,0) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 0 occupied!</color> (4/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=green>EPISODE COMPLETE!</color> Boxes: 4, Corners: 4, Reward: 100
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:146)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 1/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:ResetAgent () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:72)
LearningPipeline.Core.LearningAgent:OnEpisodeBegin () (at Assets/LearningPipeline/Core/LearningAgent.cs:49)
Unity.MLAgents.Agent:_AgentReset () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1299)
Unity.MLAgents.Agent:EndEpisodeAndReset (Unity.MLAgents.Agent/DoneReason) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:798)
Unity.MLAgents.Agent:EndEpisode () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:772)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:147)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(0,0) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 0 occupied!</color> (1/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 2/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(0,7) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 2 occupied!</color> (2/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 3/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(7,7) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 3 occupied!</color> (3/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 4/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(7,0) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 1 occupied!</color> (4/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=green>EPISODE COMPLETE!</color> Boxes: 4, Corners: 4, Reward: 100
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:146)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 1/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:ResetAgent () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:72)
LearningPipeline.Core.LearningAgent:OnEpisodeBegin () (at Assets/LearningPipeline/Core/LearningAgent.cs:49)
Unity.MLAgents.Agent:_AgentReset () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1299)
Unity.MLAgents.Agent:EndEpisodeAndReset (Unity.MLAgents.Agent/DoneReason) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:798)
Unity.MLAgents.Agent:EndEpisode () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:772)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:147)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(0,0) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 0 occupied!</color> (1/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 2/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(0,7) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 2 occupied!</color> (2/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 3/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(7,7) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 3 occupied!</color> (3/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 4/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(7,0) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 1 occupied!</color> (4/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=green>EPISODE COMPLETE!</color> Boxes: 4, Corners: 4, Reward: 100
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:146)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 1/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:ResetAgent () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:72)
LearningPipeline.Core.LearningAgent:OnEpisodeBegin () (at Assets/LearningPipeline/Core/LearningAgent.cs:49)
Unity.MLAgents.Agent:_AgentReset () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1299)
Unity.MLAgents.Agent:EndEpisodeAndReset (Unity.MLAgents.Agent/DoneReason) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:798)
Unity.MLAgents.Agent:EndEpisode () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:772)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:147)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(7,0) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 1 occupied!</color> (1/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 2/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(7,7) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 3 occupied!</color> (2/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 3/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(0,7) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 2 occupied!</color> (3/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 4/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(0,0) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 0 occupied!</color> (4/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=green>EPISODE COMPLETE!</color> Boxes: 4, Corners: 4, Reward: 100
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:146)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 1/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:ResetAgent () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:72)
LearningPipeline.Core.LearningAgent:OnEpisodeBegin () (at Assets/LearningPipeline/Core/LearningAgent.cs:49)
Unity.MLAgents.Agent:_AgentReset () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1299)
Unity.MLAgents.Agent:EndEpisodeAndReset (Unity.MLAgents.Agent/DoneReason) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:798)
Unity.MLAgents.Agent:EndEpisode () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:772)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:147)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(0,7) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 2 occupied!</color> (1/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 2/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(0,0) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 0 occupied!</color> (2/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 3/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(7,0) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 1 occupied!</color> (3/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 4/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(7,7) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 3 occupied!</color> (4/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=green>EPISODE COMPLETE!</color> Boxes: 4, Corners: 4, Reward: 100
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:146)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 1/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:ResetAgent () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:72)
LearningPipeline.Core.LearningAgent:OnEpisodeBegin () (at Assets/LearningPipeline/Core/LearningAgent.cs:49)
Unity.MLAgents.Agent:_AgentReset () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1299)
Unity.MLAgents.Agent:EndEpisodeAndReset (Unity.MLAgents.Agent/DoneReason) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:798)
Unity.MLAgents.Agent:EndEpisode () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:772)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:147)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(7,7) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 3 occupied!</color> (1/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 2/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(0,7) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 2 occupied!</color> (2/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 3/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(0,0) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 0 occupied!</color> (3/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 4/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(7,0) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 1 occupied!</color> (4/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=green>EPISODE COMPLETE!</color> Boxes: 4, Corners: 4, Reward: 100
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:146)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 1/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:ResetAgent () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:72)
LearningPipeline.Core.LearningAgent:OnEpisodeBegin () (at Assets/LearningPipeline/Core/LearningAgent.cs:49)
Unity.MLAgents.Agent:_AgentReset () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1299)
Unity.MLAgents.Agent:EndEpisodeAndReset (Unity.MLAgents.Agent/DoneReason) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:798)
Unity.MLAgents.Agent:EndEpisode () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:772)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:147)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(7,0) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 1 occupied!</color> (1/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 2/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(0,0) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 0 occupied!</color> (2/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 3/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(0,7) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 2 occupied!</color> (3/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 4/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(7,7) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 3 occupied!</color> (4/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=green>EPISODE COMPLETE!</color> Boxes: 4, Corners: 4, Reward: 100
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:146)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 1/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:ResetAgent () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:72)
LearningPipeline.Core.LearningAgent:OnEpisodeBegin () (at Assets/LearningPipeline/Core/LearningAgent.cs:49)
Unity.MLAgents.Agent:_AgentReset () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1299)
Unity.MLAgents.Agent:EndEpisodeAndReset (Unity.MLAgents.Agent/DoneReason) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:798)
Unity.MLAgents.Agent:EndEpisode () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:772)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:147)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(7,7) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 3 occupied!</color> (1/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 2/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(0,0) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 0 occupied!</color> (2/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 3/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(0,7) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 2 occupied!</color> (3/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 4/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(7,0) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 1 occupied!</color> (4/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=green>EPISODE COMPLETE!</color> Boxes: 4, Corners: 4, Reward: 100
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:146)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 1/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:ResetAgent () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:72)
LearningPipeline.Core.LearningAgent:OnEpisodeBegin () (at Assets/LearningPipeline/Core/LearningAgent.cs:49)
Unity.MLAgents.Agent:_AgentReset () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1299)
Unity.MLAgents.Agent:EndEpisodeAndReset (Unity.MLAgents.Agent/DoneReason) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:798)
Unity.MLAgents.Agent:EndEpisode () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:772)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:147)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(7,0) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 1 occupied!</color> (1/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 2/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(7,7) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 3 occupied!</color> (2/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 3/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(0,7) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 2 occupied!</color> (3/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 4/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(0,0) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 0 occupied!</color> (4/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=green>EPISODE COMPLETE!</color> Boxes: 4, Corners: 4, Reward: 100
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:146)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 1/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:ResetAgent () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:72)
LearningPipeline.Core.LearningAgent:OnEpisodeBegin () (at Assets/LearningPipeline/Core/LearningAgent.cs:49)
Unity.MLAgents.Agent:_AgentReset () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1299)
Unity.MLAgents.Agent:EndEpisodeAndReset (Unity.MLAgents.Agent/DoneReason) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:798)
Unity.MLAgents.Agent:EndEpisode () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:772)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:147)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(0,7) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 2 occupied!</color> (1/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 2/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(7,7) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 3 occupied!</color> (2/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 3/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(7,0) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 1 occupied!</color> (3/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 4/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(0,0) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 0 occupied!</color> (4/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=green>EPISODE COMPLETE!</color> Boxes: 4, Corners: 4, Reward: 100
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:146)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 1/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:ResetAgent () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:72)
LearningPipeline.Core.LearningAgent:OnEpisodeBegin () (at Assets/LearningPipeline/Core/LearningAgent.cs:49)
Unity.MLAgents.Agent:_AgentReset () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1299)
Unity.MLAgents.Agent:EndEpisodeAndReset (Unity.MLAgents.Agent/DoneReason) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:798)
Unity.MLAgents.Agent:EndEpisode () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:772)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:147)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(0,0) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 0 occupied!</color> (1/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 2/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(7,0) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 1 occupied!</color> (2/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 3/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(7,7) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 3 occupied!</color> (3/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 4/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(0,7) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 2 occupied!</color> (4/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=green>EPISODE COMPLETE!</color> Boxes: 4, Corners: 4, Reward: 100
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:146)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 1/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:ResetAgent () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:72)
LearningPipeline.Core.LearningAgent:OnEpisodeBegin () (at Assets/LearningPipeline/Core/LearningAgent.cs:49)
Unity.MLAgents.Agent:_AgentReset () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1299)
Unity.MLAgents.Agent:EndEpisodeAndReset (Unity.MLAgents.Agent/DoneReason) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:798)
Unity.MLAgents.Agent:EndEpisode () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:772)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:147)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(0,7) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 2 occupied!</color> (1/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 2/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(0,0) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 0 occupied!</color> (2/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 3/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(7,0) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 1 occupied!</color> (3/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 4/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(7,7) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 3 occupied!</color> (4/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=green>EPISODE COMPLETE!</color> Boxes: 4, Corners: 4, Reward: 100
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:146)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 1/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:ResetAgent () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:72)
LearningPipeline.Core.LearningAgent:OnEpisodeBegin () (at Assets/LearningPipeline/Core/LearningAgent.cs:49)
Unity.MLAgents.Agent:_AgentReset () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1299)
Unity.MLAgents.Agent:EndEpisodeAndReset (Unity.MLAgents.Agent/DoneReason) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:798)
Unity.MLAgents.Agent:EndEpisode () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:772)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:147)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(7,7) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 3 occupied!</color> (1/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 2/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(7,0) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 1 occupied!</color> (2/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 3/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(0,0) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 0 occupied!</color> (3/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 4/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(0,7) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 2 occupied!</color> (4/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=green>EPISODE COMPLETE!</color> Boxes: 4, Corners: 4, Reward: 100
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:146)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 1/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:ResetAgent () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:72)
LearningPipeline.Core.LearningAgent:OnEpisodeBegin () (at Assets/LearningPipeline/Core/LearningAgent.cs:49)
Unity.MLAgents.Agent:_AgentReset () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1299)
Unity.MLAgents.Agent:EndEpisodeAndReset (Unity.MLAgents.Agent/DoneReason) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:798)
Unity.MLAgents.Agent:EndEpisode () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:772)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:147)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(0,7) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 2 occupied!</color> (1/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 2/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(0,0) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 0 occupied!</color> (2/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 3/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(7,0) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 1 occupied!</color> (3/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 4/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(7,7) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 3 occupied!</color> (4/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=green>EPISODE COMPLETE!</color> Boxes: 4, Corners: 4, Reward: 100
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:146)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 1/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:ResetAgent () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:72)
LearningPipeline.Core.LearningAgent:OnEpisodeBegin () (at Assets/LearningPipeline/Core/LearningAgent.cs:49)
Unity.MLAgents.Agent:_AgentReset () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1299)
Unity.MLAgents.Agent:EndEpisodeAndReset (Unity.MLAgents.Agent/DoneReason) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:798)
Unity.MLAgents.Agent:EndEpisode () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:772)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:147)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(7,7) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 3 occupied!</color> (1/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 2/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(7,0) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 1 occupied!</color> (2/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 3/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(0,7) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 2 occupied!</color> (3/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 4/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(0,0) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 0 occupied!</color> (4/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=green>EPISODE COMPLETE!</color> Boxes: 4, Corners: 4, Reward: 100
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:146)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 1/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:ResetAgent () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:72)
LearningPipeline.Core.LearningAgent:OnEpisodeBegin () (at Assets/LearningPipeline/Core/LearningAgent.cs:49)
Unity.MLAgents.Agent:_AgentReset () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1299)
Unity.MLAgents.Agent:EndEpisodeAndReset (Unity.MLAgents.Agent/DoneReason) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:798)
Unity.MLAgents.Agent:EndEpisode () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:772)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:147)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(0,0) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 0 occupied!</color> (1/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 2/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(7,0) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 1 occupied!</color> (2/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 3/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(7,7) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 3 occupied!</color> (3/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 4/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:152)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=cyan>ACTION CONFIRMED:</color> Grid(0,7) Rot=0°
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Configs.BinPackingInputMapper:Update () (at Assets/Tasks/3DBPP/Configs/BinPackingInputMapper.cs:60)

<color=green>Corner 2 occupied!</color> (4/4)
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Curriculum.CornerPlacementTask:EvaluatePlacement (UnityEngine.Vector3) (at Assets/Tasks/3DBPP/Curriculum/CornerPlacementTask.cs:93)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:132)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=green>EPISODE COMPLETE!</color> Boxes: 4, Corners: 4, Reward: 100
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:146)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

Box 1/4 ready
UnityEngine.Debug:Log (object)
Tasks._3DBPP.Agents.CornerPlacementAgent:SpawnNextBox () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:193)
Tasks._3DBPP.Agents.CornerPlacementAgent:ResetAgent () (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:72)
LearningPipeline.Core.LearningAgent:OnEpisodeBegin () (at Assets/LearningPipeline/Core/LearningAgent.cs:49)
Unity.MLAgents.Agent:_AgentReset () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1299)
Unity.MLAgents.Agent:EndEpisodeAndReset (Unity.MLAgents.Agent/DoneReason) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:798)
Unity.MLAgents.Agent:EndEpisode () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:772)
Tasks._3DBPP.Agents.CornerPlacementAgent:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Assets/Tasks/3DBPP/Agents/CornerPlacementAgent.cs:147)
Unity.MLAgents.Actuators.VectorActuator:OnActionReceived (Unity.MLAgents.Actuators.ActionBuffers) (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/VectorActuator.cs:76)
Unity.MLAgents.Actuators.ActuatorManager:ExecuteActions () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Actuators/ActuatorManager.cs:295)
Unity.MLAgents.Agent:AgentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Agent.cs:1344)
Unity.MLAgents.Academy:EnvironmentStep () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:589)
Unity.MLAgents.AcademyFixedUpdateStepper:FixedUpdate () (at Library/PackageCache/com.unity.ml-agents@2.0.2/Runtime/Academy.cs:43)

<color=yellow>[RECORDING STOPPED]</color> 0 actions recorded
UnityEngine.Debug:Log (object)
LearningPipeline.Imitation.KeyboardController:ToggleRecording () (at Assets/LearningPipeline/Imitation/KeyboardController.cs:162)
LearningPipeline.Imitation.KeyboardController:Update () (at Assets/LearningPipeline/Imitation/KeyboardController.cs:88)

An infinite import loop has been detected. The following Assets were imported multiple times, but no changes to them have been detected. Please check if any custom code is trying to import them:
Assets/Tasks/3DBPP/Demonstrations/CPAmlREC.demo(modified date 2025-12-05T00:00:58.1132908Z)
Assets/ML-Agents/Timers/DemoRecordingTest_BoxCorners_01_timers.json(modified date 2025-12-04T23:59:50.8026731Z)


______________________________