using System;
using DatabaseLibrary;

namespace PayrollSystem.Models
{
    public class PagibigLoan : AbstractModel
    {
        private DateTime _transactionDate;
        public DateTime TransactionDate
        {
            get { return _transactionDate; }
            set { _transactionDate = value; OnPropertyChanged("TransactionDate"); }
        }

        private int _employeeId;
        public int EmployeeId
        {
            get { return _employeeId; }
            set { _employeeId = value; OnPropertyChanged("EmployeeId"); }
        }

        private int _startPayrollPeriodId;
        public int StartPayrollPeriodId
        {
            get { return _startPayrollPeriodId; }
            set { _startPayrollPeriodId = value; OnPropertyChanged("StartPayrollPeriodId"); }
        }

        private decimal _pagibigLoanAmount;
        public decimal PagibigLoanAmount
        {
            get { return _pagibigLoanAmount; }
            set { _pagibigLoanAmount = value; OnPropertyChanged("PagibigLoanAmount"); }
        }

        private decimal _pagibigLoanMonthly;
        public decimal PagibigLoanMonthly
        {
            get { return _pagibigLoanMonthly; }
            set { _pagibigLoanMonthly = value; OnPropertyChanged("PagibigLoanMonthly"); }
        }

        private decimal _pagibigLoanOutstanding;
        public decimal PagibigLoanOutstanding
        {
            get { return _pagibigLoanOutstanding; }
            set { _pagibigLoanOutstanding = value; OnPropertyChanged("PagibigLoanOutstanding"); }
        }

        private string _remarks;
        public string Remarks
        {
            get { return _remarks; }
            set { _remarks = value; OnPropertyChanged("Remarks"); }
        }

        public override DatabaseLibrary.ActionResult Validate()
        {
            if (TransactionDate == new DateTime())
                return new DatabaseLibrary.ActionResult(false, "Transaction Date is required.");

            if (EmployeeId == 0)
                return new DatabaseLibrary.ActionResult(false, "Employee is required.");

            if (StartPayrollPeriodId == 0)
                return new DatabaseLibrary.ActionResult(false, "Start Payroll Period is required.");

            if (PagibigLoanAmount == 0)
                return new DatabaseLibrary.ActionResult(false, "Pagibig Loan Amount is required.");

            if (PagibigLoanMonthly == 0)
                return new DatabaseLibrary.ActionResult(false, "Monthly Pagibig Loan Amount is required.");

            return base.Validate();
        }
    }

}
