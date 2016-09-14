using System.Linq;
using PayrollSystem.Helpers;
using PayrollSystem.Models;
using PayrollSystem.Views.Helpers.SearchModule;

namespace PayrollSystem.Views.CashAdvances
{
    /// <summary>
    /// Interaction logic for CashAdvanceView.xaml
    /// </summary>
    public partial class CashAdvanceView : ISaveable
    {
        private readonly CashAdvanceViewModel _viewModel;
        public CashAdvanceView(CashAdvance model)
        {
            #region --- Initialize ---

            InitializeComponent();

            ViewModel = model;
            //DataContext = ViewModel;

            btnSave.Content = ViewModel.Id == 0 ? "Create" : "Update";
            btnSave.Click += (sender, args) => Save();
            btnCancel.Click += (sender, args) => Close();

            #endregion --- Initialize ---

            _viewModel = new CashAdvanceViewModel();
            _viewModel.CashAdvance = (CashAdvance)ViewModel;
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
                _viewModel.CashAdvance.EmployeeId = id;
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
                _viewModel.CashAdvance.StartPayrollPeriodId = id;
            }
        }
    }
}
