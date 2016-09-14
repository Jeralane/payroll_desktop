using System.Linq;
using PayrollSystem.Models;
using PayrollSystem.Views.Helpers.SearchModule;

namespace PayrollSystem.Views.Preferences
{
    /// <summary>
    /// Interaction logic for PreferenceView.xaml
    /// </summary>
    public partial class PreferenceView : ISaveable
    {
        private readonly PreferenceViewModel _viewModel;
        public PreferenceView()
        {
            #region --- Initialize ---

            InitializeComponent();

            // There is only one record for Preference
            _viewModel = new PreferenceViewModel();
            _viewModel.Read();

            ViewModel = _viewModel.Preference;

            btnSave.Content = ViewModel.Id == 0 ? "Create" : "Update";
            btnSave.Click += (sender, args) => Save();
            btnCancel.Click += (sender, args) => Close();

            #endregion --- Initialize ---


            DataContext = _viewModel;
            btnSearchPayrollPeriod.Click += (s, e) => SearchPayrollPeriod();
        }

        private void SearchPayrollPeriod()
        {
            var models = DatabaseLibrary.ModelCollection.All<PayrollPeriod>();
            var searchItems = models.Select(item => new SearchItem(item.Id, item.Description)).ToList();
            var view = new SearchWindow(searchItems);
            if (view.ShowDialog() == true)
            {
                var id = view.SelectedItem.ItemId;
                _viewModel.Preference.CurrentPayrollPeriodId = id;
                _viewModel.CurrentPayrollPeriod.Read(id);
            }
        }
    }
}
