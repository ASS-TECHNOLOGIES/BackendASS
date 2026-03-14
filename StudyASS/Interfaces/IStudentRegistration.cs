namespace StudyASS.Interfaces
{
    /// <summary>
    /// Interface for student's study session registration.
    /// </summary>
    public interface IStudentRegistration
    {
        #region Public Properties

        /// <summary>
        /// Student's email who has registered for a session.
        /// </summary>
        string StudentEmail { get; }

        /// <summary>
        /// Collection of module names for focus of study session.
        /// </summary>
        IEnumerable<string> Modules { get; }

        #endregion
    }
}
