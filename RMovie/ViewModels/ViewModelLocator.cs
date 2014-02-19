using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RMovie.ViewModels
{
    public static class ViewModelLocator
    {
        private static SeatChoiceServerViewModel seatVM;
        public static SeatChoiceServerViewModel SeatVM 
        { 
            get
            { 
                if (seatVM == null)
                {
                    seatVM = new SeatChoiceServerViewModel();
                    seatVM.Init();
                }
                return seatVM;
            }
        }
    }
}