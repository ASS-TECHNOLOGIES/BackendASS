using Microsoft.AspNetCore.Mvc;
using StudyASS.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudyASS.TODO
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private IDatabaseParser _parser;

        public StudentController(IDatabaseParser databaseParser) : base()
        {
            _parser = databaseParser;
        }

        // GET: api/<StudentsController>
        [HttpGet(Name = "GetStudents")]
        public IEnumerable<IStudent> Get()
        {
            return _parser.GetStudents();
        }
    }
}
