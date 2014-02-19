using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace kaki104.MetroCL.Converters
{
    public class BoolToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            Visibility returnValue = Visibility.Collapsed;

            if (value != null)
            {
                bool data = (bool)value;
                if (parameter == null)
                {
                    //기본 : True 보이기, False 숨기기
                    returnValue = data == true ? Visibility.Visible : Visibility.Collapsed;
                }
                else
                {
                    //rev : True 숨기기, False 보이기
                    returnValue = data == true ? Visibility.Collapsed : Visibility.Visible;
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
