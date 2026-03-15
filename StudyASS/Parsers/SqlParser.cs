using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using StudyASS.Interfaces;
using System.Data;
using System.Xml.Linq;

namespace StudyASS.Parsers
{
    public class SqlParser : IDatabaseParser
    {
        private MySqlConnection _connection;

        private IStudentFactory _studentFactory;
        private IStudySessionFactory _studySessionFactory;
        private IStudySessionBuilder _studySessionBuilder;

        public SqlParser(IStudentFactory studentFactory, IStudySessionFactory studySessionFactory, IStudySessionBuilder studySessionBuilder)
        {
            _studentFactory = studentFactory;
            _studySessionFactory = studySessionFactory;
            _studySessionBuilder = studySessionBuilder;

            string connectionStr = "server=localhost;port=4306;uid=root;pwd=password;database=StudyAssDB";
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

        public IStudent GetStudent(string email)
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = _connection;
            command.CommandText = @"SELECT NAME FROM student WHERE EMAIL = @studentEmail ;";
            command.Parameters.AddWithValue("@studentEmail", email);

            using var myReader = command.ExecuteReader();
            {
                while (myReader.Read())
                {
                    string name = myReader.GetString("NAME");

                    return _studentFactory.Create(name, email); ;
                }
            }

            throw new Exception($"No student exists with Email: {email}.");

        }

        public IEnumerable<IStudySession> GetStudySessions()
        {
            _studySessionBuilder.Clear();
            MySqlCommand command = new MySqlCommand();
            command.Connection = _connection;
            command.CommandText = @"SELECT a.SESSION_TIME, a.MODULE, a.TOPIC, s.EMAIL, s.NAME FROM Attendance a JOIN Student s ON a.EMAIL = s.EMAIL;";

            using var myReader = command.ExecuteReader();
            {
                while (myReader.Read())
                {
                    DateTime dateTime = myReader.GetDateTime("SESSION_TIME");
                    string module = myReader.GetString("MODULE");
                    string topic = myReader.GetString("TOPIC");
                    string studentEmail = myReader.GetString("EMAIL");
                    string studentName = myReader.GetString("NAME");

                    IStudent student = _studentFactory.Create(studentName, studentEmail);

                    _studySessionBuilder.Add(dateTime, module, topic, student);
                }
            }

            return _studySessionBuilder.GetSessions();
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
                    string module = myReader.GetString("MODULE");
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
