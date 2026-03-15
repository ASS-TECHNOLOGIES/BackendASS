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
        private string? _course;
        private List<string>? _modules;

        #endregion

        #region Constructor

        /// <summary>
        /// Class constructor.
        /// </summary>
        /// <param name="name">
        /// Student name.
        /// </param>
        /// <param name="email">
        /// Student email.
        /// </param>
        public Student(string name, string email)
        {
            _name = name;
            _email = email;
        }

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

        #endregion
    }
}
