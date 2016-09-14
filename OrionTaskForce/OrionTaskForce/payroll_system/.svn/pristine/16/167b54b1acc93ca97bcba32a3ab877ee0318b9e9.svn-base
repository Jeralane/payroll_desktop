using PayrollSystem.Models;
namespace PayrollSystem.Views.Detachments
{
    /// <summary>
    /// Interaction logic for DetachmentView.xaml
    /// </summary>
    public partial class DetachmentView : ISaveable
    {
        private readonly Detachment _viewModel;
        public DetachmentView(Detachment viewModel)
        {
            InitializeComponent();

            _viewModel = viewModel;
            DataContext = _viewModel;

            btnSave.Content = _viewModel.Id == 0 ? "Create" : "Update";

            btnSave.Click += (sender, args) => Save();
            btnCancel.Click += (sender, args) => Close();

            btnEmployerDetails.Click += (sender, e) => ShowEmployerDetails();
        }

        private void ShowEmployerDetails()
        {
            var employer = new Employer();
            var employerId = _viewModel.EmployerId;
            if (employerId == 0)
            {
                var condition = string.Format("`{0}` = '{1}'", "name", _viewModel.Name);
                var employers = DatabaseLibrary.ModelCollection.Where<Employer>(condition);
                if(employers.Count > 0)
                {
                    employerId = employers[0].Id;
                }
            }
            if (employerId == 0)
            {
                employer.Name = _viewModel.Name;
                employer.Street = _viewModel.Address;
            }else
            {
                employer.Read(employerId);
            }
            var view = new Employers.EmployerView(employer);
            if(view.ShowDialog() == true)
            {
                _viewModel.EmployerId = employer.Id;
                _viewModel.Name = employer.Name;
                var address = new Address(employer);
                _viewModel.Address = address.ToString();
                _viewModel.Save();
            }
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
