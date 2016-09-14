using PayrollSystem.Models;

namespace PayrollSystem.Views.PhilhealthContributions
{
    /// <summary>
    /// Interaction logic for PhilhealthContributionView.xaml
    /// </summary>
    public partial class PhilhealthContributionView : ISaveable
    {
        public PhilhealthContributionView(PhilhealthContribution viewModel)
        {
            #region --- Initialize ---

            InitializeComponent();

            ViewModel = viewModel;
            DataContext = ViewModel;

            btnSave.Content = ViewModel.Id == 0 ? "Create" : "Update";
            btnSave.Click += (sender, args) => Save();
            btnCancel.Click += (sender, args) => Close();

            #endregion --- Initialize ---
        }
    }
}
