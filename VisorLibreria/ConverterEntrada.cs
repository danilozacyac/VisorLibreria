using System;
using System.Linq;
using System.Windows.Data;
using System.Windows.Media;

namespace VisorLibreria
{
    public class ConverterEntrada : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            TimeSpan tolerancia = new TimeSpan(9, 0, 0);

            DateTime entrada = System.Convert.ToDateTime(value);

            if (entrada.TimeOfDay > tolerancia)
            {
                return new SolidColorBrush(Colors.OrangeRed);
            }
            else
            {
                return new SolidColorBrush(Colors.White);
            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
