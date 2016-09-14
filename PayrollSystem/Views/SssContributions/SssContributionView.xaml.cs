using PayrollSystem.Models;

namespace PayrollSystem.Views.SssContributions
{
    /// <summary>
    /// Interaction logic for SssContributionView.xaml
    /// </summary>
    public partial class SssContributionView : ISaveable
    {
        public SssContributionView(SssContribution viewModel)
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
