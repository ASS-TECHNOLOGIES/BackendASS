using StudyASS.Interfaces;

namespace StudyASS.Models
{
    /// <summary>
    /// Implementation of <c>IStudentRegistration</c> interface.
    /// </summary>
    public class StudentRegistration : IStudentRegistration
    {
        #region Private Properties

        private string _studentEmail;
        private IEnumerable<string> _modules;

        #endregion

        #region Public Properties

        /// <inheritdoc/>
        public string StudentEmail
        {
            get { return _studentEmail; } 
            set { _studentEmail = value; }
        }

        /// <inheritdoc/>
        public IEnumerable<string> Modules
        {
            get { return _modules; } 
            set { _modules = value; }
        }

        #endregion
    }
}
