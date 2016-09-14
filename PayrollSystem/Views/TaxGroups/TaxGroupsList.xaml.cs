using System.Data;
using DatabaseLibrary;
using PayrollSystem.Models;

namespace PayrollSystem.Views.TaxGroups
{
    public partial class TaxGroupsList : IManageModel
    {
        public TaxGroupsList()
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
            var newItem = new TaxGroup();
            var view = new TaxGroupView(newItem);
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
                var item = new TaxGroup();
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
            var item = new TaxGroup();
            item.Read((int)row["id"]);

            var view = new TaxGroupView(item);
            if (view.ShowDialog() == true)
            {
                Refresh();
            }
        }

        public void Refresh()
        {
            var dataTable = DatabaseHelper.ExecuteStoredProcedure("sp_tax_groups_list", new SqlParameter("?keyword", txtFilterByKeyword.Text));
            dataGrid1.ItemsSource = dataTable.DefaultView;
        }

        #endregion
    }
}
