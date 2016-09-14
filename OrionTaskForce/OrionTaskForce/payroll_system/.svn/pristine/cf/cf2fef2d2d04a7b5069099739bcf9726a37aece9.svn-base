using PayrollSystem.Models;

namespace PayrollSystem.Views.Employers
{
    /// <summary>
    /// Interaction logic for EmployerView.xaml
    /// </summary>
    public partial class EmployerView : ISaveable
    {
        private readonly EmployerViewModel _viewModel;
        public EmployerView(Employer employer)
        {
            InitializeComponent();
            _viewModel = new EmployerViewModel();
            _viewModel.CurrentEmployer = employer;
            _viewModel.AddressDetails = new Address(employer);
            DataContext = _viewModel;

            btnSave.Content = _viewModel.CurrentEmployer.Id == 0 ? "Create" : "Update";

            btnSave.Click += (sender, args) => Save();
            btnCancel.Click += (sender, args) => Close();

            btnAddress.Click += (sender, e) => ShowAddressDetails();
        }

        private void ShowAddressDetails()
        {
            var address = new Address(_viewModel.CurrentEmployer);
            var view = new Helpers.AddressView(address);
            if(view.ShowDialog() == true)
            {
                _viewModel.AddressDetails = address;
                _viewModel.AddressDetails.MailingAddress = address.ToString();
            }
        }

        public void Save()
        {
            if (_viewModel.CurrentEmployer.Id == 0)
            {
                var result = _viewModel.CurrentEmployer.Create();
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
                var result = _viewModel.CurrentEmployer.Update();
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
