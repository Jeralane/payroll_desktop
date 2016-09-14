using System.Collections.ObjectModel;
using PayrollSystem.Models;

namespace PayrollSystem.Views.Users
{
    public class UsersViewModel : AbstractViewModel
    {
        public ObservableCollection<User> Collection { get; set; }

        private User _selectedItem;
        public User SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                OnPropertyChanged("SelectedItem");
            }
        }

        public UsersViewModel()
        {
            Collection = new ObservableCollection<User>();
        }
        public override void RefreshCollection()
        {
            var collection = DatabaseLibrary.ModelCollection.All<User>();
            Collection = new ObservableCollection<User>();
            foreach (User item in collection)
            {
                Collection.Add(item);
            }
        }

     }


}
