using System.Data;
using System.Linq;
using System.Windows.Input;
using DatabaseLibrary;
using PayrollSystem.Helpers;
using PayrollSystem.Models;
using PayrollSystem.Views.Helpers.SearchModule;
using PayrollSystem.Views.Preferences;

namespace PayrollSystem.Views.Assignments
{
    /// <summary>
    /// Interaction logic for AssignmentView.xaml
    /// </summary>
    public partial class AssignmentsPerDetachmentView
    {
        private Detachment _detachment;
        private readonly PreferenceViewModel _preference;

        public AssignmentsPerDetachmentView(Detachment detachment)
        {
            InitializeComponent();

            txtFilterByKeyword.Search += (sender, args) => Refresh();
            btnAdd.Click += (sender, args) => Add();
            btnEdit.Click += (sender, args) => Edit();
            btnDelete.Click += (sender, args) => Delete();

            KeyDown += AdminSearch;
            imgDetachment.MouseDown += (s, e) =>
                {
                    if (e.ChangedButton == MouseButton.Left && e.ClickCount == 2)
                    {
                        SearchDetachment();
                    }
                };

            _preference = new PreferenceViewModel();
            _preference.Read();

            CurrentPayrollPeriodPanel.DataContext = _preference.CurrentPayrollPeriod;

            if (detachment == null || detachment.Id == 0)
            {
                _detachment = new Detachment();
                _detachment.Name = "Please select a detachment";
                _detachment.Address = "Hint: Press Ctrl+F2 to search";
            }
            else
            {
                _detachment = detachment;
                Refresh();
            }
            SelectedDetachmentPanel.DataContext = _detachment;
        }

        private void AdminSearch(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F2 && (Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
            {
                SearchDetachment();
                return;
            }
            if (e.Key == Key.F3 && (Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
            {
                // SearchEmployee();
            }
        }

        private void SearchDetachment()
        {
            var models = ModelCollection.All<Detachment>();
            var searchItems = models.Select(item => new SearchItem(item.Id, item.Name)).ToList();
            var view = new SearchWindow(searchItems);
            if (view.ShowDialog() == true)
            {
                var id = view.SelectedItem.ItemId;
                _detachment = ModelFinder.GetDetachment(id);
                SelectedDetachmentPanel.DataContext = _detachment;
                Refresh();
            }
        }

        public void Refresh()
        {
            const string sp = "sp_employees_per_detachment";
            var parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("?detachment_id", _detachment.Id);
            parameters[1] = new SqlParameter("?keyword", txtFilterByKeyword.Text);
            var dataTable = DatabaseHelper.ExecuteStoredProcedure(sp, parameters);
            dataGrid1.ItemsSource = dataTable.DefaultView;
        }

        #region Implementation of IViewable

        public void Add()
        {
            var payroll = new Payroll();
            payroll.PayrollPeriodId = _preference.CurrentPayrollPeriod.Id;
            payroll.DetachmentId = _detachment.Id;
            var view = new AssignmentView(payroll, _detachment);
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
                var item = new Payroll();
                item.Read((int)row["payroll_id"]);

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
            var payroll = new Payroll();
            payroll.Read((int)row["payroll_id"]);
            payroll.DetachmentId = _detachment.Id;

            var view = new AssignmentView(payroll, _detachment);
            if (view.ShowDialog() == true)
            {
                Refresh();
            }
        }

        #endregion Implementation of IViewable
    }
}