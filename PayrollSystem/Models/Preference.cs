using DatabaseLibrary;

namespace PayrollSystem.Models
{
    public class Preference : AbstractModel
    {
        private int _currentPayrollPeriodId;

        public int CurrentPayrollPeriodId
        {
            get { return _currentPayrollPeriodId; }
            set { _currentPayrollPeriodId = value; OnPropertyChanged("CurrentPayrollPeriodId"); }
        }

        private decimal _regularMultiplier;

        public decimal RegularMultiplier
        {
            get { return _regularMultiplier; }
            set { _regularMultiplier = value; OnPropertyChanged("RegularMultiplier"); }
        }

        private decimal _nightDifferentialMultiplier;

        public decimal NightDifferentialMultiplier
        {
            get { return _nightDifferentialMultiplier; }
            set { _nightDifferentialMultiplier = value; OnPropertyChanged("NightDifferentialMultiplier"); }
        }

        private decimal _legalHolidayMultiplier;

        public decimal LegalHolidayMultiplier
        {
            get { return _legalHolidayMultiplier; }
            set { _legalHolidayMultiplier = value; OnPropertyChanged("LegalHolidayMultiplier"); }
        }

        private decimal _specialHolidayMultiplier;

        public decimal SpecialHolidayMultiplier
        {
            get { return _specialHolidayMultiplier; }
            set { _specialHolidayMultiplier = value; OnPropertyChanged("SpecialHolidayMultiplier"); }
        }

        private decimal _overtimeDivisor;

        public decimal OvertimeDivisor
        {
            get { return _overtimeDivisor; }
            set { _overtimeDivisor = value; OnPropertyChanged("OvertimeDivisor"); }
        }

        private decimal _nightDifferentialDivisor;

        public decimal NightDifferentialDivisor
        {
            get { return _nightDifferentialDivisor; }
            set { _nightDifferentialDivisor = value; OnPropertyChanged("NightDifferentialDivisor"); }
        }

        private int _lastBillingNumber;

        public int LastBillingNumber
        {
            get { return _lastBillingNumber; }
            set { _lastBillingNumber = value; OnPropertyChanged("LastBillingNumber"); }
        }

        public override DatabaseLibrary.ActionResult Validate()
        {
            if (CurrentPayrollPeriodId == 0)
                return new DatabaseLibrary.ActionResult(false, "Current Payroll Period is required.");

            return base.Validate();
        }
    }
}