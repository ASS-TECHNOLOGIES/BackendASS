namespace StudyASS.Interfaces
{
    /// <summary>
    /// Interface for builder class for <c>IStudySession</c>.
    /// </summary>
    public interface IStudySessionBuilder
    {
        /// <summary>
        /// Clears objects built so far in memory.
        /// </summary>
        void Clear();

        /// <summary>
        /// Method adds arguments to a study session.
        /// </summary>
        /// <param name="dateTime">
        /// Date and time of study session.
        /// </param>
        /// <param name="module">
        /// Module focus of study session.
        /// </param>
        /// <param name="topic">
        /// Topic focus of study session.
        /// </param>
        /// <param name="student">
        /// Reference to student attending study session.
        /// </param>
        void Add(DateTime dateTime, string module, string topic, IStudent student);
        
        /// <summary>
        /// Returns all study sessions built.
        /// </summary>
        /// <returns>
        /// Collection of <c>IStudySessions</c>.
        /// </returns>
        IEnumerable<IStudySession> GetSessions();
    }
}
