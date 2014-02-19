using System;
using Windows.UI.Xaml.Data;

namespace kaki104.MetroCL.Converters
{
    public class RouteTypeToNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            //컨버터로 넘어오는 데이터를 숫자형으로 변경
            int routeType = System.Convert.ToInt32(value);
            //반환될 데이터를 문자형으로 생성
            string returnValue = string.Empty;

            //노선 유형(1:공항, 3:간선, 4:지선, 5:순환, 6:광역, 7:인천, 8:경기, 9:폐지, 0:공용)
            switch (routeType)
            {
                case 0:
                    returnValue = "공용";
                    break;
                case 1:
                    returnValue = "공항";
                    break;
                case 3:
                    returnValue = "간선";
                    break;
                case 4:
                    returnValue = "지선";
                    break;
                case 5:
                    returnValue = "순환";
                    break;
                case 6:
                    returnValue = "광역";
                    break;
                case 7:
                    returnValue = "인천";
                    break;
                case 8:
                    returnValue = "경기";
                    break;
                case 9:
                    returnValue = "폐지";
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
