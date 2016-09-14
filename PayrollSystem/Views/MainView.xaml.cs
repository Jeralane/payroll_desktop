using PayrollSystem.Models;

namespace PayrollSystem.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView
    {
        public MainView(User loggedUser)
        {
            InitializeComponent();

            _loggedUser = loggedUser;
            lblWelcomeUser.Content = string.Format("Welcome, {0}", _loggedUser.Name);
            lblWelcomeUser.MouseDoubleClick += (s, e) => ChangeUserPassword();

            #region --- Records Modules ---

            Employees.Click += (sender, e) => ShowEmployeesMainWindow();
            Detachments.Click += (sender, e) => ShowDetachmentsMainWindow();
            TaxGroups.Click += (sender, e) => ShowTaxGroupsMainWindow();
            EmployeeStatuses.Click += (sender, e) => ShowEmployeeStatusesMainWindow();
            PayrollPeriods.Click += (sender, e) => ShowPayrollPeriodsMainWindow();
            //------------------------------------------------------------------
            UsersAndPermissions.Click += (sender, e) => ShowUsersMainWindow();

            #endregion --- Records Modules ---

            #region --- Deduction Modules ---

            FixedDeductions.Click += (sender, e) => ShowFixedDeductionMainWindow();
            PhilhealthContributions.Click += (sender, e) => ShowPhilhealthContributionsMainWindow();
            SssContributions.Click += (sender, e) => ShowSssContributionsMainWindow();
            WithholdingTaxDeductions.Click += (sender, e) => ShowWithholdingTaxDeductionsMainWindow();

            #endregion --- Deduction Modules ---

            #region --- Incentives and Loans ---

            Incentives.Click += (s, e) => ShowIncentivesMainWindow();
            CashAdvances.Click += (s, e) => ShowCashAdvancesMainWindow();
            PagibigLoans.Click += (s, e) => ShowPagibigLoansMainWindow();
            SssLoans.Click += (s, e) => ShowSssLoansMainWindow();

            #endregion

            #region --- Payroll Preferences ---

            Preferences.Click += (s, e) => ShowPreferencesMainWindow();

            UnpostCurrentPayrollPeriod.Click += (s, e) => ShowPostUnpostCurrentPayrollPeriodWindow();

            Assignments.Click += (s, e) => ShowAssignmentsWindow();

            Attendances.Click += (s, e) => ShowAttendancesWindow();

            Payrolls.Click += (s, e) => ShowPayrollsWindow();

            #endregion

            Billings.Click += (sender, e) => ShowBillingsMainWindow();
        }

        private void ShowPayrollsWindow()
        {
            var view = new Payrolls.PayrollsList();
            view.ShowDialog();
        }


        private void ShowAttendancesWindow()
        {
            var view = new Attendances.AttendancesList();
            view.ShowDialog();
        }

        private void ShowAssignmentsWindow()
        {
            var view = new Assignments.AssignmentsList();
            view.ShowDialog();
        }

        private void ShowPostUnpostCurrentPayrollPeriodWindow()
        {
            var view = new Utilities.PostCurrentPayrollPeriodView();
            view.ShowDialog();
        }

        private readonly User _loggedUser;

        private void ChangeUserPassword()
        {
            var view = new Utilities.ChangePasswordView(_loggedUser);
            view.ShowDialog();
        }

        private void ShowPreferencesMainWindow()
        {
            var view = new Preferences.PreferenceView();
            view.ShowDialog();
        }

        private void ShowSssLoansMainWindow()
        {
            var view = new SssLoans.SssLoansList();
            view.ShowDialog();
        }

        private void ShowPagibigLoansMainWindow()
        {
            var view = new PagibigLoans.PagibigLoansList();
            view.ShowDialog();
        }

        private void ShowCashAdvancesMainWindow()
        {
            var view = new CashAdvances.CashAdvancesList();
            view.ShowDialog();
        }

        private void ShowIncentivesMainWindow()
        {
            var view = new Incentives.IncentivesList();
            view.ShowDialog();
        }

        private void ShowEmployeesMainWindow()
        {
            var view = new Employees.EmployeesList();
            view.ShowDialog();
        }


        private void ShowUsersMainWindow()
        {
            var view = new Users.UsersList();
            view.ShowDialog();
        }

        private void ShowPayrollPeriodsMainWindow()
        {
            var view = new PayrollPeriods.PayrollPeriodsList();
            view.ShowDialog();
        }

        private void ShowEmployeeStatusesMainWindow()
        {
            var view = new EmployeeStatuses.EmployeeStatusesList();
            view.ShowDialog();
        }

        private void ShowDetachmentsMainWindow()
        {
            var view = new Detachments.DetachmentsList();
            view.ShowDialog();
        }

        private void ShowTaxGroupsMainWindow()
        {
            var view = new TaxGroups.TaxGroupsList();
            view.ShowDialog();
        }

        #region --- Deductions Modules ---

        private void ShowFixedDeductionMainWindow()
        {
            var view = new FixedDeductions.FixedDeductionView();
            view.ShowDialog();
        }

        private void ShowPhilhealthContributionsMainWindow()
        {
            var view = new PhilhealthContributions.PhilhealthContributionsList();
            view.ShowDialog();
        }

        private void ShowSssContributionsMainWindow()
        {
            var view = new SssContributions.SssContributionsList();
            view.ShowDialog();
        }

        private void ShowWithholdingTaxDeductionsMainWindow()
        {
            var view = new WithholdingTaxDeductions.WithholdingTaxDeductionsList();
            view.ShowDialog();
        }

        #endregion --- Deductions Modules ---

        private void ShowBillingsMainWindow()
        {
            var view = new Billings.BillingsList();
            view.ShowDialog();
        }
    }
}
