namespace StudyASS.Interfaces
{
    /// <summary>
    /// Provides interface for session students can attend.
    /// </summary>
    public interface ISession
    {
        #region Public Properties

        /// <summary>
        /// Date and time of session.
        /// </summary>
        DateTime DateTime { get; }

        /// <summary>
        /// Location of session.
        /// </summary>
        string Location { get; }

        /// <summary>
        /// Student attendees of session.
        /// </summary>
        List<IStudent> Attendees { get; }

        /// <summary>
        /// Module focus of session.
        /// I.e. CO3404 Distributed Systems
        /// </summary>
        string Module { get; }

        /// <summary>
        /// Topic of session, relating to Module.
        /// </summary>
        string ModuleTopic { get; }

        #endregion
    }
}
