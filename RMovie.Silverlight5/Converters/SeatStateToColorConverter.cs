using RMovie.PCL.Models;
using RMovie.Silverlight5.Commons;
using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace RMovie.Silverlight5.Converters
{
    public class SeatStateToColorConverter : System.Windows.Data.IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var state = value.ToString();
            SolidColorBrush returnValue = null;
            if (state != null)
            {
                switch (state)
                {
                    case "Nothing":
                        returnValue = new SolidColorBrush(Functions.FromStringColor("#00FFFFFF"));
                        break;
                    case "ChoiceNobodyNormal":
                        returnValue = new SolidColorBrush(Functions.FromStringColor("#FF7392CB"));
                        break;
                    case "ChoiceNobodyCouple":
                        returnValue = new SolidColorBrush(Functions.FromStringColor("#FFF77979"));
                        break;
                    case "ChoiceNobodyOldWeak":
                        returnValue = new SolidColorBrush(Functions.FromStringColor("#FFB8DD8C"));
                        break;
                    case "ChoiceMe":
                        returnValue = new SolidColorBrush(Functions.FromStringColor("#FFF9B196"));
                        break;
                    case "ChoiceOther":
                        returnValue = new SolidColorBrush(Functions.FromStringColor("#FFD1D1D1"));
                        break;
                }
            }
            return returnValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
