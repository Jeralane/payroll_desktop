using System.Data;
using DatabaseLibrary;
using PayrollSystem.Models;

namespace PayrollSystem.Views.Payrolls
{
    public partial class PayrollsList
    {
        public PayrollsList()
        {
            InitializeComponent();
            Refresh();

            txtFilterByKeyword.Search += (sender, args) => Refresh();

            btnEditSelected.Click += (s, e) => ShowPayrollDetails();

            //btnComputePayroll.Click += (s, e) => ManageAttendance();
        }

        public void ManageAttendance()
        {
            var item = new Detachment();
            var selectedItem = dataGrid1.SelectedItem;
            if (selectedItem == null) return;

            var row = (DataRowView) selectedItem;
            item.Read((int) row["detachment_id"]);
            var view = new PayrollsPerDetachmentView(item);
            if (view.ShowDialog() == true)
            {
                Refresh();
            }
        }

        private void OnDataGridRowMouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ShowPayrollDetails();
        }

        public void Refresh()
        {
            var dataTable = DatabaseHelper.ExecuteStoredProcedure("sp_payrolls_list", new SqlParameter("?keyword", txtFilterByKeyword.Text));
            dataGrid1.ItemsSource = dataTable.DefaultView;

            var model = new Preferences.PreferenceViewModel();
            model.Read();
            CurrentPayrollPeriodPanel.DataContext = model.CurrentPayrollPeriod;
        }

        private void ShowPayrollDetails()
        {
            var selectedItem = dataGrid1.SelectedItem;
            if (selectedItem == null) return;

            var row = (DataRowView)selectedItem;
            var item = new Payroll();
            item.Read((int)row["payroll_id"]);
            var view = new PayrollView(item);
            if (view.ShowDialog() == true)
            {
                Refresh();
            }
        }
    }
}