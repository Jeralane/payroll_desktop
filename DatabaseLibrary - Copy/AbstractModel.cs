using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DatabaseLibrary
{
    /// <summary>
    /// The superclass of all models
    /// </summary>
    public abstract class AbstractModel : INotifyPropertyChanged
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; OnPropertyChanged("Id"); }
        }

        public virtual ActionResult Create()
        {
            try
            {
                var table = new TableStruct(this);

                var fields = from f in table.Fields
                             where f.Key != table.Id.Key
                             select (string.Format("`{0}`", f.Key));

                var values = from f in table.Fields
                             where f.Key != table.Id.Key
                             select ("?" + f.Key);

                var sqlBuilder = new StringBuilder();
                sqlBuilder.AppendFormat("INSERT INTO `{0}` ({1}) VALUES ({2})", table.Name, string.Join(", ", fields),
                                        string.Join(", ", values));

                var sqlParameters = table.Fields.Select(field => new SqlParameter(field.Key, field.Value)).ToList();
                Id = DatabaseHelper.ExecuteInsertQuery(sqlBuilder.ToString(), sqlParameters.ToArray());

                return new ActionResult(true, string.Format("{0} successfully created.", table.RealName));
            }
            catch (Exception e)
            {
                return new ActionResult(false, e.Message);
            }
        }

        public virtual ActionResult Update()
        {
            try
            {
                var table = new TableStruct(this);

                var fields = from f in table.Fields
                             where f.Key != table.Id.Key
                             select (string.Format("`{0}` = ?{0}", f.Key.ToColumnName()));

                var sqlBuilder = new StringBuilder();
                sqlBuilder.AppendFormat("UPDATE `{0}` SET {1} WHERE `{2}` = {3}", table.Name, string.Join(", ", fields),
                                        table.Id.Key, table.Id.Value);

                var sqlParameters =
                    table.Fields.Where(field => field.Key != table.Id.Key).Select(
                        field => new SqlParameter(field.Key, field.Value)).ToArray();
                DatabaseHelper.ExecuteNonQuery(sqlBuilder.ToString(), sqlParameters);

                return new ActionResult(true, string.Format("{0} successfully updated.", table.RealName));
            }
            catch (Exception e)
            {
                return new ActionResult(false, e.Message);
            }
        }

        public virtual ActionResult Destroy()
        {
            try
            {
                var table = new TableStruct(this);

                var sqlBuilder = new StringBuilder();
                sqlBuilder.AppendFormat("DELETE FROM `{0}` WHERE `{1}` = {2}", table.Name, table.Id.Key, table.Id.Value);

                var result = DatabaseHelper.ExecuteNonQuery(sqlBuilder.ToString());
                if (result > 0)
                {
                    return new ActionResult(true, string.Format("{0} successfully destroyed.", table.RealName));
                }

                return new ActionResult(false, string.Format("{0} destroyed unsuccessful.", table.RealName));
            }
            catch (Exception e)
            {
                return new ActionResult(false, e.Message);
            }
        }

        public virtual void Read(int id)
        {
            Id = id;

            Type type = GetType();
            PropertyInfo[] properties = type.GetProperties();

            var table = new TableStruct(this);

            var sqlBuilder = new StringBuilder();
            sqlBuilder.AppendFormat("SELECT * FROM `{0}` WHERE `{1}` = {2}", table.Name, table.Id.Key, table.Id.Value);

            var dataTable = DatabaseHelper.ExecuteSelectQuery(sqlBuilder.ToString());

            if (dataTable.Rows.Count == 0)
            {

                #region --- Reset Property Values to Default ---

                foreach (PropertyInfo property in properties)
                {
                    var defaultValue = GetDefaultValue(property.PropertyType.FullName, DBNull.Value);

                    property.SetValue(this, defaultValue, null);
                }

                #endregion

                return;
            }


            // Iterate through class properties using Reflection
            foreach (PropertyInfo property in properties)
            {
                var columnName = property.Name.ToColumnName();
                if (dataTable.Rows[0][columnName] != null)
                {
                    if (property.Name == "Id") continue;

                    var defaultValue = GetDefaultValue(property.PropertyType.FullName, dataTable.Rows[0][columnName]);
                     
                    //property.SetValue(this, dataTable.Rows[0][columnName], null);
                    property.SetValue(this, defaultValue, null);
                }
            }
        }

        private object GetDefaultValue(string propertyType, object value)
        {
            if (value != DBNull.Value) return value;

            switch (propertyType)
            {
                case "System.Int16":
                    return new Int16();

                case "System.Int32":
                    return new Int32();

                case "System.Int64":
                    return new Int64();

                case "System.Decimal":
                    return new Decimal();

                case "System.Single":
                    return new Single();

                case "System.Double":
                    return new Double();

                case "System.DateTime":
                    return new DateTime();

                case "System.String":
                    return new String(' ', 0);

                case "System.Boolean":
                    return new Boolean();

                default:
                    return new object();
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

        public bool IsNewRecord()
        {
            return Id == 0;
        }

        public Dictionary<string, object> Attributes()
        {
            return new TableStruct(this).Fields;
        }

        public void Inspect()
        {
            var ts = new TableStruct(this);
            Console.WriteLine(ts.ToString());
        }

        public string TableName()
        {
            return new TableStruct(this).Name;
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
                var fieldName = property.Name.ToColumnName();
                var defaultValue = GetDefaultValue(property.PropertyType.FullName, dataRow[fieldName]);
                property.SetValue(this, defaultValue, null);
            }
        }

        public virtual ActionResult Validate()
        {
            return new ActionResult(true, "Validate successful.");
        }
    }
}
