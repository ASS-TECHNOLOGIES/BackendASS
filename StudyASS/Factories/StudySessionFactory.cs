using StudyASS.Interfaces;
using StudyASS.Models;

namespace StudyASS.Factories
{
    public class StudySessionFactory : IStudySessionFactory
    {
        public IStudySession CreateStudySession(DateTime dateTime, string module, string topic)
        {
            return new StudySession(dateTime, module, topic);
        }
    }
}
