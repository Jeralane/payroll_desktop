using System.Collections.Generic;
using System.ComponentModel;
using ModelsLibrary.Payroll;

namespace PayrollSystem.Views.Billings
{
    internal class BillingsViewModel : INotifyPropertyChanged
    {
        private Billing _selectedItem;
        public LinkedList<Billing> Collection { get; set; }

        public Billing SelectedItem
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
            //var collection = Billing.GetAll();
            //Billings = new ObservableCollection<Billing>();

            //foreach (var item in collection)
            //{
            //    Billings.Add(item);
            //}
            Collection = Billing.GetAll();
        }
    }
}
