namespace StudyASS.Interfaces
{
    /// <summary>
    /// Interface for Student.
    /// </summary>
    public interface IStudent
    {
        #region Public Properties

        /// <summary>
        /// Name of student.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Student email.
        /// </summary>
        string Email { get; }

        /// <summary>
        /// Student courses.
        /// </summary>
        string Course { get; }

        /// <summary>
        /// List of modules student partakes.
        /// </summary>
        List<string> Modules { get; }

        #endregion
    }
}
