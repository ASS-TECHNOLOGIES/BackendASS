namespace StudyASS.Interfaces
{
    /// <summary>
    /// Interface for factory of <c>IStudent</c> objects.
    /// </summary>
    public interface IStudentFactory
    {
        /// <summary>
        /// Creates student.
        /// </summary>
        /// <param name="name">
        /// Name of student.
        /// </param>
        /// <param name="email">
        /// Student's email.
        /// </param>
        /// <returns>
        /// Student object.
        /// </returns>
        IStudent Create(string name, string email);
    }
}
