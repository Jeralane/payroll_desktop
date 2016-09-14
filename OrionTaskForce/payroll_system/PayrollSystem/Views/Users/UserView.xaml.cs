using PayrollSystem.Models;

namespace PayrollSystem.Views.Users
{
    /// <summary>
    /// Interaction logic for UserView.xaml
    /// </summary>
    public partial class UserView : ISaveable
    {
        private readonly User _viewModel;
        public UserView(User viewModel)
        {
            InitializeComponent();

            _viewModel = viewModel;
            DataContext = _viewModel;

            btnSave.Content = _viewModel.Id == 0 ? "Create" : "Update";

            btnSave.Click += (sender, args) => Save();
            btnCancel.Click += (sender, args) => Close();

            cboUserAccess.Items.Add("USER");
            cboUserAccess.Items.Add("ADMINISTRATOR");
        }

        public void Save()
        {
            if (_viewModel.Id == 0)
            {
                _viewModel.Password = "password";
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
