using PayrollSystem.Helpers;
using PayrollSystem.Models;

namespace PayrollSystem.Views.SssLoans
{
    public class SssLoanViewModel : AbstractViewModel
    {
        private Employee _employee;
        private PayrollPeriod _startPayrollPeriod;
        private SssLoan _sssLoan;

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

        public SssLoan SssLoan
        {
            get { return _sssLoan; }
            set { _sssLoan = value; OnPropertyChanged("SssLoan"); }
        }
    }
}