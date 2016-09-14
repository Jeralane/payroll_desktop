using System;
using System.Collections.Generic;
using System.Reflection;

namespace ModelsLibrary
{
    internal struct TableStruct
    {
        public Dictionary<string, object> Fields;
        public string Name;

        public TableStruct(AbstractModel model)
        {
            // Fields/Columns are the class properties
            Fields = new Dictionary<string, object>();

            Type type = model.GetType();
            PropertyInfo[] properties = type.GetProperties();

            // Iterate through class properties using Reflection
            foreach (PropertyInfo property in properties)
            {
                Fields.Add(property.Name, property.GetValue(model, null));
            }

            // Table name will be the class name
            Name = Helper.Pluralize(type.Name);
        }

        public override string ToString()
        {
            var sb = new System.Text.StringBuilder();
            sb.Append("<");
            sb.AppendFormat("#{0}:", Name);
            foreach (var field in Fields)
            {
                sb.AppendFormat(" [{0} => {1}] ", field.Key, field.Value);
            }
            sb.Append(">");

            return sb.ToString();
        }
    }
}
