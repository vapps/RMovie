using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace RMovie.PCL.Models
{
    public class LineModel : BaseModel
    {
        private ICollection<SeatModel> seatCollection;
        /// <summary>
        /// 시트 컬렉션
        /// </summary>
        public ICollection<SeatModel> SeatCollection
        {
            get { return seatCollection; }
            set 
            { 
                seatCollection = value;
                OnPropertyChanged("SeatCollection");
            }
        }

        private string lineName;
        /// <summary>
        /// 라인명
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

        public LineModel()
        {
            SeatCollection = new Collection<SeatModel>();
        }
    }
}
