namespace StudyASS.Interfaces
{
    /// <summary>
    /// Interface for database parser.
    /// </summary>
    public interface IDatabaseParser
    {
        #region Public Methods

        /// <summary>
        /// Gets list of students from database.
        /// </summary>
        /// <returns>
        /// Collection of <c>IStudent</c>.
        /// </returns>
        List<IStudent> GetStudents();

        /// <summary>
        /// Gets list of arranged sessions from database.
        /// </summary>
        /// <returns>
        /// Collection of <c>ISession</c>.
        /// </returns>
        List<ISession> GetSessions();

        /// <summary>
        /// Gets list of student registrations for sessions from database.
        /// </summary>
        /// <returns>
        /// Collection of <c>IRegistration</c>.
        /// </returns>
        List<IRegistration> GetRegistrations();

        /// <summary>
        /// Adds student to database.
        /// </summary>
        /// <param name="student">
        /// Instance of <c>IStudent</c>.
        /// </param>
        void AddStudents(IStudent student);

        /// <summary>
        /// Adds session to database.
        /// </summary>
        /// <param name="session">
        /// Instance of <c>ISession</c>.
        /// </param>
        void AddSession(ISession session);

        /// <summary>
        /// Adds registration to database.
        /// </summary>
        /// <param name="registration">
        /// Instance of <c>IRegistration</c>.
        /// </param>
        void AddRegistration(IRegistration registration);

        /// <summary>
        /// Removes registration from database.
        /// </summary>
        /// <param name="registration">
        /// Instance of <c>IRegistration</c>.
        /// </param>
        void RemoveRegistration(IRegistration registration);

        #endregion
    }
}
