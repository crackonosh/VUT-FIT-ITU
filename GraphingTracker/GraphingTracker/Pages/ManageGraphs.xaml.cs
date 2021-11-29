using System;
using System.Collections.Generic;
using GraphingTracker.Pages;
using Xamarin.Forms;

namespace GraphingTracker
{
    public partial class ManageGraphs : ContentPage
    {
        public ManageGraphs()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AddGraph());

        }
    }
}
