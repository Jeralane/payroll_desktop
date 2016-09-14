using PayrollSystem.Models;
namespace PayrollSystem.Views.FixedDeductions
{
    /// <summary>
    /// Interaction logic for FixedDeductionView.xaml
    /// </summary>
    public partial class FixedDeductionView : ISaveable
    {
        private readonly FixedDeduction _viewModel;
        public FixedDeductionView()
        {
            InitializeComponent();

            // There is only one record for FixedDeduction
            var viewModel = new FixedDeduction();
            viewModel.Read(1);
            
            _viewModel = viewModel;
            DataContext = _viewModel;

            btnSave.Content = _viewModel.Id == 0 ? "Create" : "Update";

            btnSave.Click += (sender, args) => Save();
            btnCancel.Click += (sender, args) => Close();

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

                MessageBoxes.ShowNotification("Fixed Deductions has been created.");
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

                MessageBoxes.ShowNotification("Fixed Deductions has been updated.");
                DialogResult = true;
                Close();
            }
        }
    }
}
