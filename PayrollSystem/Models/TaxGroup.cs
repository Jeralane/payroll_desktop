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

        public override DatabaseLibrary.ActionResult Validate()
        {
            if (string.IsNullOrEmpty(Description))
                return new DatabaseLibrary.ActionResult(false, "Description is required.");

            return base.Validate();
        }
    }
}