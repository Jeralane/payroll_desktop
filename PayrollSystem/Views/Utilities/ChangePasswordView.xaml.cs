namespace PayrollSystem.Views.Utilities
{
    /// <summary>
    /// Interaction logic for ChangePasswordView.xaml
    /// </summary>
    public partial class ChangePasswordView
    {
        private readonly Models.User _loggedUser;
        public ChangePasswordView(Models.User loggedUser)
        {
            InitializeComponent();

            _loggedUser = loggedUser;
            btnCancel.Click += (s, e) => Close();
            btnUpdate.Click += (s, e) => ChangeUserPassword();
        }

        private void ChangeUserPassword()
        {
            //var oldPassword = pwdOldPassword.Password;
            //var userId = Models.User.FindMatch(_loggedUser.Name, oldPassword);
            //if (_loggedUser.Id != userId)
            //{
            //    MessageBoxes.ShowAlert("Old password is not correct.");
            //    return;
            //}

            //var newPassword = pwdNewPassword.Password;
            //var retypedPassword = pwdRetypeNewPassword.Password;

            //if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(retypedPassword))
            //{
            //    MessageBoxes.ShowAlert("New Password and Re-typed Password cannot be empty.");
            //    return;
            //}

            //if (newPassword != retypedPassword)
            //{
            //    MessageBoxes.ShowAlert("New Password and Re-typed Password are not correct.");
            //    return;
            //}

            //var result = Models.User.UpdatePassword(_loggedUser, newPassword);
            //if (result.Success)
            //{
            //    MessageBoxes.ShowNotification(result.Message);
            //    Close();
            //}
            //else
            //{
            //    MessageBoxes.ShowAlert(result.Message);
            //}
        }
    }
}
