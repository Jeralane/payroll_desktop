using System;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

namespace PayrollSystem.Helpers
{
    [ValueConversion(typeof(int), typeof(String))]
    public class PeriodIdConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.GetType() != typeof (int)) return "";

            var iPeriodId = (int)value;

            var cutoffs = PayrollDictionary.CutoffDictionary();
            return cutoffs[iPeriodId];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var cutoff = value as string;
            if (cutoff == string.Empty)
                return 0;

            var cutoffs = PayrollDictionary.CutoffDictionary();
            return (from item in cutoffs where item.Value == cutoff select item.Key).FirstOrDefault();
        }
    }
}
