using System;
using kaki104.MetroCL.Statics;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace kaki104.MetroCL.Converters
{
    public class RouteTypeToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            //컨버터로 넘어오는 데이터를 숫자형으로 변경
            int routeType = System.Convert.ToInt32(value);
            //반환될 데이터를 브러쉬로 생성
            Brush returnValue;

            //서울 노선 유형(1:공항, 3:간선, 4:지선, 5:순환, 6:광역, 7:인천, 8:경기, 9:폐지, 0:공용)
            //경기 노선 유형(0:공항 -> 1, 8:모름 -> 0, 11:직행, 12:좌석, 13:일반, 21:직행, 23:일반, 41:광역)
            Color c;
            switch (routeType)
            {
                case 1:
                    c = Functions.FromStringColor("#FFC08122");
                    returnValue = new SolidColorBrush(c);
                    break;
                case 3:
                    c = Functions.FromStringColor("#FF018BF5");
                    returnValue = new SolidColorBrush(c);
                    break;
                case 4:
                    c = Functions.FromStringColor("#FF09C500");
                    returnValue = new SolidColorBrush(c);
                    break;
                case 5:
                    c = Functions.FromStringColor("#FFFFBA00");
                    returnValue = new SolidColorBrush(c);
                    break;
                case 7:
                    c = Functions.FromStringColor("#FFFF00A5");
                    returnValue = new SolidColorBrush(c);
                    break;
                case 8:
                    c = Functions.FromStringColor("#FFF00F62");
                    returnValue = new SolidColorBrush(c);
                    break;
                case 21:
                case 11:
                    c = Functions.FromStringColor("#FF9174E3");
                    returnValue = new SolidColorBrush(c);
                    break;
                case 12:
                    c = Functions.FromStringColor("#FF5260BD");
                    returnValue = new SolidColorBrush(c);
                    break;
                case 23:
                case 13:
                    c = Functions.FromStringColor("#FF3A9BBA");
                    returnValue = new SolidColorBrush(c);
                    break;
                case 41:
                    c = Functions.FromStringColor("#FFF00F62");
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
