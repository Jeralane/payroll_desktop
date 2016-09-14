﻿using System.Data;
using DatabaseLibrary;
using PayrollSystem.Models;

namespace PayrollSystem.Views.SssLoans
{
    public partial class SssLoansList : IManageModel
    {

        public SssLoansList()
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
            var newItem = new SssLoan();
            var view = new SssLoanView(newItem);
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
                var row = (DataRowView) selectedItem;
                var item = new SssLoan();
                item.Read((int) row["id"]);

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
            var item = new SssLoan();
            item.Read((int)row["id"]);

            var view = new SssLoanView(item);
            if (view.ShowDialog() == true)
            {
               Refresh();
            }
        }

        public void Refresh()
        {
            var dataTable = DatabaseHelper.ExecuteStoredProcedure("sp_sss_loans_list", new SqlParameter("?keyword", txtFilterByKeyword.Text));
            dataGrid1.ItemsSource = dataTable.DefaultView;
        }

        #endregion
    }
}