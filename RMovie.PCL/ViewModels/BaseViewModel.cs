using RMovie.PCL.Commons;
using System;
using System.ComponentModel;
using System.Net;
using System.Windows;
using System.Windows.Input;

namespace RMovie.PCL.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
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
