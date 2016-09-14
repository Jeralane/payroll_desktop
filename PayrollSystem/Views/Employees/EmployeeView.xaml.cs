using DatabaseLibrary;
using PayrollSystem.Models;

namespace PayrollSystem.Views.Employees
{
    /// <summary>
    /// Interaction logic for EmployeeView.xaml
    /// </summary>
    public partial class EmployeeView
    {
        public EmployeeView(AbstractModel viewModel)
        {
            #region --- Initialize ---

            InitializeComponent();

            ViewModel = viewModel;
            DataContext = ViewModel;

            btnSave.Content = ViewModel.Id == 0 ? "Create" : "Update";
            btnSave.Click += (sender, args) => Save();
            btnCancel.Click += (sender, args) => Close();

            Title = string.Format("Employee [{0}, {1} {2}]", ((Employee) ViewModel).LastName,
                                  ((Employee) ViewModel).FirstName,
                                  ((Employee) ViewModel).MiddleName);
            #endregion --- Initialize ---


            cboGender.Items.Add("Male");
            cboGender.Items.Add("Female");

            cboCivilStatus.Items.Add("Single");
            cboCivilStatus.Items.Add("Married");
            cboCivilStatus.Items.Add("Widowed");
            cboCivilStatus.Items.Add("Divorced");

            var taxGroups = ModelCollection.All<TaxGroup>();
            cboTaxGroup.ItemsSource = taxGroups;
        }
    }
}
