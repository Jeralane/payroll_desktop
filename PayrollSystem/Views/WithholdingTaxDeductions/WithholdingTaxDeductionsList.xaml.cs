using System.Data;
using DatabaseLibrary;
using PayrollSystem.Models;

namespace PayrollSystem.Views.WithholdingTaxDeductions
{
    public partial class WithholdingTaxDeductionsList : IManageModel
    {
        public WithholdingTaxDeductionsList()
        {
            InitializeComponent();
            Refresh();

            btnAdd.Click += (sender, args) => Add();
            btnEdit.Click += (sender, args) => Edit();
            btnDelete.Click += (sender, args) => Delete();
        }

        #region Implementation of IViewable

        public void Add()
        {
            var newItem = new WithholdingTaxDeduction();
            var view = new WithholdingTaxDeductionView(newItem);
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
                var item = new WithholdingTaxDeduction();
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
            var item = new WithholdingTaxDeduction();
            item.Read((int)row["id"]);

            var view = new WithholdingTaxDeductionView(item);
            if (view.ShowDialog() == true)
            {
                Refresh();
            }
        }

        public void Refresh()
        {
            var dataTable = DatabaseHelper.ExecuteStoredProcedure("sp_withholding_tax_deductions_list");
            dataGrid1.ItemsSource = dataTable.DefaultView;
        }

        #endregion
    }
}
