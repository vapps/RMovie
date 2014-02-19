using System.ComponentModel;
using System;
using kaki104.MetroCL.Bases;


namespace kaki104.MetroCL.Models
{
    //노선버스위치 정보 목록조회 http://api.bus.go.kr/contents/sub02/getBusPosByRtid.html
    //<busType>0</busType>
    //<dataTm>20111223181759</dataTm>
    //<gpsX>127.16104980422071</gpsX>
    //<gpsY>37.85877293616452</gpsY>
    //<lastStTm>15685</lastStTm>
    //<lastStnId>57431</lastStnId>
    //<nextStTm>0</nextStTm>
    //<plainNo>경기72바6196</plainNo>
    //<sectDist>1211</sectDist>
    //<sectOrd>3</sectOrd>
    //<sectionId>90011557</sectionId>
    //<stopFlag>1</stopFlag>
    //<vehId>12805</vehId>
    //<fullSectDist>1930</fullSectDist>
    //<trnstnid>6330</trnstnid>
    public class BusPosModel : kaki104ModelBase
    {
        int sectOrd;
        /// <summary>
        /// 구간순번
        /// </summary>
        public int SectOrd
        {
            get { return sectOrd; }
            set
            {
                sectOrd = value;
                FirePropertyChange("SectOrd");
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

        int sectDist;
        /// <summary>
        /// 구각옵셋거리Km
        /// </summary>
        public int SectDist
        {
            get { return sectDist; }
            set
            {
                sectDist = value;
                FirePropertyChange("SectDist");
            }
        }

        bool stopFlag;
        /// <summary>
        /// 정류소도착여부 (0:운행중, 1:도착)
        /// </summary>
        public bool StopFlag
        {
            get { return stopFlag; }
            set
            {
                stopFlag = value;
                FirePropertyChange("StopFlag");
            }
        }

        int sectionId;
        /// <summary>
        /// 구간ID
        /// </summary>
        public int SectionId
        {
            get { return trnstnId; }
            set
            {
                trnstnId = value;
                FirePropertyChange("TrnstnId");
            }
        }

        DateTime dataTm;
        /// <summary>
        /// 제공시간
        /// </summary>
        public DateTime DataTm
        {
            get { return dataTm; }
            set
            {
                dataTm = value;
                FirePropertyChange("DataTm");
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

        int vehId;
        /// <summary>
        /// 버스 ID
        /// </summary>
        public int VehId
        {
            get { return vehId; }
            set
            {
                vehId = value;
                FirePropertyChange("VehId");
            }
        }

        string plainNo;
        /// <summary>
        /// 차량번호
        /// </summary>
        public string PlainNo
        {
            get { return plainNo; }
            set
            {
                plainNo = value;
                FirePropertyChange("PlainNo");
            }
        }

        int busType;
        /// <summary>
        /// 차량유형 (0:일반버스, 1:저상버스, 2:굴절버스)
        /// </summary>
        public int BusType
        {
            get { return busType; }
            set
            {
                busType = value;
                FirePropertyChange("BusType");
            }
        }

        int lastStTm;
        /// <summary>
        /// 종점도착소요시간 
        /// </summary>
        public int LastStTm
        {
            get { return lastStTm; }
            set
            {
                lastStTm = value;
                FirePropertyChange("LastStTm");
            }
        }

        int lastStnId;
        /// <summary>
        /// 종점정류소ID
        /// </summary>
        public int LastStnId
        {
            get { return lastStnId; }
            set
            {
                lastStnId = value;
                FirePropertyChange("LastStnId");
            }
        }

        int nextStTm;
        /// <summary>
        /// 다음정류소도착소요시간 
        /// </summary>
        public int NextStTm
        {
            get { return nextStTm; }
            set
            {
                nextStTm = value;
                FirePropertyChange("NextStTm");
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
