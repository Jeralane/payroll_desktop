using DatabaseLibrary;

namespace PayrollSystem.Models
{
    public class TaxGroup : AbstractModel
    {
        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; OnPropertyChanged("Description"); }
        }

        public override string ToString()
        {
            return Description;
        }
    }

}
