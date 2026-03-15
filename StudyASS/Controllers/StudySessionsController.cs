using Microsoft.AspNetCore.Mvc;
using StudyASS.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudyASS.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudySessionsController : ControllerBase
    {
        private IDatabaseParser _databaseParser;

        public StudySessionsController(IDatabaseParser databaseParser) : base()
        {
            _databaseParser = databaseParser;
        }

        // GET: <StudySessionsController>
        [HttpGet]
        public IEnumerable<IStudySession> Get()
        {
            Console.WriteLine($"GET: /StudySessions");
            return _databaseParser.GetStudySessions();
        }

        // GET <StudySessionsController>/atdenton@lancashire.ac.uk
        [HttpGet("{studentEmail}")]
        public IEnumerable<IStudySession> Get(string studentEmail)
        {
            // Get each study session that involves the current student.
            Console.WriteLine($"GET: /StudySessions/{studentEmail} received.");
            return _databaseParser.GetStudySessions(studentEmail);
        }
    }
}

