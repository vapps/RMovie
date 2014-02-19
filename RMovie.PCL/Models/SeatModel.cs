using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMovie.PCL.Models
{
    public enum SeatStateEnum
    { 
        Nothing,
        ChoiceNobodyNormal,
        ChoiceNobodyCouple,
        ChoiceNobodyOldWeak, 
        ChoiceMe,
        ChoiceOther
    }

    public class SeatModel : BaseModel
    {
        private int seatCol;
        /// <summary>
        /// 좌석 col - 중간에 통로때문에 표시용 데이터 필요
        /// </summary>
        public int SeatCol
        {
            get { return seatCol; }
            set 
            { 
                seatCol = value;
                OnPropertyChanged("SeatCol");
            }
        }

        private int seatRow;
        /// <summary>
        /// 좌석 row - 중간에 통로때문에 표시용 데이터 필요
        /// </summary>
        public int SeatRow
        {
            get { return seatRow; }
            set 
            { 
                seatRow = value;
                OnPropertyChanged("SeatRow");
            }
        }

        private string seatNum;
        /// <summary>
        /// 좌석 표시용 번호 1,2,3,4...
        /// </summary>
        public string SeatNum
        {
            get { return seatNum; }
            set 
            { 
                seatNum = value;
                OnPropertyChanged("SeatNum");
            }
        }

        private string lineName;
        /// <summary>
        /// 좌석 표시용 라인명 A,B,C,D...
        /// </summary>
        public string LineName
        {
            get { return lineName; }
            set 
            {
                lineName = value;
                OnPropertyChanged("LineName");
            }
        }

        private SeatStateEnum seatState;
        /// <summary>
        /// 좌석 상태
        /// </summary>
        public SeatStateEnum SeatState
        {
            get { return seatState; }
            set 
            { 
                seatState = value;
                OnPropertyChanged("SeatState");
            }
        }

        private string choiceUser;
        /// <summary>
        /// 선택한 사용자
        /// </summary>
        public string ChoiceUser
        {
            get { return choiceUser; }
            set 
            { 
                choiceUser = value;
                OnPropertyChanged("ChoiceUser");
            }
        }

        public SeatModel()
        {
            SeatState = SeatStateEnum.Nothing;
        }
    }
}
