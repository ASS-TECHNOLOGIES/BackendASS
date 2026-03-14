using StudyASS.Interfaces;

namespace StudyASS.Models
{
    /// <summary>
    /// Implementation of <c>IStudent</c> interface.
    /// </summary>
    public class Student : IStudent
    {
        #region Private Properties

        private string _name;
        private string _email;
        private string _course;
        private List<string> _modules;
        private List<IStudent> _friends;

        #endregion

        #region Public Properties

        /// <inheritdoc/> 
        public string Name
        {
            get { return _name; }
        }

        /// <inheritdoc/> 
        public string Email
        {
            get { return _email; } 
        }

        /// <inheritdoc/> 
        public string Course
        {
            get { return _course; }
        }

        /// <inheritdoc/> 
        public List<string> Modules
        {
            get { return _modules; }
        }

        /// <inheritdoc/> 
        public List<IStudent> Friends
        {
            get { return _friends; } 
        }

        #endregion
    }
}
