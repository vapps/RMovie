using System;
using System.Net;
using System.Windows;
using System.Windows.Input;
using System.Xml.Linq;
using Windows.Storage.Pickers;
using Windows.UI.Popups;
using System.Linq;
using Windows.UI;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Collections.Generic;

namespace kaki104.MetroCL.Statics
{
    public static class Functions
    {
        static MessageDialog msg;
        static bool isShow;

        /// <summary>
        /// 숫자로
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static int GetInt(object element)
        {
            int returnValue = -1;

            if (element != null)
            {
                switch (element.GetType().Name)
                { 
                    case "XElement":
                        XElement x = element as XElement;
                        returnValue = Convert.ToInt32(x.Value);
                        break;
                }
            }
            return returnValue;
        }

        /// <summary>
        /// 문자로
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static string GetString(object element)
        {
            string returnValue = string.Empty;

            if (element != null)
            {
                switch (element.GetType().Name)
                {
                    case "XElement":
                        XElement x = element as XElement;
                        returnValue = x.Value.Trim();
                        break;
                }
            }
            return returnValue;
        }

        /// <summary>
        /// 날짜로
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static DateTime GetDateTime(object element)
        {
            DateTime returnValue = DateTime.MinValue;

            if (element != null)
            {
                switch (element.GetType().Name)
                {
                    case "XElement":
                        XElement x = element as XElement;
                        returnValue = DateTime.Parse(x.Value);
                        break;
                }
            }
            return returnValue;
        }

        /// <summary>
        /// 더블형
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static double GetDouble(object element)
        {
            double returnValue = -1;

            if (element != null)
            {
                switch (element.GetType().Name)
                {
                    case "XElement":
                        XElement x = element as XElement;
                        returnValue = Convert.ToDouble(x.Value);
                        break;
                }
            }
            return returnValue;
        }

        /// <summary>
        /// 싱글형
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static Single GetSingle(object element)
        {
            Single returnValue = -1;

            if (element != null)
            {
                switch (element.GetType().Name)
                {
                    case "XElement":
                        XElement x = element as XElement;
                        returnValue = Convert.ToSingle(x.Value);
                        break;
                }
            }
            return returnValue;
        }

        public static async void MsgBox(string message)
        {
            if (msg == null)
            {
                msg = new MessageDialog(message, "Notification");
            }
            if (isShow == false)
            {
                isShow = true;
                var result = await msg.ShowAsync();
                isShow = false;
            }
        }

        public static async System.Threading.Tasks.Task<bool> Confirm(string message)
        {
            MessageDialog msg = new MessageDialog(message, "Confirm");
            msg.Commands.Add(new UICommand("OK", _ => { }, "0"));
            msg.Commands.Add(new UICommand("Cancel", _ => { }, "1"));
            msg.DefaultCommandIndex = 1;
            var result = await msg.ShowAsync();
            if (result.Id.ToString() == "0" )
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Creates a FileOpenPicker for the specified extensions. 
        /// </summary>
        /// <param name="extensions">File extensions to pick.</param>
        /// <returns>FileOpenPicker instance.</returns>
        public static FileOpenPicker CreateFilePicker(string[] extensions, PickerLocationId locationId)
        {
            FileOpenPicker picker = new FileOpenPicker();
            picker.SuggestedStartLocation = locationId;
            foreach (string extension in extensions)
            {
                picker.FileTypeFilter.Add(extension);
            }
            return picker;
        }

        /// <summary>
        /// 색상을 컬러로 바꿔주는 함수 #FFRRGGBB
        /// </summary>
        /// <param name="rgbColor"></param>
        /// <returns></returns>
        public static Color FromStringColor(string rgbColor)
        {
            Color c = new Color();
            //byte a = 255; // or whatever...
            byte a = (byte)(Convert.ToUInt32(rgbColor.Substring(1, 2), 16));
            byte r = (byte)(Convert.ToUInt32(rgbColor.Substring(3, 2), 16));
            byte g = (byte)(Convert.ToUInt32(rgbColor.Substring(5, 2), 16));
            byte b = (byte)(Convert.ToUInt32(rgbColor.Substring(7, 2), 16));
            c = Color.FromArgb(a, r, g, b);
            return c;
        }

        public static Color FromKnownColor(string colorName)
        {
            Line lne = (Line)XamlReader.Load("<Line xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\" xmlns:x=\"http://schemas.microsoft.com/winfx/2006/xaml\" Fill=\"" + colorName + "\" />");
            return (Color)lne.Fill.GetValue(SolidColorBrush.ColorProperty);
        }

        public static async void LaunchFile(string filePath)
        {
            bool success = false;

            var file = await Windows.Storage.StorageFile.GetFileFromPathAsync(filePath);
            if (file != null)
            {
                //Windows.System.LauncherOptions option = new Windows.System.LauncherOptions();
                //option.DisplayApplicationPicker = true;
                //success = await Windows.System.Launcher.LaunchFileAsync(file, option);
                success = await Windows.System.Launcher.LaunchFileAsync(file);
            }
        }

        /// <summary>
        /// 페이지 네비게이션
        /// </summary>
        /// <param name="navigationType"></param>
        /// <param name="navigationParameter"></param>
        /// <returns></returns>
        public static bool NavigationPage(Type navigationType, string navigationParameter)
        {
            var mainFrame = Windows.UI.Xaml.Window.Current.Content as Windows.UI.Xaml.Controls.Frame;
            var result = mainFrame.Navigate(navigationType, navigationParameter);
            return result;
        }
    }
}
