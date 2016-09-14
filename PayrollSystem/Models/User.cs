using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace PayrollSystem.Models
{
    public class User : INotifyPropertyChanged
    {
        private int _id;
        private string _name;
        private string _password;

        public int ID
        {
            get { return _id; }
            set
            {
                _id = value;
                NotifyPropertyChanged("ID");
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                NotifyPropertyChanged("Name");
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                NotifyPropertyChanged("Password");
            }
        }

        [Column("access_level")]
        public string AccessLevel { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public static User Find(int id)
        {
            using (var dbContext = new PayrollDbContext())
            {
                return dbContext.Users.Find(id);
            }
        }
    }
}