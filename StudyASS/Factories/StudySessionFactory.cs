using StudyASS.Interfaces;
using StudyASS.Models;

namespace StudyASS.Factories
{
    /// <summary>
    /// Class implements <c>IStudySessionFactory</c>.
    /// </summary>
    public class StudySessionFactory : IStudySessionFactory
    {
        /// <inheritdoc/>
        public IStudySession CreateStudySession(DateTime dateTime, string module, string topic)
        {
            return new StudySession(dateTime, module, topic);
        }
    }
}
