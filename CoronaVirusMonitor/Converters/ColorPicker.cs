using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;
using System.Windows.Media;

namespace CoronaVirusMonitor.Converters
{
    public class ColorPicker : IValueConverter
    {
        private readonly Color criticalColor = Colors.Red;
        private readonly Color normalColor = Colors.LimeGreen;
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int)
            {
                if ((int) value > 10000)
                    return new SolidColorBrush(criticalColor);
                if ((int) value < 9999)
                    return  new SolidColorBrush(normalColor);
            }

            return Binding.DoNothing;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
