namespace StudyASS.Interfaces
{
    /// <summary>
    /// Interface for student's session registration.
    /// </summary>
    public interface IRegistration
    {
        #region Public Properties

        /// <summary>
        /// Student who has registered for a session.
        /// </summary>
        IStudent Student { get; }

        /// <summary>
        /// Module focus of session beign registered for.
        /// </summary>
        string Module { get; }

        #endregion
    }
}
