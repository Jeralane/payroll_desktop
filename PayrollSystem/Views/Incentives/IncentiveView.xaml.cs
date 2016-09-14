using System.Linq;
using PayrollSystem.Helpers;
using PayrollSystem.Models;
using PayrollSystem.Views.Helpers.SearchModule;

namespace PayrollSystem.Views.Incentives
{
    /// <summary>
    /// Interaction logic for IncentiveView.xaml
    /// </summary>
    public partial class IncentiveView : ISaveable
    {
        private readonly IncentiveViewModel _viewModel;

        public IncentiveView(Incentive model)
        {
            #region --- Initialize ---

            InitializeComponent();

            ViewModel = model;
            //DataContext = ViewModel;

            btnSave.Content = ViewModel.Id == 0 ? "Create" : "Update";
            btnSave.Click += (sender, args) => Save();
            btnCancel.Click += (sender, args) => Close();

            #endregion --- Initialize ---

            _viewModel = new IncentiveViewModel();
            _viewModel.Incentive = (Incentive)ViewModel;
            _viewModel.Detachment = ModelFinder.GetDetachment(model.DetachmentId);
            _viewModel.Employee = ModelFinder.GetEmployee(model.EmployeeId);
            _viewModel.StartPayrollPeriod = ModelFinder.GetPayrollPeriod(model.StartPayrollPeriodId);

            DataContext = _viewModel;

            btnSearchDetachment.Click += (s, e) => SearchDetachment();
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
                _viewModel.Incentive.EmployeeId = id;
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
                _viewModel.Incentive.StartPayrollPeriodId = id;
            }
        }

        private void SearchDetachment()
        {
            var models = DatabaseLibrary.ModelCollection.All<Detachment>();
            var searchItems = models.Select(item => new SearchItem(item.Id, item.Name)).ToList();
            var view = new SearchWindow(searchItems);
            if (view.ShowDialog() == true)
            {
                var id = view.SelectedItem.ItemId;
                _viewModel.Detachment = ModelFinder.GetDetachment(id);
                _viewModel.Incentive.DetachmentId = id;
            }
        }
    }
}