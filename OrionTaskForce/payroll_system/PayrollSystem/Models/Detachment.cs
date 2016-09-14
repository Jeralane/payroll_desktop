using DatabaseLibrary;

namespace PayrollSystem.Models
{
    public class Detachment : AbstractModel
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged("Name"); }
        }

        private string _address;
        public string Address
        {
            get { return _address; }
            set { _address = value; OnPropertyChanged("Address"); }
        }

        private decimal _hoursPerDay;
        public decimal HoursPerDay
        {
            get { return _hoursPerDay; }
            set { _hoursPerDay = value; OnPropertyChanged("HoursPerDay"); }
        }

        private int _numberOfGuards;
        public int NumberOfGuards
        {
            get { return _numberOfGuards; }
            set { _numberOfGuards = value; OnPropertyChanged("NumberOfGuards"); }
        }

        private decimal _monthlyContractAmount;
        public decimal MonthlyContractAmount
        {
            get { return _monthlyContractAmount; }
            set { _monthlyContractAmount = value; OnPropertyChanged("MonthlyContractAmount"); }
        }

        private decimal _monthlyRate;
        public decimal MonthlyRate
        {
            get { return _monthlyRate; }
            set { _monthlyRate = value; OnPropertyChanged("MonthlyRate"); }
        }

        private decimal _monthlyAllowance;
        public decimal MonthlyAllowance
        {
            get { return _monthlyAllowance; }
            set { _monthlyAllowance = value; OnPropertyChanged("MonthlyAllowance"); }
        }

        private decimal _dailyRate;
        public decimal DailyRate
        {
            get { return _dailyRate; }
            set { _dailyRate = value; OnPropertyChanged("DailyRate"); }
        }

        private decimal _costOfLivingAllowance;
        public decimal CostOfLivingAllowance
        {
            get { return _costOfLivingAllowance; }
            set { _costOfLivingAllowance = value; OnPropertyChanged("CostOfLivingAllowance"); }
        }

        private decimal _nightDifferentialRate;
        public decimal NightDifferentialRate
        {
            get { return _nightDifferentialRate; }
            set { _nightDifferentialRate = value; OnPropertyChanged("NightDifferentialRate"); }
        }

        private decimal _adjustment;
        public decimal Adjustment
        {
            get { return _adjustment; }
            set { _adjustment = value; OnPropertyChanged("Adjustment"); }
        }

        private string _remarks;
        public string Remarks
        {
            get { return _remarks; }
            set { _remarks = value; OnPropertyChanged("Remarks"); }
        }

        private bool _isBillingExempted;
        public bool IsBillingExempted
        {
            get { return _isBillingExempted; }
            set { _isBillingExempted = value; OnPropertyChanged("IsBillingExempted"); }
        }

        private bool _isTaxExempted;
        public bool IsTaxExempted
        {
            get { return _isTaxExempted; }
            set { _isTaxExempted = value; OnPropertyChanged("IsTaxExempted"); }
        }

        private int _employerId;
        public int EmployerId
        {
            get { return _employerId; }
            set { _employerId = value; OnPropertyChanged("EmployerId"); }
        }
    }

}
