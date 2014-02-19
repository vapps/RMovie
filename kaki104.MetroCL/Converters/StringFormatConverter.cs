using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace kaki104.MetroCL.Converters
{
    public class StringFormatConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            // No format provided.
            if (parameter == null)
            {
                return value;
            }

            var ivalue = System.Convert.ToInt32(value);

            return String.Format((String)parameter, ivalue);
        }
 
        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return value;
        }
    }
 }
