using System.Collections.ObjectModel;
using PayrollSystem.Models;

namespace PayrollSystem.Views.Employers
{
    public class EmployersViewModel : AbstractViewModel
    {
        public ObservableCollection<Employer> Collection { get; set; }

        private Employer _selectedItem;
        public Employer SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                OnPropertyChanged("SelectedItem");
            }
        }

        public EmployersViewModel()
        {
            Collection = new ObservableCollection<Employer>();
        }
        public override void RefreshCollection()
        {
            var collection = DatabaseLibrary.ModelCollection.All<Employer>();
            Collection = new ObservableCollection<Employer>();
            foreach (Employer item in collection)
            {
                Collection.Add(item);
            }
        }

     }


}
