using StudyASS.Interfaces;
using StudyASS.TODO;

namespace StudyASS.Parsers
{
    public class ConsoleOutputter : IDatabaseParser
    {
        public List<IStudent> GetStudents()
        {
            throw new NotImplementedException();
        }

        public List<IStudySession> GetSessions()
        {
            throw new NotImplementedException();
        }

        public List<IStudentRegistration> GetRegistrations()
        {
            throw new NotImplementedException();
        }

        public void AddStudent(IStudent student)
        {
            throw new NotImplementedException();
        }

        public void AddSession(IStudySession session)
        {
            throw new NotImplementedException();
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

        public void RemoveRegistration(IStudentRegistration registration)
        {
            throw new NotImplementedException();
        }
    }
}
