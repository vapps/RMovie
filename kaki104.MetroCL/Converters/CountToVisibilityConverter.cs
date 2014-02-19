using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace kaki104.MetroCL.Converters
{
    public class CountToVisibilityConverter : IValueConverter
    {
        /// <summary>
        /// 컬렉션의 카운트가 0보다 크면 보이고 아니면 보이지 않음
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="language"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            Visibility returnValue = Visibility.Collapsed;
            int count = (int)value;
            if (count != null && count > 0)
            {
                returnValue = Visibility.Visible;
            }

            return returnValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
