using System.ComponentModel;
using PayrollSystem.Models;

namespace PayrollSystem.Views.Employers
{
    internal class EmployerViewModel : INotifyPropertyChanged
    {
        private Employer _currentEmployer;
        private Address _addressDetails;

        public Employer CurrentEmployer
        {
            get { return _currentEmployer; }
            set { _currentEmployer = value; OnPropertyChanged("CurrentEmployer"); }
        }

        public Address AddressDetails
        {
            get { return _addressDetails; }
            set { _addressDetails = value;
            CurrentEmployer.Street = _addressDetails.Street;
            CurrentEmployer.Barangay = _addressDetails.Barangay;
            CurrentEmployer.City = _addressDetails.City;
            CurrentEmployer.ZipCode = _addressDetails.ZipCode;
            CurrentEmployer.Province = _addressDetails.Province;
            CurrentEmployer.Country = _addressDetails.Country;
                OnPropertyChanged("AddressDetails"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
