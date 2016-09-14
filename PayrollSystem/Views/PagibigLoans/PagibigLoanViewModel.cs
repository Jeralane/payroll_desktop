using PayrollSystem.Models;

namespace PayrollSystem.Views.PagibigLoans
{
    public class PagibigLoanViewModel : AbstractViewModel
    {
        private Employee _employee;
        private PayrollPeriod _startPayrollPeriod;
        private PagibigLoan _pagibigLoan;

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

        public PagibigLoan PagibigLoan
        {
            get { return _pagibigLoan; }
            set { _pagibigLoan = value; OnPropertyChanged("PagibigLoan"); }
        }
    }
}