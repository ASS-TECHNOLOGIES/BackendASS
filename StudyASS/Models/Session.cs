using StudyASS.Interfaces;

namespace StudyASS.Models
{
    /// <summary>
    /// Implemetation of <c>ISession</c> interface.
    /// </summary>
    public class Session : Interfaces.ISession
    {
        #region Private Properties

        private DateTime _dateTime;
        private string _location;
        private List<IStudent> _attendees;
        private string _module;
        private string _moduleTopic;

        #endregion

        #region Public Properties

        /// <inheritdoc/>
        public DateTime DateTime
        {
            get { return _dateTime; }
        }

        /// <inheritdoc/>
        public string Location
        {
            get { return _location; } 
        }

        /// <inheritdoc/>
        public List<IStudent> Attendees
        {
            get { return _attendees; }
        }

        /// <inheritdoc/>
        public string Module
        {
            get { return _module; }
        }

        /// <inheritdoc/>
        public string ModuleTopic
        {
            get { return _moduleTopic; }
        }

        #endregion
    }
}
