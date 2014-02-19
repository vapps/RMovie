using System;
using kaki104.MetroCL.Models;
using Windows.UI.Xaml.Data;

namespace kaki104.MetroCL.Converters
{
    public class SearchKindToTextConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            SearchKindEnum ske = (SearchKindEnum)value;
            string returnValue = string.Empty;
            switch (ske)
            { 
                case SearchKindEnum.BusNo:
                    returnValue = "노선번호";
                    break;
                case SearchKindEnum.StationName:
                    returnValue = "정류소명칭";
                    break;
                case SearchKindEnum.StationNo:
                    returnValue = "정류소번호";
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
