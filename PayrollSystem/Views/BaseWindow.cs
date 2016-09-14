using System.Windows;

namespace PayrollSystem.Views
{
    public class BaseWindow : Window
    {
        protected DatabaseLibrary.AbstractModel ViewModel;

        public virtual void Save()
        {
            var validateResult = ViewModel.Validate();
            if (!validateResult.Success)
            {
                MessageBoxes.ShowAlert(validateResult.Message);
                return;
            }

            if (ViewModel.Id == 0)
            {
                var result = ViewModel.Create();
                if (!result.Success)
                {
                    MessageBoxes.ShowAlert(result.Message);
                    return;
                }

                DialogResult = true;
                Close();
            }
            else
            {
                var result = ViewModel.Update();
                if (!result.Success)
                {
                    MessageBoxes.ShowAlert(result.Message);
                    return;
                }

                DialogResult = true;
                Close();
            }
        }
    }
}
