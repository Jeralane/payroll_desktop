using DatabaseLibrary;

namespace PayrollSystem.Views.EmployeeStatuses
{
    /// <summary>
    /// Interaction logic for EmployeeStatusView.xaml
    /// </summary>
    public partial class EmployeeStatusView
    {

        public EmployeeStatusView(AbstractModel viewModel)
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
