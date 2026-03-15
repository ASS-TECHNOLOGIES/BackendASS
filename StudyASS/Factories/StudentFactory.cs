using StudyASS.Interfaces;
using StudyASS.Models;

namespace StudyASS.Factories
{
    /// <summary>
    /// Class implements <c>IStudentFactory</c>.
    /// </summary>
    public class StudentFactory : IStudentFactory
    {
        /// <inheritdoc/>
        public IStudent Create(string name, string email)
        {
            return new Student(name, email);
        }
    }
}
