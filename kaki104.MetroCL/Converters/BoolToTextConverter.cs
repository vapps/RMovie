using System;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace kaki104.MetroCL.Converters
{
    public class BoolToTextConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            bool flag = System.Convert.ToBoolean(value);
            string para = parameter as string;
            string returnValue = string.Empty;

            switch (para)
            { 
                case "도착여부":
                    if (flag == true)
                        returnValue = "도착";
                    else
                        returnValue = "운행중";
                    break;
                case "막차여부":
                    if (flag == true)
                        returnValue = "종료";
                    else
                        returnValue = "중";
                    break;
                case "막차여부2":
                    if (flag == true)
                        returnValue = "막차";
                    else
                        returnValue = "막차아님";
                    break;
            }

            return returnValue;
            
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
