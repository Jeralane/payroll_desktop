using System.Data;
using DatabaseLibrary;
using PayrollSystem.Models;

namespace PayrollSystem.Views.Assignments
{
    public partial class AssignmentsList
    {
        public AssignmentsList()
        {
            InitializeComponent();
            Refresh();

            txtFilterByKeyword.Search += (sender, args) => Refresh();
            btnManage.Click += (s, e) => ManageAssignment();
        }

        public void ManageAssignment()
        {
            var item = new Detachment();
            var selectedItem = dataGrid1.SelectedItem;
            if (selectedItem == null) return;

            var row = (DataRowView) selectedItem;
            item.Read((int) row["detachment_id"]);
            var view = new AssignmentsPerDetachmentView(item);
            if (view.ShowDialog() == true)
            {
                Refresh();
            }
        }

        public void Refresh()
        {
            var dataTable = DatabaseHelper.ExecuteStoredProcedure("sp_assignments_list", new SqlParameter("?keyword", txtFilterByKeyword.Text));
            dataGrid1.ItemsSource = dataTable.DefaultView;

            var model = new Preferences.PreferenceViewModel();
            model.Read();
            CurrentPayrollPeriodPanel.DataContext = model.CurrentPayrollPeriod;
        }
    }
}