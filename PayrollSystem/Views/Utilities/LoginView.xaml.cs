using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Windows.Input;
using PayrollSystem.Controllers;
using PayrollSystem.Models;

namespace PayrollSystem.Views.Utilities
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView
    {
        public LoginView()
        {
            InitializeComponent();

            LayoutRoot.MouseLeftButtonDown += (sender, args) => DragMove();
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);

            lblVersion.Text = string.Format("Payroll System Version {0}", fileVersionInfo.FileVersion);
            btnCancel.Click += (s,e) => Close();
            btnOk.Click += (s, e) => Loggin();

            KeyDown += (s, e) =>
            {
                if (e.Key == Key.F5 && (Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                {
                    var view = new SwicthDatabaseView();
                    view.ShowDialog();
                }
            };

        }

        private int _attempts;
        private void Loggin()
        {
            try
            {
                using (var dbContext = new PayrollDbContext())
                {
                    var userName = txtUserName.Text;
                    var password = PayrollSystem.Helpers.DataConverter.GenerateMySQLHash(txtPassword.Password);

                    var user = dbContext.Users.FirstOrDefault(t => t.Name == userName && t.Password == password);
                    if (user != null)
                    {
                        MainController.ShowMainWindow(user);
                        Close();
                    }
                    else
                    {
                        _attempts++;
                        MessageBoxes.ShowAlert("Access Denied! Username and password combination is not valid!");
                        if (_attempts < 3) return;
                        MessageBoxes.ShowAlert("Access Denied! Unauthorized user!");
                        Environment.Exit(0);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBoxes.ShowAlert(exception.Message);
            }
        }
    }
}
