using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ValueConverters
{
    public class TotalValueConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values != null && values.All(x=> string.IsNullOrEmpty((string)x) == false))
            {
                var result = int.Parse(values[0].ToString()) + int.Parse(values[1].ToString());
                return result.ToString();
            }
            return " ";
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value != null)
            {
                return new object[] { value.ToString() };
            }

            return new object[] { };
        }
    }
}
