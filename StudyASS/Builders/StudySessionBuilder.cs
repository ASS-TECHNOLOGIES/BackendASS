using StudyASS.Interfaces;

namespace StudyASS.Builders
{
    /// <summary>
    /// Class implements <c>IStudySessionBuilder</c>.
    /// Follows builder desing pattern to build collection of <c>IStudySession</c>.
    /// </summary>
    public class StudySessionBuilder : IStudySessionBuilder
    {
        #region Private Properties

        private IStudySessionFactory _sessionFactory;
        private List<IStudySession> _sessions;

        #endregion

        #region Constructor

        /// <summary>
        /// Class constructor.
        /// </summary>
        /// <param name="sessionFactory">
        /// Refernece to study session factory.
        /// </param>
        public StudySessionBuilder(IStudySessionFactory sessionFactory)
        {
            _sessionFactory = sessionFactory;
        }

        #endregion

        #region Public Methods

        /// <inheritdoc/> 
        public void Clear()
        {
            _sessions = new List<IStudySession>();
        }

        /// <inheritdoc/> 
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

        /// <inheritdoc/> 
        public IEnumerable<IStudySession> GetSessions()
        {
            return _sessions;
        }

        #endregion
    }
}
