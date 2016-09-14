using DatabaseLibrary;

namespace PayrollSystem.Models
{
	public class SssContribution : AbstractModel
	{
		private decimal _minimum;
		public  decimal Minimum
		{
			get { return _minimum; }
			set { _minimum = value; OnPropertyChanged("Minimum"); }
		}

		private decimal _maximum;
		public  decimal Maximum
		{
			get { return _maximum; }
			set { _maximum = value; OnPropertyChanged("Maximum"); }
		}

		private decimal _employeeShare;
		public  decimal EmployeeShare
		{
			get { return _employeeShare; }
			set { _employeeShare = value; OnPropertyChanged("EmployeeShare"); }
		}

		private decimal _employerShare;
		public  decimal EmployerShare
		{
			get { return _employerShare; }
			set { _employerShare = value; OnPropertyChanged("EmployerShare"); }
		}

		private decimal _total;
		public  decimal Total
		{
			get { return _total; }
			set { _total = value; OnPropertyChanged("Total"); }
		}

	}

}
