using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GraphingTracker
{
    public partial class AboutAppPage : ContentPage
    {
        public AboutAppPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked_Go_Back(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
