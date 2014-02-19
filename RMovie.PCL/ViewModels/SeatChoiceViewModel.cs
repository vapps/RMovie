using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using RMovie.PCL.Models;

namespace RMovie.PCL.ViewModels
{
    public class SeatChoiceViewModel : BaseViewModel
    {
        private ICollection<LineModel> lineCollection;
        /// <summary>
        /// 시트 컬렉션
        /// </summary>
        public ICollection<LineModel> LineCollection
        {
            get { return lineCollection; }
            set 
            {
                lineCollection = value;
                OnPropertyChanged("LineCollection");
            }
        }

        public SeatChoiceViewModel()
        {
            LineCollection = new Collection<LineModel>();
        }
    }
}
