using PayrollSystem.Models;
namespace PayrollSystem.Views.WithholdingTaxDeductions
{
    /// <summary>
    /// Interaction logic for WithholdingTaxDeductionView.xaml
    /// </summary>
    public partial class WithholdingTaxDeductionView : ISaveable
    {
        private readonly WithholdingTaxDeduction _viewModel;
        public WithholdingTaxDeductionView(WithholdingTaxDeduction viewModel)
        {
            InitializeComponent();

            var taxGroups = DatabaseLibrary.ModelCollection.All<TaxGroup>();
            cboTaxGroup.ItemsSource = taxGroups;

            _viewModel = viewModel;
            DataContext = _viewModel;

            switch (_viewModel.PaymentType)
            {
                case "M":
                    optMonthly.IsChecked = true;
                    break;
                case "S":
                    optSemiMonthly.IsChecked = true;
                    break;
                case "W":
                    optWeekly.IsChecked = true;
                    break;
                case "D":
                    optDaily.IsChecked = true;
                    break;
            }

            btnSave.Content = _viewModel.Id == 0 ? "Create" : "Update";

            btnSave.Click += (sender, args) => Save();
            btnCancel.Click += (sender, args) => Close();
        }

        public void Save()
        {
            if (optMonthly.IsChecked == true) _viewModel.PaymentType = "M";
            else if (optSemiMonthly.IsChecked == true) _viewModel.PaymentType = "S";
            else if (optWeekly.IsChecked == true) _viewModel.PaymentType = "W";
            else if (optDaily.IsChecked == true) _viewModel.PaymentType = "D";

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
    }
}
