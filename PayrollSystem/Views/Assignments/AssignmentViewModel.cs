using PayrollSystem.Models;

namespace PayrollSystem.Views.Assignments
{
    public class AssignmentViewModel : AbstractViewModel
    {
        private Employee _employee;
        private Detachment _detachment;
        private Payroll _payroll;

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

        public Payroll Payroll
        {
            get { return _payroll; }
            set { _payroll = value; OnPropertyChanged("Payroll"); }
        }
    }
}