using MySql.Data.MySqlClient;
using StudyASS.Interfaces;

namespace StudyASS.TODO
{
    public class SqlParser : IDatabaseParser
    {
        private MySqlConnection _connection;
        private IStudentFactory _studentFactory;
        public SqlParser(IStudentFactory studentFactory)
        {
            _studentFactory = studentFactory;

            string connectionStr = "server=127.0.0.1;uid=root;pwd=Chocostrawberry1;database=StudyAssDB";
            _connection = new MySqlConnection(connectionStr);

            _connection.Open();
        }

        public List<IStudent> GetStudents()
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = _connection;
            command.CommandText = @"SELECT * FROM STUDENT;";

            using var myReader = command.ExecuteReader();
            {
                while (myReader.Read())
                {
                    string name = myReader.GetString("NAME");
                    string email = myReader.GetString("EMAIL");
                    string course = myReader.GetString("COURSE");

                    DateTime availability1 = myReader.GetDateTime("AVAILABILITY1");
                    DateTime availability2 = myReader.GetDateTime("AVAILABILITY2");
                    DateTime availability3 = myReader.GetDateTime("AVAILABILITY3");
                    List<DateTime> availabilities = new List<DateTime> { availability1, availability2, availability3 };
                }
            }

            return new List<IStudent>();

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
            throw new NotImplementedException();
        }

        public void RemoveRegistration(IStudentRegistration registration)
        {
            throw new NotImplementedException();
        }
    }
}
