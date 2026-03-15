namespace StudyASS.Interfaces
{
    public interface IStudentFactory
    {
        IStudent Create(string name, string email);
    }
}
