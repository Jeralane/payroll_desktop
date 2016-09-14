using System;
using System.Data.Entity.Migrations;
using System.Linq;
using PayrollSystem.Models;

namespace PayrollSystem.Views.Users
{
    /// <summary>
    /// Interaction logic for UserView.xaml
    /// </summary>
    public partial class UserView : ISaveable
    {
        private readonly User _viewModel;
        public UserView(User viewModel)
        {
            InitializeComponent();

            _viewModel = viewModel;
            DataContext = _viewModel;

            //btnSave.Content = _viewModel.Id == 0 ? "Create" : "Update";

            btnSave.Click += (sender, args) => Save();
            btnCancel.Click += (sender, args) => Close();

            cboUserAccess.Items.Add("USER");
            cboUserAccess.Items.Add("ADMINISTRATOR");
        }

        public void Save()
        {
            try
            {
                using (var dbContext = new PayrollDbContext())
                {
                    dbContext.Users.AddOrUpdate(_viewModel);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                MessageBoxes.ShowAlert(exception.GetInnerExceptions().Last().Message);
                return;
            }
            DialogResult = true;
            Close();
        }
    }
}
