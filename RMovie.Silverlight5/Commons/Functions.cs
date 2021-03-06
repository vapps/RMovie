﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Xml;

namespace RMovie.Silverlight5.Commons
{
    public static class Functions
    {
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
    }
}
