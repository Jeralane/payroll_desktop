using System;
using System.Globalization;
using System.Windows.Data;

namespace PayrollSystem.Helpers
{
    [ValueConversion(typeof(int), typeof(String))]
    public class MonthConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.GetType() != typeof (int)) return "";

            var iMonthNo = (int)value;
            if (iMonthNo == 0) return "";
            var dtDate = new DateTime(2000, iMonthNo, 1);
            var sMonthFullName = dtDate.ToString("MMMM");
            return sMonthFullName;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var sMonthName = value as string;
            if (sMonthName == string.Empty)
                return 0;

            var iMonthNo = System.Convert.ToDateTime("01-" + sMonthName + "-2011").Month;

            return iMonthNo;
        }
    }
}
