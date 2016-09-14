﻿using PayrollSystem.Models;
namespace PayrollSystem.Views.Billings
{
    /// <summary>
    /// Interaction logic for BillingView.xaml
    /// </summary>
    public partial class BillingView : ISaveable
    {
        private readonly Billing _viewModel;
        public BillingView(Billing viewModel)
        {
            InitializeComponent();

            _viewModel = viewModel;
            DataContext = _viewModel;

            btnSave.Content = _viewModel.Id == 0 ? "Create" : "Update";

            btnSave.Click += (sender, args) => Save();
            btnCancel.Click += (sender, args) => Close();
        }

        public void Save()
        {
            if (_viewModel.Id == 0)
            {
                var result = _viewModel.Create();
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
                var result = _viewModel.Update();
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
