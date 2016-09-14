using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.Models;

namespace PayrollSystem.Controllers
{
    internal static class MainController
    {
        public static User LoggedUser;

        public static void ShowMainWindow(User loggedUser)
        {
            LoggedUser = loggedUser;
            var mainWindow = new Views.MainView(loggedUser);
            mainWindow.Show();
        }
    }
}
