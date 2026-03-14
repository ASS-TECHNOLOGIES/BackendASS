using StudyASS.Interfaces;

namespace StudyASS.Models
{
    public class StudentRegistration : IStudentRegistration
    {
        #region Private Properties

        private string _studentEmail;
        private IEnumerable<string> _modules;

        #endregion

        #region Public Properties

        public string StudentEmail
        {
            get { return _studentEmail; } 
            set { _studentEmail = value; }
        }

        public IEnumerable<string> Modules
        {
            get { return _modules; } 
            set { _modules = value; }
        }

        #endregion
    }
}
