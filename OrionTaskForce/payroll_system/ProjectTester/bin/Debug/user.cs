using DatabaseLibrary;

namespace PayrollSystem.Models
{
    [TableName("users")]
    public class User : AbstractModel
    {
        private string _name;

        [ColumnName("name")]
        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged("Name"); }
        }

        private string _password;

        [ColumnName("password")]
        public string Password
        {
            get { return _password; }
            set { _password = value; OnPropertyChanged("Password"); }
        }

        private string _accessLevel;

        [ColumnName("access_level")]
        public string AccessLevel
        {
            get { return _accessLevel; }
            set { _accessLevel = value; OnPropertyChanged("AccessLevel"); }
        }

    }

}
