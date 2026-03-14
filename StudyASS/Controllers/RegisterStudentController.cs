using Microsoft.AspNetCore.Mvc;
using StudyASS.Interfaces;
using StudyASS.Models;
using System.Runtime.Intrinsics.Arm;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudyASS.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RegisterStudentController : ControllerBase
    {
        private IDatabaseParser _databaseParser;

        public RegisterStudentController(IDatabaseParser databaseParser) : base()
        {
            _databaseParser = databaseParser;
        }

        // POST <RegisterStudentController>
        [HttpPost]
        public void Post([FromBody] StudentRegistration value)
        {
            Console.WriteLine("POST: /RegisterStudent received.");
            _databaseParser.AddRegistration(value);
        }
    }
}
