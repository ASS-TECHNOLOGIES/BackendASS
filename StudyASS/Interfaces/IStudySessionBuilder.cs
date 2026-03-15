namespace StudyASS.Interfaces
{
    public interface IStudySessionBuilder
    {
        void Clear();

        void Add(DateTime dateIme, string module, string topic, IStudent student);
        
        IEnumerable<IStudySession> GetSessions();
    }
}
