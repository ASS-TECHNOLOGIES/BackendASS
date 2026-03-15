using StudyASS.Interfaces;

namespace StudyASS.Parsers
{
    public class ConsoleOutputter : IDatabaseParser
    {
        public IEnumerable<IStudySession> GetStudySessions(string studentEmail)
        {
            Console.WriteLine($"Student Email: {studentEmail}\n");
            return null;
        }

        public void AddRegistration(IStudentRegistration registration)
        {
            Console.WriteLine($"Student Email: {registration.StudentEmail}\n, Modules:");
            foreach (string module in registration.Modules)
            {
                Console.WriteLine($"\t{module}");
            }
            Console.WriteLine();
        }

        public IEnumerable<IStudySession> GetStudySessions()
        {
            throw new NotImplementedException();
        }
    }
}
