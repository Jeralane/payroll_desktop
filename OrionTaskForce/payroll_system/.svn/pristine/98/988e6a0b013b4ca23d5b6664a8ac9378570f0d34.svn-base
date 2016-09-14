using PayrollSystem.Models;
namespace PayrollSystem.Views.PayrollPeriods
{
    /// <summary>
    /// Interaction logic for PayrollPeriodView.xaml
    /// </summary>
    public partial class PayrollPeriodView : ISaveable
    {
        private readonly PayrollPeriod _viewModel;
        public PayrollPeriodView(PayrollPeriod viewModel)
        {
            InitializeComponent();

            _viewModel = viewModel;
            DataContext = _viewModel;

            btnSave.Content = _viewModel.Id == 0 ? "Create" : "Update";

            btnSave.Click += (sender, args) => Save();
            btnCancel.Click += (sender, args) => Close();

            dtpFromDate.SelectedDateChanged += (sender, args) => GenerateAttributes();
            dtpToDate.SelectedDateChanged += (sender, args) => GenerateAttributes();
        }

        public void Save()
        {
            if (_viewModel.Id == 0)
            {
                var result = _viewModel.Create();
                if (!result.Success)
                {
                    MessageBoxes.ShowAlert(result.Message);
                    return;
                }

                DialogResult = true;
                Close();
            }
            else
            {
                var result = _viewModel.Update();
                if (!result.Success)
                {
                    MessageBoxes.ShowAlert(result.Message);
                    return;
                }

                DialogResult = true;
                Close();
            }
        }

        private void GenerateAttributes()
        {
            _viewModel.ThisMonth = _viewModel.FromDate.Month;
            _viewModel.ThisYear = _viewModel.FromDate.Year;
            _viewModel.WorkingDays = _viewModel.ToDate.Subtract(_viewModel.FromDate).Days + 1;
            _viewModel.Description = string.Format("{0} {1}-{2}, {3}", _viewModel.FromDate.ToString("MMMM"),
                                                   _viewModel.FromDate.Day, _viewModel.ToDate.Day,
                                                   _viewModel.FromDate.Year);
        }
    }
}
