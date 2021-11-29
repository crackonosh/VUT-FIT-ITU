using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GraphingTracker
{
    public partial class AddRecord : ContentPage
    {
        public AddRecord()
        {
            InitializeComponent();
        }

        protected async void Button_Clicked(object sender, EventArgs e)
        {


            await Navigation.PushAsync(new MainPage());
        }

        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
        }
    }
}
