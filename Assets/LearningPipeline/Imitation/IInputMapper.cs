using Unity.MLAgents.Actuators;

namespace LearningPipeline.Imitation
{
    /// <summary>
    /// Interface for mapping keyboard/gamepad input to ML-Agents actions.
    /// Each task implements this to define custom controls for demonstration recording.
    ///
    /// Example for 3DBPP:
    /// - Arrow keys → Grid position selection
    /// - R key → Rotate box
    /// - Space → Place box
    /// </summary>
    public interface IInputMapper
    {
        /// <summary>
        /// Map current input state to ML-Agents action buffers
        /// Called every frame during demonstration recording
        /// </summary>
        /// <returns>ActionBuffers containing discrete and/or continuous actions</returns>
        ActionBuffers MapInput();

        /// <summary>
        /// Display on-screen hints showing available controls
        /// Optional: Can show UI overlay with keyboard shortcuts
        /// </summary>
        void DisplayInputHints();

        /// <summary>
        /// Check if user pressed "confirm action" button (e.g., Space, Enter)
        /// Used to know when to actually record an action
        /// </summary>
        /// <returns>True if action should be recorded this frame</returns>
        bool IsActionConfirmed();

        /// <summary>
        /// Reset input state (clear selections, return to defaults)
        /// </summary>
        void ResetInput();

        /// <summary>
        /// Get current input state as human-readable string for debugging
        /// Example: "Grid(3,4) Rotation=90°"
        /// </summary>
        /// <returns>Debug string showing current input selections</returns>
        string GetInputStateString();
    }
}
