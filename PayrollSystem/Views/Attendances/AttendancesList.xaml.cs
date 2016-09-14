using System.Data;
using DatabaseLibrary;
using PayrollSystem.Models;
using PayrollSystem.Views.Attendances;

namespace PayrollSystem.Views.Attendances
{
    public partial class AttendancesList
    {
        public AttendancesList()
        {
            InitializeComponent();
            Refresh();

            txtFilterByKeyword.Search += (sender, args) => Refresh();
            btnManage.Click += (s, e) => ManageAttendance();
        }

        public void ManageAttendance()
        {
            var item = new Detachment();
            var selectedItem = dataGrid1.SelectedItem;
            if (selectedItem == null) return;

            var row = (DataRowView) selectedItem;
            item.Read((int) row["detachment_id"]);
            var view = new AttendancesPerDetachmentView(item);
            if (view.ShowDialog() == true)
            {
                Refresh();
            }
        }

        public void Refresh()
        {
            var dataTable = DatabaseHelper.ExecuteStoredProcedure("sp_attendances_list", new SqlParameter("?keyword", txtFilterByKeyword.Text));
            dataGrid1.ItemsSource = dataTable.DefaultView;

            var model = new Preferences.PreferenceViewModel();
            model.Read();
            CurrentPayrollPeriodPanel.DataContext = model.CurrentPayrollPeriod;
        }
    }
}