namespace StudyASS.TODO
{
    public interface IStudentFactory
    {
        IStudent CreateStudent(string name, string email, string courese, List<string> modules, List<IStudent> friends);
    }
}
