using System;

namespace DatabaseLibrary
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class ColumnNameAttribute : Attribute
    {
        public readonly string ColumnName;

        public ColumnNameAttribute(string columnName)
        {
            ColumnName = columnName;
        }
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class TableNameAttribute : Attribute
    {
        public readonly string TableName;

        public TableNameAttribute(string tableName)
        {
            TableName = tableName;
        }
    }
}
