using PayrollSystem.Models;

namespace PayrollSystem.Views.Incentives
{
    public class IncentiveViewModel : AbstractViewModel
    {
        private Incentive _incentive;
        private Detachment _detachment;
        private Employee _employee;
        private PayrollPeriod _startPayrollPeriod;

        public Incentive Incentive
        {
            get { return _incentive; }
            set { _incentive = value; OnPropertyChanged("Incentive"); }
        }

        public Detachment Detachment
        {
            get { return _detachment; }
            set { _detachment = value; OnPropertyChanged("Detachment"); }
        }

        public Employee Employee
        {
            get { return _employee; }
            set { _employee = value; OnPropertyChanged("Employee"); }
        }

        public PayrollPeriod StartPayrollPeriod
        {
            get { return _startPayrollPeriod; }
            set { _startPayrollPeriod = value; OnPropertyChanged("StartPayrollPeriod"); }
        }
    }
}