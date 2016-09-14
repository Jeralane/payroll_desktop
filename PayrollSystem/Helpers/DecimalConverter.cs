using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace PayrollSystem.Helpers
{
    [ValueConversion(typeof(Decimal), typeof(String))]
    public class DecimalConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            const string defaultValue = "0.00";
            if (value == null)
                return defaultValue;

            if(string.IsNullOrEmpty(value.ToString()))
                return defaultValue;

            var amount = (Decimal)value;
            if (amount == 0m)
                return defaultValue;

            var result = amount.ToString("N2");
            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var strValue = value as string;
            if (strValue == string.Empty)
                return 0m;

            Decimal resultAmount;
            if (Decimal.TryParse(strValue, out resultAmount))
            {
                return resultAmount;
            }
            return DependencyProperty.UnsetValue;
        }
    }
}
