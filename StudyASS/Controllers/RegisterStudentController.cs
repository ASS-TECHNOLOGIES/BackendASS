using Microsoft.AspNetCore.Mvc;
using StudyASS.Interfaces;
using StudyASS.Models;
using System.Runtime.Intrinsics.Arm;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudyASS.Controllers
{
    /// <summary>
    /// Controller for RegisterStudent endpoints.
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class RegisterStudentController : ControllerBase
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
        public RegisterStudentController(IDatabaseParser databaseParser) : base()
        {
            _databaseParser = databaseParser;
        }

        #endregion

        #region Endpoints

        /// <summary>
        /// POST <RegisterStudentController>.
        /// Handles request to add student register for study support session.
        /// </summary>
        /// <param name="value">
        /// Student Registration data.
        /// </param>
        [HttpPost]
        public void Post([FromBody] StudentRegistration value)
        {
            Console.WriteLine("POST: /RegisterStudent received.");
            _databaseParser.AddRegistration(value);
        }

        #endregion
    }
}
