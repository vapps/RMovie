using System.ComponentModel;
using System;
using kaki104.MetroCL.Bases;

namespace kaki104.MetroCL.Models
{
    //http://api.bus.go.kr/contents/sub02/getStaionByRoute.html
    //노선별 경유 정류소 목록 조회
    public class StationByRouteModel : kaki104ModelBase
    {
        private string beginTm;
        /// <summary>
        /// 첫차시간
        /// </summary>
        public string BeginTm
        {
            get { return beginTm; }
            set 
            {
                beginTm = value;
                FirePropertyChange("BeginTm");
            }
        }

        string lastTm;
        /// <summary>
        /// 막차시간
        /// </summary>
        public string LastTm
        {
            get { return lastTm; }
            set
            {
                lastTm = value;
                FirePropertyChange("LastTm");
            }
        }

        int busRouteId;
        /// <summary>
        /// 노선ID
        /// </summary>
        public int BusRouteId
        {
            get { return busRouteId; }
            set
            {
                busRouteId = value;
                FirePropertyChange("BusRouteId");
            }
        }

        string busRouteNm;
        /// <summary>
        /// 노선명
        /// </summary>
        public string BusRouteNm
        {
            get { return busRouteNm; }
            set
            {
                busRouteNm = value;
                FirePropertyChange("BusRouteNm");
            }
        }

        double gpsX;
        /// <summary>
        /// X좌표 WGS 84
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
        /// Y좌표 WGS 84
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

        int routeType;
        /// <summary>
        /// 노선유형
        /// </summary>
        public int RouteType
        {
            get { return routeType; }
            set
            {
                routeType = value;
                FirePropertyChange("RouteType");
            }
        }

        int section;
        /// <summary>
        /// 구간
        /// </summary>
        public int Section
        {
            get { return section; }
            set
            {
                section = value;
                FirePropertyChange("Section");
            }
        }

        int seq;
        /// <summary>
        /// 순번
        /// </summary>
        public int Seq
        {
            get { return seq; }
            set
            {
                seq = value;
                FirePropertyChange("Seq");
            }
        }

        int station;
        /// <summary>
        /// 정류소ID
        /// </summary>
        public int Station
        {
            get { return station; }
            set
            {
                station = value;
                FirePropertyChange("Station");
            }
        }

        string stationNm;
        /// <summary>
        /// 정류소명
        /// </summary>
        public string StationNm
        {
            get { return stationNm; }
            set
            {
                stationNm = value;
                FirePropertyChange("StationNm");
            }
        }

        string stationNo;
        /// <summary>
        /// 정류소 고유번호
        /// </summary>
        public string StationNo
        {
            get { return stationNo; }
            set
            {
                stationNo = value;
                FirePropertyChange("StationNo");
            }
        }

        float fullSectDist;
        /// <summary>
        /// 정류소간 거리
        /// </summary>
        public float FullSectDist
        {
            get { return fullSectDist; }
            set
            {
                fullSectDist = value;
                FirePropertyChange("FullSectDist");
            }
        }

        int trnstnId;
        /// <summary>
        /// 회차지정류소ID
        /// </summary>
        public int TrnstnId
        {
            get { return trnstnId; }
            set
            {
                trnstnId = value;
                FirePropertyChange("TrnstnId");
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

    }
}
