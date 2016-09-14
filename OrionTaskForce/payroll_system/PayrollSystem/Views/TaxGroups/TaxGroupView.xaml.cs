using PayrollSystem.Models;

namespace PayrollSystem.Views.TaxGroups
{
    /// <summary>
    /// Interaction logic for TaxGroupView.xaml
    /// </summary>
    public partial class TaxGroupView : ISaveable
    {
        private readonly TaxGroup _viewModel;
        public TaxGroupView(TaxGroup viewModel)
        {
            InitializeComponent();

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
