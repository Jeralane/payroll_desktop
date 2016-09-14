using System;
using PayrollSystem.Helpers;
using PayrollSystem.Models;

namespace PayrollSystem.Views.CashAdvances
{
    public class CashAdvanceViewModel : AbstractViewModel
    {
        private Employee _employee;
        private PayrollPeriod _startPayrollPeriod;
        private CashAdvance _cashAdvance;

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

        public CashAdvance CashAdvance
        {
            get { return _cashAdvance; }
            set { _cashAdvance = value; OnPropertyChanged("CashAdvance"); }
        }
    }
}