using System.ComponentModel;
using System;
using kaki104.MetroCL.Bases;


namespace kaki104.MetroCL.Models
{
    //버스 노선 목록 조회 모델 http://api.bus.go.kr/contents/sub02/getBusRouteList.html
    public class BusRouteModel : kaki104ModelBase
    {
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

        string startStationNm;
        /// <summary>
        /// 기점
        /// </summary>
        public string StartStationNm
        {
            get { return startStationNm; }
            set
            {
                startStationNm = value;
                FirePropertyChange("StartStationNm");
            }
        }

        string endStationNm;
        /// <summary>
        /// 종점
        /// </summary>
        public string EndStationNm
        {
            get { return endStationNm; }
            set
            {
                endStationNm = value;
                FirePropertyChange("EndStationNm");
            }
        }

        int routeType;
        /// <summary>
        /// 노선 유형(1:공항, 3:간선, 4:지선, 5:순환, 6:광역, 7:인천, 8:경기, 9:폐지, 0:공용)
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

        int term;
        /// <summary>
        /// 배차간격 (분)..여기서 조회되는 배차 간격은 진짜와는 좀 많은 차이가 있음
        /// </summary>
        public int Term
        {
            get { return term; }
            set
            {
                term = value;
                FirePropertyChange("Term");
            }
        }

        int traTime1;
        /// <summary>
        /// 첫번째도착예정버스의 여행시간
        /// 도착예정시간 1
        /// </summary>
        public int TraTime1
        {
            get { return traTime1; }
            set
            {
                traTime1 = value;
                FirePropertyChange("TraTime1");
            }
        }
        int traTime2;
        /// <summary>
        /// 두번째도착예정버스의 여행시간
        /// 도착예정시간 2
        /// </summary>
        public int TraTime2
        {
            get { return traTime2; }
            set
            {
                traTime2 = value;
                FirePropertyChange("TraTime2");
            }
        }
        int stId;
        /// <summary>
        /// 정류소ID - 즐겨찾기 추가되면 상위의 정류소 번호를 가지고 있음 원래 모델에는 없는 것임
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
