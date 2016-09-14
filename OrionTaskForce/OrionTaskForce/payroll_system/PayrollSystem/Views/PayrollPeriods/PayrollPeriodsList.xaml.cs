using System;
using System.Linq;
using System.Collections.ObjectModel;
using PayrollSystem.Models;

namespace PayrollSystem.Views.PayrollPeriods
{
    public partial class PayrollPeriodsList : IManageModel
    {
        private PayrollPeriodsViewModel _viewModel = new PayrollPeriodsViewModel();
        private PayrollPeriodsViewModel _lookup = new PayrollPeriodsViewModel();
        public PayrollPeriodsList()
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
            var tempModel = new PayrollPeriodsViewModel();
            tempModel.Collection = new ObservableCollection<PayrollPeriod>();

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
            var newItem = new PayrollPeriod();
            newItem.FromDate = DateTime.Now;
            newItem.ToDate = DateTime.Now;
            newItem.GenerateAttributes();

            
            var view = new PayrollPeriodView(newItem);
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

            var currentItem = new PayrollPeriod();
            currentItem.Read(_viewModel.SelectedItem.Id);
            var view = new PayrollPeriodView(currentItem);
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
