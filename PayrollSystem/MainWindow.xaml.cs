using PayrollSystem.Models;

namespace PayrollSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow(User loggedUser)
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

            #endregion

            Billings.Click += (sender, e) => ShowBillingsMainWindow();

        }

        private void ShowAttendancesWindow()
        {
            var view = new Views.Attendances.AttendancesList();
            view.ShowDialog();
        }

        private void ShowAssignmentsWindow()
        {
            var view = new Views.Assignments.AssignmentsList();
            view.ShowDialog();
        }

        private void ShowPostUnpostCurrentPayrollPeriodWindow()
        {
            var view = new Views.Utilities.PostCurrentPayrollPeriodView();
            view.ShowDialog();
        }

        private readonly User _loggedUser;

        private void ChangeUserPassword()
        {
            var view = new Views.Utilities.ChangePasswordView(_loggedUser);
            view.ShowDialog();
        }

        private void ShowPreferencesMainWindow()
        {
            var view = new Views.Preferences.PreferenceView();
            view.ShowDialog();
        }

        private void ShowSssLoansMainWindow()
        {
            var view = new Views.SssLoans.SssLoansList();
            view.ShowDialog();
        }

        private void ShowPagibigLoansMainWindow()
        {
            var view = new Views.PagibigLoans.PagibigLoansList();
            view.ShowDialog();
        }

        private void ShowCashAdvancesMainWindow()
        {
            var view = new Views.CashAdvances.CashAdvancesList();
            view.ShowDialog();
        }

        private void ShowIncentivesMainWindow()
        {
            var view = new Views.Incentives.IncentivesList();
            view.ShowDialog();
        }

        private void ShowEmployeesMainWindow()
        {
            var view = new Views.Employees.EmployeesList();
            view.ShowDialog();
        }


        private void ShowUsersMainWindow()
        {
            var view = new Views.Users.UsersList();
            view.ShowDialog();
        }

        private void ShowPayrollPeriodsMainWindow()
        {
            var view = new Views.PayrollPeriods.PayrollPeriodsList();
            view.ShowDialog();
        }

        private void ShowEmployeeStatusesMainWindow()
        {
            var view = new Views.EmployeeStatuses.EmployeeStatusesList();
            view.ShowDialog();
        }

        private void ShowDetachmentsMainWindow()
        {
            var view = new Views.Detachments.DetachmentsList();
            view.ShowDialog();
        }

        private void ShowTaxGroupsMainWindow()
        {
            var view = new Views.TaxGroups.TaxGroupsList();
            view.ShowDialog();
        }

        #region --- Deductions Modules ---

        private void ShowFixedDeductionMainWindow()
        {
            var view = new Views.FixedDeductions.FixedDeductionView();
            view.ShowDialog();
        }

        private void ShowPhilhealthContributionsMainWindow()
        {
            var view = new Views.PhilhealthContributions.PhilhealthContributionsList();
            view.ShowDialog();
        }

        private void ShowSssContributionsMainWindow()
        {
            var view = new Views.SssContributions.SssContributionsList();
            view.ShowDialog();
        }

        private void ShowWithholdingTaxDeductionsMainWindow()
        {
            var view = new Views.WithholdingTaxDeductions.WithholdingTaxDeductionsList();
            view.ShowDialog();
        }

        #endregion --- Deductions Modules ---

        private void ShowBillingsMainWindow()
        {
            var view = new Views.Billings.BillingsList();
            view.ShowDialog();
        }
    }
}