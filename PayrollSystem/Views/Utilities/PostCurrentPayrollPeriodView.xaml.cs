namespace PayrollSystem.Views.Utilities
{
    /// <summary>
    /// Interaction logic for TaxGroupView.xaml
    /// </summary>
    public partial class PostCurrentPayrollPeriodView
    {
        public PostCurrentPayrollPeriodView()
        {
            #region --- Initialize ---

            InitializeComponent();

            // get the preference
            var preferenceViewModel = new Preferences.PreferenceViewModel();
            preferenceViewModel.Read();
            ViewModel = preferenceViewModel.CurrentPayrollPeriod;

            DataContext = ViewModel;

            btnSave.Content = ViewModel.Id == 0 ? "Create" : "Update";
            btnSave.Click += (sender, args) => Save();
            btnCancel.Click += (sender, args) => Close();

            #endregion --- Initialize ---
        }
    }
}
