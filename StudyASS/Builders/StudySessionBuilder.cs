using StudyASS.Interfaces;
using StudyASS.TODO;

namespace StudyASS.Builders
{
    public class StudySessionBuilder : IStudySessionBuilder
    {
        private IStudySessionFactory _sessionFactory;
        private List<IStudySession> _sessions;

        public StudySessionBuilder(IStudySessionFactory sessionFactory)
        {
            _sessionFactory = sessionFactory;
        }

        public void Clear()
        {
            _sessions = new List<IStudySession>();
        }

        public void Add(DateTime dateTime, string module, string topic, IStudent student)
        {
            IEnumerable<IStudySession> sessionQuery =
                from s in _sessions
                where s.DateTime == dateTime && s.Module == module && s.Topic == topic
                select s;

            IStudySession session = sessionQuery.FirstOrDefault();
            if (session != null)
            {
                session.Attendees.Add(student);
            }
            else
            {
                IStudySession newSession = _sessionFactory.CreateStudySession(dateTime, module, topic);
                newSession.Attendees.Add(student);
                _sessions.Add(newSession);
            }
        }

        public IEnumerable<IStudySession> GetSessions()
        {
            return _sessions;
        }
    }
}
