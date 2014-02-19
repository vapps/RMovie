using System.ComponentModel;
using System;
using kaki104.MetroCL.Bases;

namespace kaki104.MetroCL.Models
{
    /// <summary>
    /// 정류소정보조회 서비스 - 명칭별 정류소 목록 조회
    /// http://api.bus.go.kr/contents/sub02/getStationByName.html
    /// </summary>
    public class StationByStationNameModel : kaki104ModelBase
    {
        string arsId;
        /// <summary>
        /// 정류소고유번호
        /// </summary>
        public string ArsId
        {
            get { return arsId; }
            set
            {
                arsId = value;
                FirePropertyChange("ArsId");
            }
        }
        double gpsX;
        /// <summary>
        /// 정류소 좌표x
        /// </summary>
        public double GpsX
        {
            get { return gpsX; }
            set
            {
                gpsX = value;
                FirePropertyChange("GpsX");
            }
        }
        double gpsY;
        /// <summary>
        /// 정류소 좌표y
        /// </summary>
        public double GpsY
        {
            get { return gpsY; }
            set
            {
                gpsY = value;
                FirePropertyChange("GpsY");
            }
        }
        int stId;
        /// <summary>
        /// 정류소ID
        /// </summary>
        public int StId
        {
            get { return stId; }
            set
            {
                stId = value;
                FirePropertyChange("StId");
            }
        }
        string stNm;
        /// <summary>
        /// 정류소명
        /// </summary>
        public string StNm
        {
            get { return stNm; }
            set
            {
                stNm = value;
                FirePropertyChange("StNm");
            }
        }

        int stationTp;
        /// <summary>
        /// 정류소타입 (0:공용, 1:일반형 시내/농어촌버스, 2:좌석형 시내/농어촌버스, 3:직행좌석형 시내/농어촌버스, 4:일반형 시외버스, 5:좌석형 시외버스, 6:고속형 시외버스, 7:마을버스)
        /// 이 속성은 원래 없는데..일부러 추가해 놓음 정류소 상세 정보 조회할 때 사용하기 위해
        /// </summary>
        public int StationTp
        {
            get { return stationTp; }
            set
            {
                stationTp = value;
                FirePropertyChange("StationTp");
            }
        }

        int busArea;
        /// <summary>
        /// 0:서울, 1:경기 이건 조회를 하는 방식 때문에 넣어 놓은 것이고..버스 번호정보에 추가 사항이 필요하기는 한데..
        /// </summary>
        public int BusArea
        {
            get { return busArea; }
            set
            {
                busArea = value;
                FirePropertyChange("BusArea");
            }
        }

        string regionName;
        /// <summary>
        /// 운행지역명 - 경기도에서만 존재
        /// </summary>
        public string RegionName
        {
            get { return regionName; }
            set
            {
                regionName = value;
                FirePropertyChange("RegionName");
            }
        }

    }
}
