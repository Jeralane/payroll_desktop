using System.Collections.ObjectModel;
using PayrollSystem.Models;

namespace PayrollSystem.Views.Employees
{
    public class EmployeesViewModel : AbstractViewModel
    {
        public ObservableCollection<Employee> Collection { get; set; }

        private Employee _selectedItem;
        public Employee SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                OnPropertyChanged("SelectedItem");
            }
        }

        public EmployeesViewModel()
        {
            Collection = new ObservableCollection<Employee>();
        }
        public override void RefreshCollection()
        {
            var collection = DatabaseLibrary.ModelCollection.All<Employee>();
            Collection = new ObservableCollection<Employee>();
            foreach (Employee item in collection)
            {
                Collection.Add(item);
            }
        }

     }


}
