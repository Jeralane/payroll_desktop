using System;
using System.Linq;
using PayrollSystem.Models;

namespace PayrollSystem.Views.PhilhealthContributions
{
    public partial class PhilhealthContributionsList : IManageModel
    {
        private PhilhealthContributionsViewModel _lookup = new PhilhealthContributionsViewModel();

        private PhilhealthContributionsViewModel _viewModel = new PhilhealthContributionsViewModel();

        public PhilhealthContributionsList()
        {
            InitializeComponent();

            Refresh();

            btnRefresh.Click += (sender, args) => Refresh();
            btnAdd.Click += (sender, args) => Add();
            btnEdit.Click += (sender, args) => Edit();
            btnDelete.Click += (sender, args) => Delete();
        }

        #region Implementation of IViewable

        public void Add()
        {
            var newItem = new PhilhealthContribution();
            var view = new PhilhealthContributionView(newItem);
            if (view.ShowDialog() == true)
            {
                _lookup.Collection.Add(newItem);
                Refresh();
                _viewModel.SelectedItem = _viewModel.Collection.FirstOrDefault(item => item.Id == newItem.Id);
                if (_viewModel.SelectedItem != null) dataGrid1.ScrollIntoView(_viewModel.SelectedItem);

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

        public void Edit()
        {
            if (_viewModel.SelectedItem == null) return;

            var currentItem = new PhilhealthContribution();
            currentItem.Read(_viewModel.SelectedItem.Id);
            var view = new PhilhealthContributionView(currentItem);
            if (view.ShowDialog() == true)
            {
                _viewModel.SelectedItem.Read(currentItem.Id);
            }
        }

        public void Refresh()
        {
            var tempModel = new PhilhealthContributionsViewModel();
            tempModel.RefreshCollection();

            var searchItem = txtFilterByKeyword.Text;
            if (searchItem.Length == 0)
            {
                _lookup.RefreshCollection();
                foreach (var item in _lookup.Collection)
                {
                    tempModel.Collection.Add(item);
                }
                _viewModel = tempModel;
                DataContext = _viewModel;
                return;

            }

            if (searchItem.Contains("-"))
            {
                var values = searchItem.Split('-');
                if (values.Count() == 2)
                {

                    try
                    {
                        var min = Convert.ToDecimal(values[0]);
                        var max = Convert.ToDecimal(values[1]);

                        var filteredItem = from item in _lookup.Collection
                            where item.Minimum >= min && item.Maximum <= max
                            select item;

                        foreach (var item in filteredItem)
                        {
                            tempModel.Collection.Add(item);
                        }

                        _viewModel = tempModel;
                        DataContext = _viewModel;

                        return;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
            }

            MessageBoxes.ShowAlert("Invalid filter format.");
        }

        #endregion
    }
}