using System.Windows.Forms;

namespace PayrollSystem.Views
{
    public static class MessageBoxes
    {
        public static DialogResult ShowNotification(string message)
        {
            const string title = "Notification";
            const MessageBoxButtons button = MessageBoxButtons.OK;
            const MessageBoxIcon icon = MessageBoxIcon.Information;
            return MessageBox.Show(message, title, button, icon);
        }

        public static DialogResult ShowAlert(string message)
        {
            const string title = "Alert";
            const MessageBoxButtons button = MessageBoxButtons.OKCancel;
            const MessageBoxIcon icon = MessageBoxIcon.Exclamation;
            return MessageBox.Show(message, title, button, icon);
        }

        public static DialogResult ShowConfirmation(string message)
        {
            const string title = "Confirmation";
            const MessageBoxButtons button = MessageBoxButtons.YesNo;
            const MessageBoxIcon icon = MessageBoxIcon.Question;
            return MessageBox.Show(message, title, button, icon);
        }

        public static DialogResult ShowWarning(string message)
        {
            const string title = "Confirmation";
            const MessageBoxButtons button = MessageBoxButtons.OKCancel;
            const MessageBoxIcon icon = MessageBoxIcon.Stop;
            return MessageBox.Show(message, title, button, icon);
        }
    }
}