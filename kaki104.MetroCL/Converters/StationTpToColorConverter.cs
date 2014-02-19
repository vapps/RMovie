using System;
using kaki104.MetroCL.Statics;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace kaki104.MetroCL.Converters
{
    public class StationTpToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            //컨버터로 넘어오는 데이터를 숫자형으로 변경
            int stationTp = System.Convert.ToInt32(value);
            //반환될 데이터를 브러쉬로 생성
            Brush returnValue;

            //(0:공용, 1:일반형 시내/농어촌버스, 2:좌석형 시내/농어촌버스, 3:직행좌석형 시내/농어촌버스, 4:일반형 시외버스, 5:좌석형 시외버스, 6:고속형 시외버스, 7:마을버스)
            Color c;
            switch (stationTp)
            {
                case 1:
                    c = Functions.FromStringColor("#FFC08122");
                    returnValue = new SolidColorBrush(c);
                    break;
                case 2:
                    c = Functions.FromStringColor("#FF018BF5");
                    returnValue = new SolidColorBrush(c);
                    break;
                case 3:
                    c = Functions.FromStringColor("#FF09C500");
                    returnValue = new SolidColorBrush(c);
                    break;
                case 4:
                    c = Functions.FromStringColor("#FFFFBA00");
                    returnValue = new SolidColorBrush(c);
                    break;
                case 5:
                    c = Functions.FromStringColor("#FFFF00A5");
                    returnValue = new SolidColorBrush(c);
                    break;
                case 6:
                    c = Functions.FromStringColor("#FFF00F62");
                    returnValue = new SolidColorBrush(c);
                    break;
                case 7:
                    c = Functions.FromStringColor("#FF9174E3");
                    returnValue = new SolidColorBrush(c);
                    break;
                default:
                    c = Functions.FromStringColor("#FF7BB81A");
                    returnValue = new SolidColorBrush(c);
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
