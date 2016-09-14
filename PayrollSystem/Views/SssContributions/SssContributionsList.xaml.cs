using System;
using System.Data;
using DatabaseLibrary;
using PayrollSystem.Models;

namespace PayrollSystem.Views.SssContributions
{
    public partial class SssContributionsList : IManageModel
    {
        public SssContributionsList()
        {
            InitializeComponent();

            Refresh();

            txtFilterByKeyword.Search += (sender, args) => Refresh();
            btnAdd.Click += (sender, args) => Add();
            btnEdit.Click += (sender, args) => Edit();
            btnDelete.Click += (sender, args) => Delete();
        }

        #region Implementation of IViewable

        public void Add()
        {
            var newItem = new SssContribution();
            var view = new SssContributionView(newItem);
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
                var item = new SssContribution();
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
            var item = new SssContribution();
            item.Read((int)row["id"]);

            var view = new SssContributionView(item);
            if (view.ShowDialog() == true)
            {
                Refresh();
            }
        }

        public void Refresh()
        {
            decimal amount;
            try
            {
                amount = Convert.ToDecimal(txtFilterByKeyword.Text);
            }
            catch (Exception)
            {
                amount = 0m;
            }
            var dataTable = DatabaseHelper.ExecuteStoredProcedure("sp_sss_contributions_list", new SqlParameter("?keyword", amount));
            dataGrid1.ItemsSource = dataTable.DefaultView;
        }

        #endregion
    }
}