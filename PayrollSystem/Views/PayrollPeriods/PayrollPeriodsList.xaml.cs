using System;
using System.Data;
using System.Linq;
using DatabaseLibrary;
using PayrollSystem.Models;

namespace PayrollSystem.Views.PayrollPeriods
{
    public partial class PayrollPeriodsList : IManageModel
    {
        public PayrollPeriodsList()
        {
            InitializeComponent();
            Refresh();

            txtFilterByKeyword.Search += (sender, args) => Refresh();
            btnAdd.Click += (sender, args) => Add();
            btnEdit.Click += (sender, args) => Edit();
            btnDelete.Click += (sender, args) => Delete();
        }

        #region Implementation of IViewable

        public void Add()
        {
            var newItem = new PayrollPeriod();
            var view = new PayrollPeriodView(newItem);
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
                    var item = new PayrollPeriod { Id = ((PayrollPeriod)selectedItem).Id };
                    dbContext.PayrollPeriods.Attach(item);
                    dbContext.PayrollPeriods.Remove(item);
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
                var item = (PayrollPeriod)selectedItem;
                using (var dbContext = new PayrollDbContext())
                {
                    var currentItem = dbContext.PayrollPeriods.Find(item.Id);
                    var view = new PayrollPeriodView(currentItem);
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
                var data = dbContext.PayrollPeriods.Where(t => t.Description.Contains(txtFilterByKeyword.Text)).ToList();
                dataGrid1.ItemsSource = data;
            }
        }

        #endregion
    }
}
