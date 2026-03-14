using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using StudyASS.Interfaces;
using System.Data;

namespace StudyASS.Parsers
{
    public class SqlParser : IDatabaseParser
    {
        private MySqlConnection _connection;
        private IStudySessionFactory _studySessionFactory;

        public SqlParser(IStudySessionFactory studySessionFactory)
        {
            _studySessionFactory = studySessionFactory;

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

        public IEnumerable<IStudySession> GetStudySessions(string studentEmail)
        {
            List<IStudySession> sessions = new List<IStudySession>();

            MySqlCommand command = new MySqlCommand();
            command.Connection = _connection;
            command.CommandText = @"SELECT SESSION_TIME, MODULE, TOPIC FROM Attendance WHERE EMAIL = @studentEmail;";
            command.Parameters.AddWithValue("@studentEmail", studentEmail);

            using var myReader = command.ExecuteReader();
            {
                while (myReader.Read())
                {
                    DateTime dateTime = myReader.GetDateTime("SESSION_TIME");
                    string module = myReader.GetString("MDOULE");
                    string topic = myReader.GetString("TOPIC");

                    sessions.Add(_studySessionFactory.CreateStudySession(dateTime, module, topic));
                }
            }

            return sessions;
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
    }
}
