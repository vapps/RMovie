using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace kaki104.MetroCL.Converters
{
    public class TextToVisibilityConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            Visibility returnValue;
            if (value == null)
            {
                returnValue = Visibility.Collapsed;
            }
            else
            {
                switch (value.GetType().Name)
                {
                    case "String":
                        if (value == null || (string)value == "")
                        {
                            returnValue = Visibility.Collapsed;
                        }
                        else
                        {
                            returnValue = Visibility.Visible;
                        }
                        break;
                    default:
                        if (value == null)
                        {
                            returnValue = Visibility.Collapsed;
                        }
                        else
                        {
                            returnValue = Visibility.Visible;
                        }
                        break;
                }
            }

            return returnValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
