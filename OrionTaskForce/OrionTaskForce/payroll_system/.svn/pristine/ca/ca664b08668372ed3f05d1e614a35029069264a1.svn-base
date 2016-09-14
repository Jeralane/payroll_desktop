using PayrollSystem.Models;

namespace PayrollSystem.Views.Helpers
{
    /// <summary>
    /// Interaction logic for AddressView.xaml
    /// </summary>
    public partial class AddressView
    {
        private readonly Address _viewModel;

        public AddressView()
        {
            InitializeComponent();
            btnOk.Click += (sender, e) =>
                {
                    DialogResult = true;
                    AddressDetails = _viewModel;
                    Close();
                };

            btnCancel.Click += (sender, e) => Close();
        }

        public AddressView(Address address)
            : this()
        {
            _viewModel = address;
            DataContext = _viewModel;
        }

        public Address AddressDetails { get; set; }
    }
}