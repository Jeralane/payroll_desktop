using DatabaseLibrary;

namespace PayrollSystem.Models
{
	public class Employer : AbstractModel
	{
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged("Name"); }
        }

	    private string _branch;
        public string Branch
        {
            get { return _branch; }
            set { _branch = value; OnPropertyChanged("Branch"); }
        }

		private string _street;
		public string Street
		{
			get { return _street; }
			set { _street = value; OnPropertyChanged("Street"); }
		}

		private string _barangay;
		public string Barangay
		{
			get { return _barangay; }
			set { _barangay = value; OnPropertyChanged("Barangay"); }
		}

		private string _city;
		public string City
		{
			get { return _city; }
			set { _city = value; OnPropertyChanged("City"); }
		}

		private string _province;
		public string Province
		{
			get { return _province; }
			set { _province = value; OnPropertyChanged("Province"); }
		}

		private string _country;
		public string Country
		{
			get { return _country; }
			set { _country = value; OnPropertyChanged("Country"); }
		}

		private string _zipCode;
		public string ZipCode
		{
			get { return _zipCode; }
			set { _zipCode = value; OnPropertyChanged("ZipCode"); }
		}

		private string _phoneNumber;
		public string PhoneNumber
		{
			get { return _phoneNumber; }
			set { _phoneNumber = value; OnPropertyChanged("PhoneNumber"); }
		}

		private string _mobileNumber;
		public string MobileNumber
		{
			get { return _mobileNumber; }
			set { _mobileNumber = value; OnPropertyChanged("MobileNumber"); }
		}

		private string _faxNumber;
		public string FaxNumber
		{
			get { return _faxNumber; }
			set { _faxNumber = value; OnPropertyChanged("FaxNumber"); }
		}

		private string _emailAddress;
		public string EmailAddress
		{
			get { return _emailAddress; }
			set { _emailAddress = value; OnPropertyChanged("EmailAddress"); }
		}

		private string _website;
		public string Website
		{
			get { return _website; }
			set { _website = value; OnPropertyChanged("Website"); }
		}

		private string _notes;
		public string Notes
		{
			get { return _notes; }
			set { _notes = value; OnPropertyChanged("Notes"); }
		}
	}

}
