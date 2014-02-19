using System.ComponentModel;
using System;
using kaki104.MetroCL.Bases;

namespace kaki104.MetroCL.Models
{
    public class StationBusPosRow : kaki104ModelBase
    {

        StationByRouteModel station;
        /// <summary>
        /// 정류소 정보
        /// </summary>
        public StationByRouteModel Station
        {
            get { return station; }
            set
            {
                station = value;
                FirePropertyChange("Station");
            }
        }

        BusPosModel busPos;
        /// <summary>
        /// 버스 위치 정보
        /// </summary>
        public BusPosModel BusPos
        {
            get { return busPos; }
            set
            {
                busPos = value;
                FirePropertyChange("BusPos");
            }
        }
    }
}
