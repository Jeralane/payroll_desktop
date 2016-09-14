using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ModelsLibrary
{
    /// <summary>
    /// The superclass of all models
    /// </summary>
    public abstract class AbstractModel: INotifyPropertyChanged
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; OnPropertyChanged("Id");}
        }

        public virtual void Create()
        {
            var table = new TableStruct(this);

            var fields = from f in table.Fields
                         where f.Key != "Id"
                         select (string.Format("`{0}`", f.Key));

            var values = from f in table.Fields
                         where f.Key != "Id"
                         select ("?" + f.Key);

            var sqlBuilder = new StringBuilder();
            sqlBuilder.AppendFormat("INSERT INTO `{0}` ({1}) VALUES ({2})", table.Name, string.Join(", ", fields),
                                    string.Join(", ", values));

            var sqlParameters = table.Fields.Select(field => new SqlParameter(field.Key, field.Value)).ToList();
            Id = DatabaseController.ExecuteInsertQuery(sqlBuilder.ToString(), sqlParameters.ToArray());
           
        }

        public virtual void Update()
        {
            var table = new TableStruct(this);

            var fields = from f in table.Fields
                         where f.Key != "Id"
                         select (string.Format("`{0}` = ?{0}", f.Key));

            var sqlBuilder = new StringBuilder();
            sqlBuilder.AppendFormat("UPDATE `{0}` SET {1} WHERE `Id` = {2}", table.Name, string.Join(", ", fields), Id);

            var sqlParameters = table.Fields.Where(field => field.Key != "Id").Select(field => new SqlParameter(field.Key, field.Value)).ToArray();
            DatabaseController.ExecuteNonQuery(sqlBuilder.ToString(), sqlParameters);

        }

        public virtual void Destroy()
        {
            var table = new TableStruct(this);

            var sqlBuilder = new StringBuilder();
            sqlBuilder.AppendFormat("DELETE FROM `{0}` WHERE `Id` = {1}", table.Name, Id);

            DatabaseController.ExecuteNonQuery(sqlBuilder.ToString());
        }

        public virtual void Read(int id)
        {
            Id = id;

            Type type = GetType();
            PropertyInfo[] properties = type.GetProperties();

            var table = new TableStruct(this);

            var sqlBuilder = new StringBuilder();
            sqlBuilder.AppendFormat("SELECT * FROM `{0}` WHERE `Id` = {1}", table.Name, Id);

            var dataTable = DatabaseController.ExecuteSelectQuery(sqlBuilder.ToString());

            if(dataTable.Rows.Count == 0)
            {
                // Iterate through class properties using Reflection
                foreach (PropertyInfo property in properties)
                {
                    var name = property.Name;

                    if (name.Contains("Number"))
                    {
                        property.SetValue(this, 0, null);
                        continue;
                    }
                    if (name.Contains("Amount"))
                    {
                        property.SetValue(this, 0m, null);
                        continue;
                    }
                    if (name.Contains("Date"))
                    {
                        property.SetValue(this, new DateTime(), null);
                        continue;
                    }
                    if (name.Contains("Id"))
                    {
                        property.SetValue(this, 0, null);
                        continue;
                    }
                    if (name.Contains("Is"))
                    {
                        property.SetValue(this, false, null);
                        continue;
                    }
                    property.SetValue(this, "", null);
                }
                return;
            }


            // Iterate through class properties using Reflection
            foreach (PropertyInfo property in properties)
            {
                if (dataTable.Rows[0][property.Name] != null)
                {
                    if (property.Name == "Id") continue;
                    property.SetValue(this, dataTable.Rows[0][property.Name], null);
                }
            }
        }

        public virtual void Save()
        {
            if (Id > 0)
            {
                Update();
            }
            else
            {
                Create();
            }
        }

        public void Inspect()
        {
            TableStruct ts = new TableStruct(this);
            Console.WriteLine(ts.ToString());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        internal void SetPropertiesFromDataRow(System.Data.DataRow dataRow)
        {
            Type type = GetType();
            PropertyInfo[] properties = type.GetProperties();

            // Iterate through class properties using Reflection
            foreach (PropertyInfo property in properties)
            {
                if (dataRow[property.Name] != null)
                {
                    property.SetValue(this, dataRow[property.Name], null);
                }
            }
        }
    }
}
