using PayrollSystem.Models;
using System.Linq;

namespace PayrollSystem.Views.Employees
{
    /// <summary>
    /// Interaction logic for EmployeeView.xaml
    /// </summary>
    public partial class EmployeeView : ISaveable
    {
        private readonly Employee _viewModel;
        public EmployeeView(Employee viewModel)
        {
            InitializeComponent();
            cboGender.Items.Add("Male");
            cboGender.Items.Add("Female");

            cboCivilStatus.Items.Add("Single");
            cboCivilStatus.Items.Add("Married");
            cboCivilStatus.Items.Add("Widowed");
            cboCivilStatus.Items.Add("Divorced");

            var taxGroups = DatabaseLibrary.ModelCollection.All<TaxGroup>();
            cboTaxGroup.ItemsSource = taxGroups;

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
