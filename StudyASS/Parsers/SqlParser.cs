using MySql.Data.MySqlClient;
using StudyASS.Interfaces;

namespace StudyASS.Parsers
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
                    string name = myReader.GetString("name");

                    //_studentFactory.GetStudent(name);
                }
            }

            return new List<IStudent>();

        }

        public List<Interfaces.ISession> GetSessions()
        {
            throw new NotImplementedException();
        }

        public List<IRegistration> GetRegistrations()
        {
            throw new NotImplementedException();
        }

        public void AddStudent(IStudent student)
        {
            throw new NotImplementedException();
        }

        public void AddSession(Interfaces.ISession session)
        {
            throw new NotImplementedException();
        }

        public void AddRegistration(IRegistration registration)
        {
            throw new NotImplementedException();
        }

        public void RemoveRegistration(IRegistration registration)
        {
            throw new NotImplementedException();
        }
    }
}
