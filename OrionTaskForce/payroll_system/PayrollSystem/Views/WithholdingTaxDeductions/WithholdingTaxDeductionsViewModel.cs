using System.Collections.ObjectModel;
using PayrollSystem.Models;

namespace PayrollSystem.Views.WithholdingTaxDeductions
{
    internal class WithholdingTaxDeductionsViewModel : AbstractViewModel
    {
        private WithholdingTaxDeduction _selectedItem;

        public ObservableCollection<WithholdingTaxDeduction> Collection { get; set; }

        public WithholdingTaxDeduction SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                OnPropertyChanged("SelectedItem");
            }
        }

        public override void RefreshCollection()
        {
            Collection = DatabaseLibrary.ModelCollection.All<WithholdingTaxDeduction>();
        }



        #region --- Module Description ---

        public string ModuleName
        {
            get { return "Philhealth Contributions"; }
        }

        public string Description
        {
            get
            {
                var builder = new System.Text.StringBuilder();
                builder.Append("Here is a matrix of all Philhealth Contributions. ");
                builder.Append("To filter, enter a minimum value and maximum value separated by dash ");
                builder.Append("(100 - 200).");
                return builder.ToString();
            }
        }

        #endregion

    }
}
