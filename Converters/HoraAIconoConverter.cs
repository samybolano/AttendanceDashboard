using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceDashboard.Converters
{
    public class HoraAIconoConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is DateTime hora)
            {
                // Cambiar el icono según la hora (día: 6 AM - 6 PM, noche: 6 PM - 6 AM)
                return (hora.Hour >= 6 && hora.Hour < 18) ? "\uE708" : "\uE706";
            }
            return "\uEC8A"; // Ícono de sol por defecto
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
