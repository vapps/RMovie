using System;
using kaki104.MetroCL.Bases;

namespace kaki104.MetroCL.Models
{
    /// <summary>
    /// 검색 종류 이넘
    /// </summary>
    public enum SearchKindEnum
    {
        BusNo,              //버스번호
        StationNo,          //정류소번호
        StationName         //정류소명
    }

    public class SearchDataModel : kaki104ModelBase
    {
        SearchKindEnum searchKind;
        /// <summary>
        /// 검색종류
        /// </summary>
        public SearchKindEnum SearchKind 
        {
            get { return searchKind; }
            set 
            {
                searchKind = value;
                FirePropertyChange("SearchKind");
            }
        }

        string searchData;
        /// <summary>
        /// 검색데이터
        /// </summary>
        public string SearchData
        {
            get { return searchData; }
            set
            {
                searchData = value;
                FirePropertyChange("SearchData");
            }
        }

        DateTime searchDT;
        /// <summary>
        /// 검색 일시
        /// </summary>
        public DateTime SearchDT
        {
            get { return searchDT; }
            set
            {
                searchDT = value;
                FirePropertyChange("SearchDT");
            }
        }
    }
}
