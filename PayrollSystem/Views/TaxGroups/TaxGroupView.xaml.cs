using DatabaseLibrary;

namespace PayrollSystem.Views.TaxGroups
{
    /// <summary>
    /// Interaction logic for TaxGroupView.xaml
    /// </summary>
    public partial class TaxGroupView
    {
        public TaxGroupView(AbstractModel viewModel)
        {
            #region --- Initialize ---

            InitializeComponent();

            ViewModel = viewModel;
            DataContext = ViewModel;

            btnSave.Content = ViewModel.Id == 0 ? "Create" : "Update";
            btnSave.Click += (sender, args) => Save();
            btnCancel.Click += (sender, args) => Close();

            #endregion --- Initialize ---
        }
    }
}
