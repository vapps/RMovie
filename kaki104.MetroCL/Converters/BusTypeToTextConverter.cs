using System;
using Windows.UI.Xaml.Data;

namespace kaki104.MetroCL.Converters
{
    /// <summary>
    /// 첫번째도착예정버스의 차량유형 (0:일반버스, 1:저상버스, 2:굴절버스)
    /// </summary>
    public class BusTypeToTextConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            int data = System.Convert.ToInt32(value);
            string returnValue = string.Empty;

            switch (data)
            { 
                case 0:
                    returnValue = "일반";
                    break;
                case 1:
                    returnValue = "저상";
                    break;
                case 2:
                    returnValue = "굴절";
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
