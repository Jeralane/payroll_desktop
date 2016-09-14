using System.Windows;

namespace PayrollSystem.Views.Billings
{
    /// <summary>
    /// Interaction logic for BillingsList.xaml
    /// </summary>
    public partial class BillingsList : Window
    {
        private readonly BillingsViewModel _viewModel = new BillingsViewModel();

        public BillingsList()
        {
            InitializeComponent();
            _viewModel.Initialize();

            DataContext = _viewModel;
        }
    }
}
