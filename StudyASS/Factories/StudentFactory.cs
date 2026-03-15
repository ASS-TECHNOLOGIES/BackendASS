using StudyASS.Interfaces;
using StudyASS.Models;

namespace StudyASS.Factories
{
    public class StudentFactory : IStudentFactory
    {
        public IStudent Create(string name, string email)
        {
            return new Student(name, email);
        }
    }
}
