using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMovie.StoreApp.ViewModels
{
    public class ViewModelLocator
    {
        public SeatSelectViewModel SeatChoiceClientVM { get; set; }

        public ViewModelLocator()
        {
            SeatChoiceClientVM = new SeatSelectViewModel();
        }
    }
}
