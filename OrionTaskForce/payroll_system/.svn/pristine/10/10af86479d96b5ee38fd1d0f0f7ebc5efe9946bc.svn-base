namespace PayrollSystem
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow
	{
		public MainWindow()
		{
			InitializeComponent();

            #region --- Records Modules ---

            Employees.Click += (sender, e) => ShowEmployeesMainWindow();
            Detachments.Click += (sender, e) => ShowDetachmentsMainWindow();
            TaxGroups.Click += (sender, e) => ShowTaxGroupsMainWindow();
            EmployeeStatuses.Click += (sender, e) => ShowEmployeeStatusesMainWindow();
            PayrollPeriods.Click += (sender, e) => ShowPayrollPeriodsMainWindow();
            //-------------------------------------------------------------------
		    //Employers.Click += (sender, e) => ShowEmployersMainWindow();

		    UsersAndPermissions.Click += (sender, e) => ShowUsersMainWindow();
            #endregion

            #region --- Deduction Modules ---
            
            FixedDeductions.Click += (sender, e) => ShowFixedDeductionMainWindow();
            PhilhealthContributions.Click += (sender, e) => ShowPhilhealthContributionsMainWindow();
            SssContributions.Click += (sender, e) => ShowSssContributionsMainWindow();
            WithholdingTaxDeductions.Click += (sender, e) => ShowWithholdingTaxDeductionsMainWindow();
            #endregion

            Billings.Click += (sender, e) => ShowBillingsMainWindow();

        }

        private void ShowEmployeesMainWindow()
        {
            var view = new Views.Employees.EmployeesList();
            view.ShowDialog();
        }

	    private void ShowEmployersMainWindow()
	    {
            var view = new Views.Employers.EmployersList();
            view.ShowDialog();
	    }

	    void ShowUsersMainWindow()
        {
            var view = new Views.Users.UsersList();
            view.ShowDialog();
        }

	    void ShowPayrollPeriodsMainWindow()
        {
            var view = new Views.PayrollPeriods.PayrollPeriodsList();
            view.ShowDialog();
        }

        void ShowEmployeeStatusesMainWindow()
        {
            var view = new Views.EmployeeStatuses.EmployeeStatusesList();
            view.ShowDialog();
        }

        void ShowDetachmentsMainWindow()
        {
            var view = new Views.Detachments.DetachmentsList();
            view.ShowDialog();
        }

        void ShowTaxGroupsMainWindow() 
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

	    #endregion


        void ShowBillingsMainWindow()
        {
            var view = new Views.Billings.BillingsList();
            view.ShowDialog();
        }
	}
}
