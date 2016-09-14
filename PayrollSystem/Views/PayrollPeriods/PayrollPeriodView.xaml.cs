using DatabaseLibrary;
using PayrollSystem.Models;
namespace PayrollSystem.Views.PayrollPeriods
{
    /// <summary>
    /// Interaction logic for PayrollPeriodView.xaml
    /// </summary>
    public partial class PayrollPeriodView
    {
        public PayrollPeriodView(AbstractModel viewModel)
        {
            #region --- Initialize ---

            InitializeComponent();

            ViewModel = viewModel;
            DataContext = ViewModel;

            btnSave.Content = ViewModel.Id == 0 ? "Create" : "Update";
            btnSave.Click += (sender, args) => Save();
            btnCancel.Click += (sender, args) => Close();

            #endregion --- Initialize ---

            dtpFromDate.SelectedDateChanged += (sender, args) => GenerateAttributes();
            dtpToDate.SelectedDateChanged += (sender, args) => GenerateAttributes();
        }

        private void GenerateAttributes()
        {
            ((PayrollPeriod)ViewModel).ThisMonth = ((PayrollPeriod)ViewModel).FromDate.Month;
            ((PayrollPeriod)ViewModel).ThisYear = ((PayrollPeriod)ViewModel).FromDate.Year;
            ((PayrollPeriod)ViewModel).WorkingDays = ((PayrollPeriod)ViewModel).ToDate.Subtract(((PayrollPeriod)ViewModel).FromDate).Days + 1;
            ((PayrollPeriod)ViewModel).Description = string.Format("{0} {1}-{2}, {3}", ((PayrollPeriod)ViewModel).FromDate.ToString("MMMM"),
                                                   ((PayrollPeriod)ViewModel).FromDate.Day, ((PayrollPeriod)ViewModel).ToDate.Day,
                                                   ((PayrollPeriod)ViewModel).FromDate.Year);
        }
    }
}
