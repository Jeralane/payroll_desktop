using System.Data;
using DatabaseLibrary;
using PayrollSystem.Models;

namespace PayrollSystem.Views.Employees
{
    public partial class EmployeesList : IManageModel
    {

        public EmployeesList()
        {
            InitializeComponent();
            Refresh();

            txtFilterByKeyword.Search += (sender, args) => Refresh();
            btnAdd.Click += (sender, args) => Add();
            btnEdit.Click += (sender, args) => Edit();
            btnDelete.Click += (sender, args) => Delete();
        }

        //#region Implementation of IViewable

        //public void Refresh()
        //{
        //    var tempModel = new EmployeesViewModel();
        //    tempModel.Collection = new ObservableCollection<Employee>();

        //    var searchItem = txtFilterByKeyword.Text;
        //    if (searchItem.Trim().Length == 0)
        //    {
        //        foreach (var item in _lookup.Collection)
        //        {
        //            tempModel.Collection.Add(item);
        //        }
        //    }
        //    else
        //    {
        //        var filteredItem = from item in _lookup.Collection
        //                           where (item.LastName + item.FirstName + item.MiddleName).ToLower().Contains(searchItem.ToLower())
        //                           select item;

        //        foreach (var item in filteredItem)
        //        {
        //            tempModel.Collection.Add(item);
        //        }
        //    }

        //    _viewModel = tempModel;
        //    DataContext = _viewModel;
        //}

        //public void Add()
        //{
        //    var newItem = new Employee();
        //    var view = new EmployeeView(newItem);
        //    if (view.ShowDialog() == true)
        //    {
        //        _lookup.Collection.Add(newItem);
        //        Refresh();
        //        _viewModel.SelectedItem = _viewModel.Collection.FirstOrDefault(item => item.Id == newItem.Id);
        //        if (_viewModel.SelectedItem != null) dataGrid1.ScrollIntoView(_viewModel.SelectedItem);
        //    }
        //}

        //public void Edit()
        //{
        //    if (_viewModel.SelectedItem == null) return;

        //    var currentItem = new Employee();
        //    currentItem.Read(_viewModel.SelectedItem.Id);
        //    var view = new EmployeeView(currentItem);
        //    if (view.ShowDialog() == true)
        //    {
        //        _viewModel.SelectedItem.Read(currentItem.Id);
        //    }
        //}

        //public void Delete()
        //{
        //    if (_viewModel.SelectedItem == null) return;

        //    const string message = "Do you really want to delete this record?";
        //    if (MessageBoxes.ShowConfirmation(message) == System.Windows.Forms.DialogResult.Yes)
        //    {
        //        var item = _viewModel.SelectedItem;
        //        var result = item.Destroy();
        //        if (!result.Success)
        //        {
        //            MessageBoxes.ShowAlert(result.Message);
        //            return;
        //        }
        //        _lookup.Collection.Remove(item);
        //        _viewModel.Collection.Remove(item);
        //        _viewModel.SelectedItem = null;
        //    }
        //}

        //#endregion Implementation of IViewable


        #region Implementation of IViewable

        public void Add()
        {
            var newItem = new Employee();
            var view = new EmployeeView(newItem);
            if (view.ShowDialog() == true)
            {
                Refresh();
            }
        }

        public void Delete()
        {
            var selectedItem = dataGrid1.SelectedItem;
            if (selectedItem == null) return;

            const string message = "Do you really want to delete this record?";
            if (MessageBoxes.ShowConfirmation(message) == System.Windows.Forms.DialogResult.Yes)
            {
                var row = (DataRowView)selectedItem;
                var item = new Employee();
                item.Read((int)row["id"]);

                var result = item.Destroy();
                if (!result.Success)
                {
                    MessageBoxes.ShowAlert(result.Message);
                    return;
                }
                Refresh();
            }
        }

        public void Edit()
        {
            var selectedItem = dataGrid1.SelectedItem;
            if (selectedItem == null) return;

            var row = (DataRowView)selectedItem;
            var item = new Employee();
            item.Read((int)row["id"]);

            var view = new EmployeeView(item);
            if (view.ShowDialog() == true)
            {
                Refresh();
            }
        }

        public void Refresh()
        {
            var dataTable = DatabaseHelper.ExecuteStoredProcedure("sp_employees_list", new SqlParameter("?keyword", txtFilterByKeyword.Text));
            dataGrid1.ItemsSource = dataTable.DefaultView;
        }

        #endregion
    }
}