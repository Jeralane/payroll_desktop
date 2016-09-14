using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using ModelsLibrary.Payroll;

namespace PayrollSystem.Views.TaxGroups
{
    public class TaxGroupsViewModel
    {
        private TaxGroup _selectedItem;
        public TaxGroupCollection Collection { get; set; }

        public TaxGroup SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                OnPropertyChanged("SelectedItem");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public void Initialize()
        {
            //var collection = TaxGroup.GetAll();
            //TaxGroups = new ObservableCollection<TaxGroup>();

            //foreach (var item in collection)
            //{
            //    TaxGroups.Add(item);
            //}
            Collection = TaxGroupCollection.GetAll();
        }
    }


}
