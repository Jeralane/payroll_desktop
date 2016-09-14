using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace PayrollSystem.Helpers
{
    [ValueConversion(typeof(DateTime), typeof(String))]
    public class DatePickerConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return null;

            if (value.GetType() != typeof (DateTime)) return null;

            var date = (DateTime)value;
            if (date == new DateTime())
                return null;

            var result = date.ToShortDateString();
            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return null;
            try
            {
                DateTime resultDateTime = System.Convert.ToDateTime(value);
                return resultDateTime;
            }
            catch (Exception)
            {
                return DependencyProperty.UnsetValue;
            }
        }
    }
}
