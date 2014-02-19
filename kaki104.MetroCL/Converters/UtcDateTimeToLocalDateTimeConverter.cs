using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace kaki104.MetroCL.Converters
{
    public class UtcDateTimeToLocalDateTimeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            string utcDatetime = value.ToString();
            DateTime localDateTime = DateTime.Parse(utcDatetime);
            //var format = System.Globalization.DateTimeFormatInfo.InvariantInfo;
            var format = System.Globalization.CultureInfo.InvariantCulture;
            var returnValue = localDateTime.ToLocalTime().ToString(format.DateTimeFormat);
            return returnValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
