namespace StudyASS.Interfaces
{
    /// <summary>
    /// Interface for factory of <c>IStudySession</c> objects.
    /// </summary>
    public interface IStudySessionFactory
    {
        /// <summary>
        /// Creates study session.
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
        /// <returns>
        /// <c>IStudySession</c> object.
        /// </returns>
        IStudySession CreateStudySession(DateTime dateTime, string module, string topic);
    }
}
