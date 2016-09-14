using System.Windows;

namespace PayrollSystem
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var view = new Views.Billings.BillingsList();
            view.ShowDialog();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            var view = new Views.TaxGroups.TaxGroupsList();
            view.ShowDialog();
        }
	}
}
