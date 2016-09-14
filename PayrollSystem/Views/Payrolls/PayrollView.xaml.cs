using System.Linq;
using PayrollSystem.Helpers;
using PayrollSystem.Models;
using PayrollSystem.Views.Helpers.SearchModule;

namespace PayrollSystem.Views.Payrolls
{
    /// <summary>
    /// Interaction logic for DetachmentView.xaml
    /// </summary>
    public partial class PayrollView
    {
        private readonly PayrollViewModel _viewModel;
        public PayrollView(Payroll payroll)

        {
            #region --- Initialize ---

            InitializeComponent();

            ViewModel = payroll;
            //DataContext = ViewModel;

            btnSave.Content = ViewModel.Id == 0 ? "Create" : "Update";
            btnSave.Click += (sender, args) => Save();
            btnCancel.Click += (sender, args) => Close();

            #endregion --- Initialize ---

            _viewModel = new PayrollViewModel();
            _viewModel.Initialize(payroll.Id);


            DataContext = _viewModel;
        }

        private void SearchEmployee()
        {
            //TODO: create sp_employess_not_assigned
            //DESC: Filter employees not yet assigned to current payroll
            //      period and selected detachment. Use it as lookup

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
                _viewModel.Payroll.EmployeeId = id;
            }
        }
    }
}
