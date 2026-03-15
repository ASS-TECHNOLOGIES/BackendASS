using Microsoft.AspNetCore.Mvc;
using StudyASS.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudyASS.Controllers
{
    /// <summary>
    /// Controller for StudySession endpoints.
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class StudySessionsController : ControllerBase
    {
        #region Private Properties

        private IDatabaseParser _databaseParser;

        #endregion

        #region Constructor

        /// <summary>
        /// Class constructor.
        /// </summary>
        /// <param name="databaseParser">
        /// Reference to database parser for accessing data store.
        /// </param>
        public StudySessionsController(IDatabaseParser databaseParser) : base()
        {
            _databaseParser = databaseParser;
        }

        #endregion

        #region 

        /// <summary>
        /// GET <StudySessionsController>
        /// </summary>
        /// <returns>
        /// Collection of study sessions.
        /// </returns>
        [HttpGet]
        public IEnumerable<IStudySession> Get()
        {
            Console.WriteLine($"GET: /StudySessions");
            return _databaseParser.GetStudySessions();
        }

        /// <summary>
        /// GET <StudySessionsController>/student email.
        /// e.g. StudySessions/atdenton@lancashire.ac.uk
        /// </summary>
        /// <param name="studentEmail">
        /// Email of student to filter study sessions by.
        /// </param>
        /// <returns>
        /// Collection of study sessions.
        /// </returns>
        [HttpGet("{studentEmail}")]
        public IEnumerable<IStudySession> Get(string studentEmail)
        {
            // Get each study session that involves the current student.
            Console.WriteLine($"GET: /StudySessions/{studentEmail} received.");
            return _databaseParser.GetStudySessions(studentEmail);
        }

        #endregion
    }
}

