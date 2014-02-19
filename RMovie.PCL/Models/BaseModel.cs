using RMovie.PCL.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace RMovie.PCL.Models
{
    public class BaseModel : INotifyPropertyChanged
    {
        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                if (StaticFunctions.BaseContext != null)
                {
                    StaticFunctions.InvokeIfRequiredAsync(StaticFunctions.BaseContext,
                        _ =>
                        {
                            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                        }, null);
                }
                else
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
            }
        }
        #endregion

    }
}
