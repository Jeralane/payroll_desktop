using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ModelsLibrary.Payroll
{
    public class TaxGroup : AbstractModel
    {
        private string _taxGroupName;
        public string TaxGroupName
        {
            get { return _taxGroupName; }
            set { _taxGroupName = value; OnPropertyChanged("TaxGroupName"); }
        }

        
    }

    public class TaxGroupCollection : ObservableCollection<TaxGroup>
    {
        public static TaxGroupCollection GetAll()
        {
            var collection = new TaxGroupCollection();
            const string sql = "SELECT * FROM TaxGroups";
            var dataTable = DatabaseController.ExecuteSelectQuery(sql);
            foreach (System.Data.DataRow dataRow in dataTable.Rows)
            {
                var item = new TaxGroup();
                item.SetPropertiesFromDataRow(dataRow);
                collection.Add(item);
            }

            return collection;
        }
    }
}
