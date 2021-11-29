using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GraphingTracker.Pages
{
    public partial class AddGraph : ContentPage
    {
        public AddGraph()
        {
            InitializeComponent();
            
        }

        protected async void Button_Clicked(object sender, EventArgs e)
        {


            await Navigation.PopAsync();
        }

    }
}
