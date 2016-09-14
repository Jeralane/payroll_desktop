using System.ComponentModel;
using System.Text;
using PayrollSystem.Models;

namespace PayrollSystem.Views.SssContributions
{
    internal class SssContributionsViewModel : AbstractViewModel
    {
        private SssContribution _selectedItem;

        public System.Collections.ObjectModel.ObservableCollection<SssContribution> Collection { get; set; }

        public SssContribution SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                OnPropertyChanged("SelectedItem");
            }
        }
        public void Initialize()
        {
            RefreshCollection();
        }

        public override void RefreshCollection()
        {
            Collection = DatabaseLibrary.ModelCollection.All<SssContribution>();
        }

        #region --- Module Description ---

        public string ModuleName
        {
            get { return "SSS Contributions"; }
        }

        public string Description
        {
            get
            {
                var builder = new StringBuilder();
                builder.Append("Here is a matrix of all SSS Contributions. ");
                builder.Append("To filter, enter a minimum value and maximum value separated by dash ");
                builder.Append("(100 - 200).");
                return builder.ToString();
            }
        }

        #endregion

    }
}
