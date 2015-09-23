using System;
using System.Globalization;
using System.Windows.Data;

namespace Ribbon_Example
{
    class NegativeIntegerConverter : IValueConverter
    {
        public object Convert( object value, Type targetType, object parameter, CultureInfo culture )
        {
            return -1 * System.Convert.ToInt32( value );
        }

        public object ConvertBack( object value, Type targetType, object parameter, CultureInfo culture )
        {
            return -1 * System.Convert.ToInt32( value );
        }
    }
}
