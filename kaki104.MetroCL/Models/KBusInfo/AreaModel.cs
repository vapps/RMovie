using System;
using System.ComponentModel;
using kaki104.MetroCL.Bases;

namespace kaki104.MetroCL.Models
{
    public class AreaModel : kaki104ModelBase
    {
        private bool isChecked;
        /// <summary>
        /// 사용여부
        /// </summary>
        public bool IsChecked
        {
            get { return isChecked; }
            set 
            { 
                isChecked = value;
                FirePropertyChange("IsChecked");
            }
        }

        private string areaName;
        /// <summary>
        /// 서비스 지역명
        /// </summary>
        public string AreaName
        {
            get { return areaName; }
            set 
            { 
                areaName = value;
                FirePropertyChange("AreaName");
            }
        }

        private string areaDesc;
        /// <summary>
        /// 서비스 지역 설명
        /// </summary>
        public string AreaDesc
        {
            get { return areaDesc; }
            set 
            { 
                areaDesc = value;
                FirePropertyChange("AreaDesc");
            }
        }

        private bool isUse;
        /// <summary>
        /// 사용가능여부
        /// </summary>
        public bool IsUse
        {
            get { return isUse; }
            set
            {
                isUse = value;
                FirePropertyChange("IsUse");
            }
        }
    }
}
