using System;
using Windows.UI.Xaml.Data;

namespace kaki104.MetroCL.Converters
{
    public class StationTpToTextConverter : IValueConverter
    {
        /// <summary>
        /// 정류소타입 (0:공용, 1:일반형 시내/농어촌버스, 2:좌석형 시내/농어촌버스, 
        /// 3:직행좌석형 시내/농어촌버스, 4:일반형 시외버스, 5:좌석형 시외버스, 6:고속형 시외버스, 7:마을버스)
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            int data = System.Convert.ToInt32(value);
            string returnValue = string.Empty;

            switch (data)
            {
                case 0:
                    returnValue = "공용";
                    break;
                case 1:
                    returnValue = "일반시내";
                    break;
                case 2:
                    returnValue = "좌석시내";
                    break;
                case 3:
                    returnValue = "직행좌석시내";
                    break;
                case 4:
                    returnValue = "일반시외";
                    break;
                case 5:
                    returnValue = "좌석시외";
                    break;
                case 6:
                    returnValue = "고속시외";
                    break;
                case 7:
                    returnValue = "마을버스";
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
