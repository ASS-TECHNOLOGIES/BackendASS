namespace StudyASS.Interfaces
{
    public interface IStudySessionFactory
    {
        IStudySession CreateStudySession(DateTime dateTime, string module, string topic);
    }
}
