using System;
using System.Globalization;
using System.Windows.Data;
using System.Linq;

namespace PayrollSystem.Helpers
{
    [ValueConversion(typeof(String), typeof(String))]
    public class PaymentTypeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.GetType() != typeof(String)) return "";
            switch (value.ToString().ToUpper())
            {
                case "M":
                    return "MONTHLY";
                case "S":
                    return "SEMI-MONTHLY";
                case "W":
                    return "WEEKLY";
                case "D":
                    return "DAILY";
                default:
                    return "";
            }
            
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var type = value as string;
            if (type == null) return "";
            if (string.IsNullOrEmpty(type)) return "";
            var code = type.Substring(0, 1);
            return "M S D W".Split().Contains(code) ? code : "";
        }
    }
}
