using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Navigation;
using RMovie.PCL.ViewModels;
using RMovie.Silverlight5.ViewModels;

namespace RMovie.Silverlight5.Views
{
    public partial class SeatChoiceView : Page
    {
        public SeatChoiceClinetViewModel ViewModel 
        {
            get { return this.DataContext as SeatChoiceClinetViewModel; }
            set 
            {
                this.DataContext = value;
            }
        }

        public SeatChoiceView()
        {
            InitializeComponent();

            if (System.ComponentModel.DesignerProperties.IsInDesignTool == true)
            {
                ViewModel = new SeatChoiceClinetViewModel();
            }
            else
            {
                var locator = App.Current.Resources["Locator"] as ViewModelLocator;
                ViewModel = locator.SeatChoiceClientVM;
            }
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
        }

        // Executes when the user navigates to this page.
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            await ViewModel.Init();
        }

    }
}
