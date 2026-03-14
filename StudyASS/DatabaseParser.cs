using MySql.Data.MySqlClient;
using StudyASS.Interfaces;

namespace StudyASS
{
    public class DatabaseParser
    {
        private MySqlConnection _connection;
        private IStudentFactory _studentFactory;
        public DatabaseParser(IStudentFactory studentFactory)
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

                    _studentFactory.GetStudent(name);
                }
            }

        }
    }
}
