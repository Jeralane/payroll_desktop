using DatabaseLibrary;

namespace PayrollSystem.Models
{
    public class Incentive : AbstractModel
    {
        private int _detachmentId;

        public int DetachmentId
        {
            get { return _detachmentId; }
            set { _detachmentId = value; OnPropertyChanged("DetachmentId"); }
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

        private decimal _monthlyIncentiveAmount;

        public decimal MonthlyIncentiveAmount
        {
            get { return _monthlyIncentiveAmount; }
            set { _monthlyIncentiveAmount = value; OnPropertyChanged("MonthlyIncentiveAmount"); }
        }

        private string _remarks;

        public string Remarks
        {
            get { return _remarks; }
            set { _remarks = value; OnPropertyChanged("Remarks"); }
        }

        public override DatabaseLibrary.ActionResult Validate()
        {
            if (DetachmentId == 0)
                return new DatabaseLibrary.ActionResult(false, "Detachment is required.");

            if (EmployeeId == 0)
                return new DatabaseLibrary.ActionResult(false, "Employee is required.");

            if (StartPayrollPeriodId == 0)
                return new DatabaseLibrary.ActionResult(false, "Start Payroll Period is required.");

            return base.Validate();
        }
    }
}