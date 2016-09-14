using System;
using System.Linq;
using PayrollSystem.Helpers;
using PayrollSystem.Models;

namespace PayrollSystem.Views.Users
{
    public partial class UsersList : IManageModel
    {
        public UsersList()
        {
            InitializeComponent();
            Refresh();

            txtFilterByKeyword.Search += (sender, args) => Refresh();
            btnAdd.Click += (sender, args) => Add();
            btnEdit.Click += (sender, args) => Edit();
            btnDelete.Click += (sender, args) => Delete();
            btnResetPassword.Click += (sender, e) => ResetPassword();
        }

        private void ResetPassword()
        {
            var selectedItem = dataGrid1.SelectedItem;
            if (selectedItem == null) return;

            if (MessageBoxes.ShowConfirmation("Reset password for selected user?") !=
                System.Windows.Forms.DialogResult.Yes) return;

            try
            {
                var item = (User) selectedItem;
                using (var dbContext = new PayrollDbContext())
                {
                    var user = dbContext.Users.Find(item.ID);
                    user.Password = DataConverter.GenerateMySQLHash("password");
                    dbContext.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                MessageBoxes.ShowAlert(exception.Message);
            }
        }

        #region Implementation of IViewable

        public void Add()
        {
            var newItem = new User {Password = DataConverter.GenerateMySQLHash("password")};
            var view = new UserView(newItem);
            if (view.ShowDialog() == true)
            {
                Refresh();
            }
        }

        public void Delete()
        {
            var selectedItem = dataGrid1.SelectedItem;
            if (selectedItem == null) return;

            const string message = "Do you really want to delete this record?";
            if (MessageBoxes.ShowConfirmation(message) != System.Windows.Forms.DialogResult.Yes) return;
            try
            {
                using (var dbContext = new PayrollDbContext())
                {
                    var user = new User {ID = ((User) selectedItem).ID};
                    dbContext.Users.Attach(user);
                    dbContext.Users.Remove(user);
                    dbContext.SaveChanges();
                }
                Refresh();
            }
            catch (Exception exception)
            {
                MessageBoxes.ShowAlert(exception.GetInnerExceptions().Last().Message);
            }
        }

        public void Edit()
        {
            var selectedItem = dataGrid1.SelectedItem;
            if (selectedItem == null) return;

            try
            {
                var item = (User) selectedItem;
                using (var dbContext = new PayrollDbContext())
                {
                    var user = dbContext.Users.Find(item.ID);
                    var view = new UserView(user);
                    if (view.ShowDialog() == true)
                    {
                        Refresh();
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBoxes.ShowAlert(exception.Message);
            }
        }

        public void Refresh()
        {
            using (var dbContext = new PayrollDbContext())
            {
                var data = dbContext.Users.Where(t => t.Name.Contains(txtFilterByKeyword.Text)).ToList();
                dataGrid1.ItemsSource = data;
            }
        }

        #endregion
    }
}