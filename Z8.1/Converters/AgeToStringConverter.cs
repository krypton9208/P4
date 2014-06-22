using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Z8._1.Converters
{
    public class AgeToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string result = string.Empty;
            if (value is int  && targetType == typeof(string))
            {
                int v = (int)value;
                if (v < 10)
                {
                    result = "jesteś bardzo młody, masz tylko " + value.ToString() + " lat.";
                }
                else if (v >= 10 && v<20)
                {
                    result = "Jestes młody bo masz lat: " + value.ToString();
                }
                else if (v>=20 && v<30)
                {
                    result = "Jesteś dorosły, masz "  + value.ToString() + " lat.";
                }
                else if (v>30 && v<50)
                {
                    result = "Jesteś stary! masz " + value.ToString() + " lat!";
                }
                else
                {
                    result = "Żyjesz?";
                }
            }
            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
