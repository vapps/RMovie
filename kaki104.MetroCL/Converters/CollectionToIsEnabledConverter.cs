using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kaki104.MetroCL.Models;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace kaki104.MetroCL.Converters
{
    public class CollectionToIsEnabledConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            bool returnValue = false;
            if(value != null && (value as ObservableCollection<StationByStationNoModel>).Count > 0)
            {
                returnValue = true;
            }
            return returnValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
