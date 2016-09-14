using System.Collections.ObjectModel;
using PayrollSystem.Models;

namespace PayrollSystem.Views.TaxGroups
{
    public class TaxGroupsViewModel : AbstractViewModel
    {
        public ObservableCollection<TaxGroup> Collection { get; set; }

        private TaxGroup _selectedItem;
        public TaxGroup SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                OnPropertyChanged("SelectedItem");
            }
        }

        public TaxGroupsViewModel()
        {
            Collection = new ObservableCollection<TaxGroup>();
        }
        public override void RefreshCollection()
        {
            var collection = DatabaseLibrary.ModelCollection.All<TaxGroup>();
            Collection = new ObservableCollection<TaxGroup>();
            foreach (TaxGroup item in collection)
            {
                Collection.Add(item);
            }
        }

     }


}
