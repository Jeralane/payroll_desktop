using System;
using DatabaseLibrary;

namespace PayrollSystem.Models
{
    public class CashAdvance : AbstractModel
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

        private decimal _cashAdvanceAmount;

        public decimal CashAdvanceAmount
        {
            get { return _cashAdvanceAmount; }
            set { _cashAdvanceAmount = value; OnPropertyChanged("CashAdvanceAmount"); }
        }

        private decimal _cashAdvanceMonthly;

        public decimal CashAdvanceMonthly
        {
            get { return _cashAdvanceMonthly; }
            set { _cashAdvanceMonthly = value; OnPropertyChanged("CashAdvanceMonthly"); }
        }

        private decimal _cashAdvanceOutstanding;

        public decimal CashAdvanceOutstanding
        {
            get { return _cashAdvanceOutstanding; }
            set { _cashAdvanceOutstanding = value; OnPropertyChanged("CashAdvanceOutstanding"); }
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

            if (CashAdvanceAmount == 0)
                return new DatabaseLibrary.ActionResult(false, "Cash Advance Amount is required.");

            if (CashAdvanceMonthly == 0)
                return new DatabaseLibrary.ActionResult(false, "Monthly Cash Advance Amount is required.");

            return base.Validate();
        }

    }
}