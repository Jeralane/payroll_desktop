using PayrollSystem.Models;

namespace PayrollSystem.Views.EmployeeStatuses
{
    /// <summary>
    /// Interaction logic for EmployeeStatusView.xaml
    /// </summary>
    public partial class EmployeeStatusView : ISaveable
    {
        private readonly EmployeeStatus _viewModel;
        public EmployeeStatusView(EmployeeStatus viewModel)
        {
            InitializeComponent();

            _viewModel = viewModel;
            DataContext = _viewModel;

            btnSave.Content = _viewModel.Id == 0 ? "Create" : "Update";

            btnSave.Click += (sender, args) => Save();
            btnCancel.Click += (sender, args) => Close();
        }

        public void Save()
        {
            if (_viewModel.Id == 0)
            {
                var result = _viewModel.Create();
                if (!result.Success)
                {
                    MessageBoxes.ShowAlert(result.Message);
                    return;
                }

                DialogResult = true;
                Close();
            }
            else
            {
                var result = _viewModel.Update();
                if (!result.Success)
                {
                    MessageBoxes.ShowAlert(result.Message);
                    return;
                }

                DialogResult = true;
                Close();
            }
        }
    }
}
