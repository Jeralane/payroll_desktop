using PayrollSystem.Helpers;
using PayrollSystem.Models;

namespace PayrollSystem.Views.Preferences
{
    internal class PreferenceViewModel : AbstractViewModel
    {
        private Preference _preference;
        private PayrollPeriod _currentPayrollPeriod;


        public PayrollPeriod CurrentPayrollPeriod
        {
            get { return _currentPayrollPeriod; }
            set { _currentPayrollPeriod = value; OnPropertyChanged("CurrentPayrollPeriod"); }
        }

        public Preference Preference
        {
            get { return _preference; }
            set { _preference = value; OnPropertyChanged("Preference"); }
        }

        public void Read()
        {
            var sql = "SELECT * FROM preferences LIMIT 1";
            var dataTable = DatabaseLibrary.DatabaseHelper.ExecuteSelectQuery(sql);
            foreach (System.Data.DataRow dataRow in dataTable.Rows)
            {
                var id = DataConverter.ToInteger(dataRow[GetColumnName("id")]);

                Preference = new Preference();
                Preference.Read(id);

                CurrentPayrollPeriod = new PayrollPeriod();
                CurrentPayrollPeriod.Read(Preference.CurrentPayrollPeriodId);
            }

        }

        private string GetColumnName(string propertyName)
        {
            return DatabaseLibrary.StringHelper.ToColumnName(propertyName);
        }
    }


}
