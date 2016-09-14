using PayrollSystem.Models;
namespace PayrollSystem.Views.WithholdingTaxDeductions
{
    /// <summary>
    /// Interaction logic for WithholdingTaxDeductionView.xaml
    /// </summary>
    public partial class WithholdingTaxDeductionView : ISaveable
    {
        public WithholdingTaxDeductionView(WithholdingTaxDeduction viewModel)
        {
            #region --- Initialize ---

            InitializeComponent();

            ViewModel = viewModel;
            DataContext = ViewModel;

            btnSave.Content = ViewModel.Id == 0 ? "Create" : "Update";
            btnSave.Click += (sender, args) => Save();
            btnCancel.Click += (sender, args) => Close();

            #endregion --- Initialize ---

            optMonthly.Checked += (s, e) => UpdatePaymentType();

            var taxGroups = DatabaseLibrary.ModelCollection.All<TaxGroup>();
            cboTaxGroup.ItemsSource = taxGroups;

            switch (((WithholdingTaxDeduction)ViewModel).PaymentType)
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
        }

        private void UpdatePaymentType()
        {
            if (optMonthly.IsChecked == true)
            {
                ((WithholdingTaxDeduction) ViewModel).PaymentType = "M";
                return;
            }
            if (optSemiMonthly.IsChecked == true)
            {
                ((WithholdingTaxDeduction) ViewModel).PaymentType = "S";
                return;
            }
            if (optWeekly.IsChecked == true)
            {
                ((WithholdingTaxDeduction) ViewModel).PaymentType = "W";
                return;
            }
            if (optDaily.IsChecked == true)
            {
                ((WithholdingTaxDeduction) ViewModel).PaymentType = "D";
            }
        }
    }
}
