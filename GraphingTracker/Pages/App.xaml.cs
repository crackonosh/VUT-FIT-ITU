using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GraphingTracker
{
    public partial class App : Application
    {
        public App()
        {
            

            MainPage = new NavigationPage(new MainPage());
        }

   
    }
}
