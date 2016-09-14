using System.Linq;
using System.Collections.ObjectModel;
using PayrollSystem.Models;

namespace PayrollSystem.Views.EmployeeStatuses
{
    public partial class EmployeeStatusesList : IManageModel
    {
        private EmployeeStatusesViewModel _viewModel = new EmployeeStatusesViewModel();
        private EmployeeStatusesViewModel _lookup = new EmployeeStatusesViewModel();
        public EmployeeStatusesList()
        {
            InitializeComponent();
            _lookup.RefreshCollection();
            Refresh();

            btnRefresh.Click += (sender, args) => Refresh();
            btnAdd.Click += (sender, args) => Add();
            btnEdit.Click += (sender, args) => Edit();
            btnDelete.Click += (sender, args) => Delete();
        }

        #region Implementation of IViewable

        public void Refresh()
        {
            var tempModel = new EmployeeStatusesViewModel();
            tempModel.Collection = new ObservableCollection<EmployeeStatus>();

            var searchItem = txtFilterByKeyword.Text;
            if (searchItem.Trim().Length == 0)
            {
                foreach (var item in _lookup.Collection)
                {
                    tempModel.Collection.Add(item);
                }
            }
            else
            {
                var filteredItem = from item in _lookup.Collection
                                   where (item.Description.ToLower()).Contains(searchItem.ToLower())
                                   select item;

                foreach (var item in filteredItem)
                {
                    tempModel.Collection.Add(item);
                }
            }

            _viewModel = tempModel;
            DataContext = _viewModel;
        }

        public void Add()
        {
            var newItem = new EmployeeStatus();
            var view = new EmployeeStatusView(newItem);
            if (view.ShowDialog() == true)
            {
                _lookup.Collection.Add(newItem);
                Refresh();
                _viewModel.SelectedItem = _viewModel.Collection.FirstOrDefault(item => item.Id == newItem.Id);
                if (_viewModel.SelectedItem != null) dataGrid1.ScrollIntoView(_viewModel.SelectedItem);
            }
        }

        public void Edit()
        {
            if (_viewModel.SelectedItem == null) return;

            var currentItem = new EmployeeStatus();
            currentItem.Read(_viewModel.SelectedItem.Id);
            var view = new EmployeeStatusView(currentItem);
            if (view.ShowDialog() == true)
            {
                _viewModel.SelectedItem.Read(currentItem.Id);
            }
        }

        public void Delete()
        {
            if (_viewModel.SelectedItem == null) return;

            const string message = "Do you really want to delete this record?";
            if (MessageBoxes.ShowConfirmation(message) == System.Windows.Forms.DialogResult.Yes)
            {
                var item = _viewModel.SelectedItem;
                var result = item.Destroy();
                if (!result.Success)
                {
                    MessageBoxes.ShowAlert(result.Message);
                    return;
                }
                _lookup.Collection.Remove(item);
                _viewModel.Collection.Remove(item);
                _viewModel.SelectedItem = null;
            }
        }

        #endregion
    }
}
