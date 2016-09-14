using System.Collections.ObjectModel;

namespace DatabaseLibrary
{
    public static class ModelCollection
    {
        public static ObservableCollection<T> All<T>() where T : AbstractModel, new()
        {
            var item = new T();

            var sql = "SELECT * FROM " + item.TableName() + " ORDER BY `id`";
            var collection = new ObservableCollection<T>();
            var dataTable = DatabaseHelper.ExecuteSelectQuery(sql);
            foreach (System.Data.DataRow dataRow in dataTable.Rows)
            {
                var model = new T();
                model.SetPropertiesFromDataRow(dataRow);
                collection.Add(model);
            }
            return collection;
        }

        public static T Find<T>(int id) where T : AbstractModel, new()
        {
            var item = new T();
            item.Read(id);

            return item;
        }

        public static ObservableCollection<T> Where<T>(string equation) where T : AbstractModel, new()
        {
            var item = new T();

            var sql = "SELECT * FROM " + item.TableName() + " WHERE (" + equation + ") ORDER BY `id`";
            var collection = new ObservableCollection<T>();
            var dataTable = DatabaseHelper.ExecuteSelectQuery(sql);
            foreach (System.Data.DataRow dataRow in dataTable.Rows)
            {
                var model = new T();
                model.SetPropertiesFromDataRow(dataRow);
                collection.Add(model);
            }
            return collection;
        }
    }
}
