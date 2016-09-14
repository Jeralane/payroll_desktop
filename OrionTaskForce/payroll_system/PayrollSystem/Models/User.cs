using DatabaseLibrary;

namespace PayrollSystem.Models
{
    public class User : AbstractModel
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged("Name"); }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; OnPropertyChanged("Password"); }
        }

        private string _accessLevel;
        public string AccessLevel
        {
            get { return _accessLevel; }
            set { _accessLevel = value; OnPropertyChanged("AccessLevel"); }
        }

    }

}
