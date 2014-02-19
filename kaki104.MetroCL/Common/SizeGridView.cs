﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using kaki104.MetroCL.Models;

namespace kaki104.MetroCL.Common
{
    public class SizeGridView : GridView
    {
        private int rowVal;
        private int colVal;
        private Random _rand;
        private List<Size> _sequence;

        public SizeGridView()
        {
            _rand = new Random();
            _sequence = new List<Size> { 
                LayoutSizes.PrimaryItem, 
                LayoutSizes.SecondarySmallItem, LayoutSizes.SecondarySmallItem, 
                LayoutSizes.SecondarySmallItem, 
                LayoutSizes.SecondaryTallItem, 
                LayoutSizes.OtherSmallItem, LayoutSizes.OtherSmallItem, LayoutSizes.OtherSmallItem
            };

        }
        protected override void PrepareContainerForItemOverride(Windows.UI.Xaml.DependencyObject element, object item)
        {
            base.PrepareContainerForItemOverride(element, item);

            ISkyDriveItemCommonModel dataItem = item as ISkyDriveItemCommonModel;
            int index = -1;

            if (dataItem != null)
            {
                //index = dataItem.Group.Items.IndexOf(dataItem);
            }

            if (index >= 0 && index < _sequence.Count)
            {

                colVal = (int)_sequence[index].Width;
                rowVal = (int)_sequence[index].Height;

            }
            else
            {
                colVal = (int)LayoutSizes.OtherSmallItem.Width;
                rowVal = (int)LayoutSizes.OtherSmallItem.Height;

            }


            VariableSizedWrapGrid.SetRowSpan(element as UIElement, rowVal);
            VariableSizedWrapGrid.SetColumnSpan(element as UIElement, colVal);


        }
    }

    public static class LayoutSizes
    {
        public static Size PrimaryItem = new Size(6, 2);
        public static Size SecondarySmallItem = new Size(3, 1);
        public static Size SecondaryTallItem = new Size(3, 2);
        public static Size OtherSmallItem = new Size(2, 1);

    }

}
