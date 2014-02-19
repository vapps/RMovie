using System;
using Windows.UI.Xaml.Data;

namespace kaki104.MetroCL.Converters
{
    public class StopFlagToTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            bool flag = System.Convert.ToBoolean(value);
            string returnValue = string.Empty;

            if (flag == true)
                returnValue = "도착";
            else
                returnValue = "운행중";

            return returnValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
