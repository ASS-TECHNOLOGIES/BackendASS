using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using StudyASS.Interfaces;
using StudyASS.TODO;

namespace StudyASS.Parsers
{
    public class SqlParser : IDatabaseParser
    {
        private MySqlConnection _connection;

        public SqlParser()
        {
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
            foreach (string module in registration.Modules)
            {
                MySqlCommand command = new MySqlCommand();
                command.Connection = _connection;

                command.CommandText = @"INSERT INTO Registration (EMAIL, MODULE) VALUES (@email, @module);";
                command.Parameters.AddWithValue("@email", registration.StudentEmail);
                command.Parameters.AddWithValue("@module", module);

                command.ExecuteNonQuery();
            }
        }

        public void RemoveRegistration(IStudentRegistration registration)
        {
            throw new NotImplementedException();
        }
    }
}
