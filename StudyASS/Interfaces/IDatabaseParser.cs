namespace StudyASS.Interfaces
{
    /// <summary>
    /// Interface for database parser.
    /// </summary>
    public interface IDatabaseParser
    {
        #region Public Methods

        /// <summary>
        /// Gets list of study sessions from database.
        /// </summary>
        /// <returns>
        /// Collection of <c>IStudySession</c>.
        /// </returns>
        IEnumerable<IStudySession> GetStudySessions();

        /// <summary>
        /// Gets list of student registrations.
        /// </summary>
        /// <returns>
        /// Collection of <c>IStudySession</c>.
        /// </returns>
        IEnumerable<IRegistration> GetRegistrations();

        /// <summary>
        /// Gets list of study sessions from database.
        /// </summary>
        /// <param name="studentEmail">
        /// Student email to filter study sessions with.
        /// </param>
        /// <returns>
        /// Collection of <c>IStudySession</c>.
        /// </returns>
        IEnumerable<IStudySession> GetStudySessions(string studentEmail);

        /// <summary>
        /// Adds registration to database.
        /// </summary>
        /// <param name="registration">
        /// Instance of <c>IRegistration</c>.
        /// </param>
        void AddRegistration(IStudentRegistration registration);

        #endregion
    }
}
