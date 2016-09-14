using System.Linq;
using PayrollSystem.Models;
using PayrollSystem.Views.Helpers.SearchModule;
using PayrollSystem.Helpers;

namespace PayrollSystem.Views.SssLoans
{
    /// <summary>
    /// Interaction logic for SssLoanView.xaml
    /// </summary>
    public partial class SssLoanView : ISaveable
    {
        private readonly SssLoanViewModel _viewModel;
        public SssLoanView(SssLoan model)
        {
            #region --- Initialize ---

            InitializeComponent();

            ViewModel = model;
            //DataContext = ViewModel;

            btnSave.Content = ViewModel.Id == 0 ? "Create" : "Update";
            btnSave.Click += (sender, args) => Save();
            btnCancel.Click += (sender, args) => Close();

            #endregion --- Initialize ---

            _viewModel = new SssLoanViewModel();
            _viewModel.SssLoan = model;
            _viewModel.Employee = ModelFinder.GetEmployee(model.EmployeeId);
            _viewModel.StartPayrollPeriod = ModelFinder.GetPayrollPeriod(model.StartPayrollPeriodId);

            DataContext = _viewModel;

            btnSearchEmployee.Click += (s, e) => SearchEmployee();
            btnSearchPayrollPeriod.Click += (s, e) => SearchPayrollPeriod();
        }


        private void SearchEmployee()
        {
            var models = DatabaseLibrary.ModelCollection.All<Employee>();
            var searchItems =
                models.Select(item =>
                    new SearchItem(item.Id, string.Format("{0}, {1} {2}",
                                               item.LastName,
                                               item.FirstName,
                                               item.MiddleName))).ToList();

            var view = new SearchWindow(searchItems);
            if (view.ShowDialog() == true)
            {
                var id = view.SelectedItem.ItemId;
                _viewModel.Employee = ModelFinder.GetEmployee(id);
                _viewModel.SssLoan.EmployeeId = id;
            }
        }

        private void SearchPayrollPeriod()
        {
            var models = DatabaseLibrary.ModelCollection.All<PayrollPeriod>();
            var searchItems = models.Select(item => new SearchItem(item.Id, item.Description)).ToList();
            var view = new SearchWindow(searchItems);
            if (view.ShowDialog() == true)
            {
                var id = view.SelectedItem.ItemId;
                _viewModel.StartPayrollPeriod = ModelFinder.GetPayrollPeriod(id);
                _viewModel.SssLoan.StartPayrollPeriodId = id;
            }
        }
    }
}
