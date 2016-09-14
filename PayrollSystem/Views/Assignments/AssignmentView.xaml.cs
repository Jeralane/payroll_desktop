using System.Linq;
using PayrollSystem.Helpers;
using PayrollSystem.Models;
using PayrollSystem.Views.Helpers.SearchModule;

namespace PayrollSystem.Views.Assignments
{
    /// <summary>
    /// Interaction logic for DetachmentView.xaml
    /// </summary>
    public partial class AssignmentView
    {
        private readonly AssignmentViewModel _viewModel;
        public AssignmentView(Payroll model, Detachment detachment)
        {
            #region --- Initialize ---

            InitializeComponent();

            ViewModel = model;
            //DataContext = ViewModel;

            btnSave.Content = ViewModel.Id == 0 ? "Create" : "Update";
            btnSave.Click += (sender, args) => Save();
            btnCancel.Click += (sender, args) => Close();

            #endregion --- Initialize ---

            _viewModel = new AssignmentViewModel();
            _viewModel.Detachment = detachment;
            _viewModel.Payroll = model;
            if (model.EmployeeId > 0)
            {
                _viewModel.Employee = ModelFinder.GetEmployee(model.EmployeeId);
            }else
            {
                model.Rate = detachment.DailyRate;
                model.Cola = detachment.Cola;
                model.Adjustment = detachment.Adjustment;
            }

            DataContext = _viewModel;

            btnSearchEmployee.Click += (s, e) => SearchEmployee();
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
