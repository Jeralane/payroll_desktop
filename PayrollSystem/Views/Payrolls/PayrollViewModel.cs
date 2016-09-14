using PayrollSystem.Models;

namespace PayrollSystem.Views.Payrolls
{
    public class PayrollViewModel : AbstractViewModel
    {
        private Employee _employee;
        private Detachment _detachment;
        private Payroll _payroll;
        private string _employeeName;
        private PayrollPeriod _payrollPeriod;

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

        public void Initialize(int payrollId)
        {
            Payroll = new Payroll();
            Payroll.Read(payrollId);

            Detachment = new Detachment();
            Detachment.Read(_payroll.DetachmentId);

            Employee = new Employee();
            Employee.Read(_payroll.EmployeeId);
            EmployeeName = string.Format("{0}, {1} {2}", Employee.LastName, Employee.FirstName, Employee.MiddleName);

            PayrollPeriod = new PayrollPeriod();
            PayrollPeriod.Read(Payroll.PayrollPeriodId);

            Payroll.EarningsPropertyChanged += () =>
                {
                    Payroll.GrossPay = Payroll.BasicPay +
                                       Payroll.OvertimePay +
                                       Payroll.NightDifferentialPay +
                                       Payroll.HolidayPay +
                                       Payroll.HolidayPay +
                                       Payroll.ColaPay +
                                       Payroll.Incentives +
                                       Payroll.OtherPay;

                    Payroll.NetPay = Payroll.GrossPay - Payroll.TotalDeductions;
                };

            Payroll.DeductionsPropertyChanged += () =>
                {
                    Payroll.TotalDeductions = Payroll.CashAdvance +
                                              Payroll.CashBond +
                                              Payroll.Insurance +
                                              Payroll.PagibigContributionEmployee +
                                              Payroll.SssContributionEmployee +
                                              Payroll.PhilhealthContributionEmployee +
                                              Payroll.PagibigLoan +
                                              Payroll.SssLoan +
                                              Payroll.TaxWithheld +
                                              Payroll.OtherDeductions;

                    Payroll.NetPay = Payroll.GrossPay - Payroll.TotalDeductions;
                };

        }

        public string EmployeeName
        {
            get { return _employeeName; }
            set { _employeeName = value; OnPropertyChanged("EmployeeName"); }
        }

        public PayrollPeriod PayrollPeriod
        {
            get { return _payrollPeriod; }
            set { _payrollPeriod = value; OnPropertyChanged("PayrollPeriod"); }
        }

    }
}