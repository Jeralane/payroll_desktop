using System.Windows;

namespace PayrollSystem.Views.Utilities
{
    /// <summary>
    /// Interaction logic for SwicthDatabaseView.xaml
    /// </summary>
    public partial class SwicthDatabaseView
    {
        public SwicthDatabaseView()
        {
            InitializeComponent();

            btnApply.Click += (s, e) => SwitchDatabase();

        }

        private void SwitchDatabase()
        {
            var server = txtServer.Text;
            var database = txtDatabase.Text;
            DatabaseLibrary.DatabaseHelper.SwitchDatabase(server, database);
            Close();
        }
    }
}
