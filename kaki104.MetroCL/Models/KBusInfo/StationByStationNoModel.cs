using System.ComponentModel;
using System;
using kaki104.MetroCL.Bases;

namespace kaki104.MetroCL.Models
{
    #region 프로퍼티들..많음
    //<arsId>11186</arsId>                    //정류소고유번호
    //<busRouteId>4113700</busRouteId>        //노선ID
    //<busType1>0</busType1>                  //첫번째도착예정버스의 차량유형 (0:일반버스, 1:저상버스, 2:굴절버스)
    //<busType2>0</busType2>                  //두번째도착예정버스의 차량유형 (0:일반버스, 1:저상버스, 2:굴절버스)
    //<firstTm>04:30 </firstTm>               //첫차시간
    //<gpsX>127.0596334327946</gpsX>          //좌표x
    //<gpsY>37.657004586835626</gpsY>         //좌표y
    //<isArrive1>0</isArrive1>                //첫번째도착예정버스의 최종 정류소 도착출발여부 (0:운행중, 1:도착)
    //<isArrive2>1</isArrive2>                //두번째도착예정버스의 최종 정류소 도착출발여부 (0:운행중, 1:도착)
    //<isLast1>0</isLast1>                    //첫번째도착예정버스의 막차여부 (0:막차아님, 1:막차)
    //<isLast2>0</isLast2>                    //두번째도착예정버스의 막차여부 (0:막차아님, 1:막차)
    //<lastTm>23:20 </lastTm>                 //막차시간
    //<nextBus>0</nextBus>                    //막차운행여부 (N:막차아님, Y:막차)
    //<plainNo1>서울74사3532</plainNo1>       //첫번째도착예정차량번호
    //<plainNo2>서울74사3528</plainNo2>       //두번째도착예정차량번호
    //<repTm1>2012-01-18 18:14:46.0</repTm1>  //첫번째도착예정버스의 최종 보고 시간
    //<repTm2>2012-01-18 18:15:50.0</repTm2>  //두번째도착예정버스의 최종 보고 시간
    //<routeType>4</routeType>                //노선유형 (1:공항, 3:간선, 4:지선, 5:순환, 6:광역, 7:인천, 8:경기, 9:폐지, 0:공용)
    //<rtNm>1137</rtNm>                       //노선명
    //<sectOrd1>9</sectOrd1>                  //첫번째도착예정버스의 현재구간 순번 데이터 없는듯
    //<sectOrd2>6</sectOrd2>                  //두번째도착예정버스의 현재구간 순번 데이터 없는듯
    //<stId>1764</stId>                       //정류소ID
    //<stNm>도봉면허시험장</stNm>             //정류소명
    //<staOrd>12</staOrd>                     //요청정류소순번
    //<stationNm1>상계주공12단지1202동</stationNm1> //첫번째도착예정버스의 최종 정류소명
    //<stationNm2>상계한신2차아파트</stationNm2>    //두번째도착예정버스의 최종 정류소명
    //<stationTp>3</stationTp>                //정류소타입 (0:공용, 1:일반형 시내/농어촌버스, 2:좌석형 시내/농어촌버스, 3:직행좌석형 시내/농어촌버스, 4:일반형 시외버스, 5:좌석형 시외버스, 6:고속형 시외버스, 7:마을버스)
    //<term>7</term>                          //배차간격 분
    //<traSpd1>32</traSpd1>                   //첫번째도착예정버스의 여행속도 (Km/h)
    //<traSpd2>16</traSpd2>                   //두번째도착예정버스의 여행속도 (Km/h)
    //<traTime1>115</traTime1>                //첫번째도착예정버스의 여행시간
    //<traTime2>370</traTime2>                //두번째도착예정버스의 여행시간
    //<vehId1>7142</vehId1>                   //첫번째도착예정버스ID
    //<vehId2>5326</vehId2>                   //두번째도착예정버스ID 
    #endregion
    /// <summary>
    /// 정류소정보조회 - 고유번호별 정류소 항목 조회
    /// http://api.bus.go.kr/contents/sub02/getStationByUid.html
    /// </summary>
    public class StationByStationNoModel : kaki104ModelBase
    {
        //정류소 정보 - 중복 데이터들이지
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


        //버스 정보 - 목록으로 보여줘야 할 부분이고
        //버스 정보 상단
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
        string firstTm;
        /// <summary>
        /// 첫차시간
        /// </summary>
        public string FirstTm
        {
            get { return firstTm; }
            set
            {
                firstTm = value;
                FirePropertyChange("FirstTm");
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
        bool nextBus;
        /// <summary>
        /// 막차운행여부 (N:막차아님, Y:막차)
        /// </summary>
        public bool NextBus
        {
            get { return nextBus; }
            set
            {
                nextBus = value;
                FirePropertyChange("NextBus");
            }
        }
        int routeType;
        /// <summary>
        /// 노선유형 (1:공항, 3:간선, 4:지선, 5:순환, 6:광역, 7:인천, 8:경기, 9:폐지, 0:공용)
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
        string rtNm;
        /// <summary>
        /// 노선명
        /// </summary>
        public string RtNm
        {
            get { return rtNm; }
            set
            {
                rtNm = value;
                FirePropertyChange("RtNm");
            }
        }
        int staOrd;
        /// <summary>
        /// 요청정류소순번
        /// </summary>
        public int StaOrd
        {
            get { return staOrd; }
            set
            {
                staOrd = value;
                FirePropertyChange("StaOrd");
            }
        }
        int term;
        /// <summary>
        /// 배차간격 분
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

        //버스별로 나누어서 표시할 데이터
        int busType1;
        /// <summary>
        /// 첫번째도착예정버스의 차량유형 (0:일반버스, 1:저상버스, 2:굴절버스)
        /// </summary>
        public int BusType1
        {
            get { return busType1; }
            set
            {
                busType1 = value;
                FirePropertyChange("BusType1");
            }
        }
        int busType2;
        /// <summary>
        /// 두번째도착예정버스의 차량유형 (0:일반버스, 1:저상버스, 2:굴절버스)
        /// </summary>
        public int BusType2
        {
            get { return busType2; }
            set
            {
                busType2 = value;
                FirePropertyChange("BusType2");
            }
        }
        bool isArrive1;
        /// <summary>
        /// 첫번째도착예정버스의 최종 정류소 도착출발여부 (0:운행중, 1:도착)
        /// </summary>
        public bool IsArrive1
        {
            get { return isArrive1; }
            set
            {
                isArrive1 = value;
                FirePropertyChange("IsArrive1");
            }
        }
        bool isArrive2;
        /// <summary>
        /// 두번째도착예정버스의 최종 정류소 도착출발여부 (0:운행중, 1:도착)
        /// </summary>
        public bool IsArrive2
        {
            get { return isArrive2; }
            set
            {
                isArrive2 = value;
                FirePropertyChange("IsArrive2");
            }
        }
        bool isLast1;
        /// <summary>
        /// 첫번째도착예정버스의 막차여부 (0:막차아님, 1:막차)
        /// </summary>
        public bool IsLast1
        {
            get { return isLast1; }
            set
            {
                isLast1 = value;
                FirePropertyChange("IsLast1");
            }
        }
        bool isLast2;
        /// <summary>
        /// 두번째도착예정버스의 막차여부 (0:막차아님, 1:막차)
        /// </summary>
        public bool IsLast2
        {
            get { return isLast2; }
            set
            {
                isLast2 = value;
                FirePropertyChange("IsLast2");
            }
        }
        string plainNo1;
        /// <summary>
        /// 첫번째도착예정차량번호
        /// </summary>
        public string PlainNo1
        {
            get { return plainNo1; }
            set
            {
                plainNo1 = value;
                FirePropertyChange("PlainNo1");
            }
        }
        string plainNo2;
        /// <summary>
        /// 두번째도착예정차량번호
        /// </summary>
        public string PlainNo2
        {
            get { return plainNo2; }
            set
            {
                plainNo2 = value;
                FirePropertyChange("PlainNo2");
            }
        }
        DateTime repTm1;
        /// <summary>
        /// 첫번째도착예정버스의 최종 보고 시간
        /// </summary>
        public DateTime RepTm1
        {
            get { return repTm1; }
            set
            {
                repTm1 = value;
                FirePropertyChange("RepTm1");
            }
        }
        DateTime repTm2;
        /// <summary>
        /// 두번째도착예정버스의 최종 보고 시간
        /// </summary>
        public DateTime RepTm2
        {
            get { return repTm2; }
            set
            {
                repTm2 = value;
                FirePropertyChange("RepTm2");
            }
        }
        int sectOrd1;
        /// <summary>
        /// 첫번째도착예정버스의 현재구간 순번
        /// </summary>
        public int SectOrd1
        {
            get { return sectOrd1; }
            set
            {
                sectOrd1 = value;
                FirePropertyChange("SectOrd1");
            }
        }
        int sectOrd2;
        /// <summary>
        /// 두번째도착예정버스의 현재구간 순번
        /// </summary>
        public int SectOrd2
        {
            get { return sectOrd2; }
            set
            {
                sectOrd2 = value;
                FirePropertyChange("SectOrd2");
            }
        }
        string stationNm1;
        /// <summary>
        /// 첫번째도착예정버스의 최종 정류소명
        /// </summary>
        public string StationNm1
        {
            get { return stationNm1; }
            set
            {
                stationNm1 = value;
                FirePropertyChange("StationNm1");
            }
        }
        string stationNm2;
        /// <summary>
        /// 두번째도착예정버스의 최종 정류소명
        /// </summary>
        public string StationNm2
        {
            get { return stationNm2; }
            set
            {
                stationNm2 = value;
                FirePropertyChange("StationNm2");
            }
        }
        int traSpd1;
        /// <summary>
        /// 첫번째도착예정버스의 여행속도 (Km/h)
        /// </summary>
        public int TraSpd1
        {
            get { return traSpd1; }
            set
            {
                traSpd1 = value;
                FirePropertyChange("TraSpd1");
            }
        }
        int traSpd2;
        /// <summary>
        /// 두번째도착예정버스의 여행속도 (Km/h)
        /// </summary>
        public int TraSpd2
        {
            get { return traSpd2; }
            set
            {
                traSpd2 = value;
                FirePropertyChange("TraSpd2");
            }
        }
        int traTime1;
        /// <summary>
        /// 첫번째도착예정버스의 여행시간
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
        int vehId1;
        /// <summary>
        /// 첫번째도착예정버스ID
        /// </summary>
        public int VehId1
        {
            get { return vehId1; }
            set
            {
                vehId1 = value;
                FirePropertyChange("VehId1");
            }
        }
        int vehId2;
        /// <summary>
        /// 두번째도착예정버스ID 
        /// </summary>
        public int VehId2
        {
            get { return vehId2; }
            set
            {
                vehId2 = value;
                FirePropertyChange("VehId2");
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
