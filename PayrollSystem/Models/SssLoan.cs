using System;
using DatabaseLibrary;

namespace PayrollSystem.Models
{
    public class SssLoan : AbstractModel
    {
        private DateTime _transactionDate;

        public DateTime TransactionDate
        {
            get { return _transactionDate; }
            set
            {
                _transactionDate = value;
                OnPropertyChanged("TransactionDate");
            }
        }

        private int _employeeId;

        public int EmployeeId
        {
            get { return _employeeId; }
            set
            {
                _employeeId = value;
                OnPropertyChanged("EmployeeId");
            }
        }

        private int _startPayrollPeriodId;

        public int StartPayrollPeriodId
        {
            get { return _startPayrollPeriodId; }
            set
            {
                _startPayrollPeriodId = value;
                OnPropertyChanged("StartPayrollPeriodId");
            }
        }

        private decimal _sssLoanAmount;

        public decimal SssLoanAmount
        {
            get { return _sssLoanAmount; }
            set
            {
                _sssLoanAmount = value;
                OnPropertyChanged("SssLoanAmount");
            }
        }

        private decimal _sssLoanMonthly;

        public decimal SssLoanMonthly
        {
            get { return _sssLoanMonthly; }
            set
            {
                _sssLoanMonthly = value;
                OnPropertyChanged("SssLoanMonthly");
            }
        }

        private decimal _sssLoanOutstanding;

        public decimal SssLoanOutstanding
        {
            get { return _sssLoanOutstanding; }
            set
            {
                _sssLoanOutstanding = value;
                OnPropertyChanged("SssLoanOutstanding");
            }
        }

        private string _remarks;

        public string Remarks
        {
            get { return _remarks; }
            set
            {
                _remarks = value;
                OnPropertyChanged("Remarks");
            }
        }

        public override DatabaseLibrary.ActionResult Validate()
        {
            if (TransactionDate == new DateTime())
                return new DatabaseLibrary.ActionResult(false, "Transaction Date is required.");

            if (EmployeeId == 0)
                return new DatabaseLibrary.ActionResult(false, "Employee is required.");

            if (StartPayrollPeriodId == 0)
                return new DatabaseLibrary.ActionResult(false, "Start Payroll Period is required.");

            if (SssLoanAmount == 0)
                return new DatabaseLibrary.ActionResult(false, "SSS Loan Amount is required.");

            if (SssLoanMonthly == 0)
                return new DatabaseLibrary.ActionResult(false, "Monthly SSS Loan Amount is required.");

            return base.Validate();
        }
    }
}