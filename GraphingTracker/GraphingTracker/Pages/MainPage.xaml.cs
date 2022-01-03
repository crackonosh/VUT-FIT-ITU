//****************************************************
//ITU project 2021 - Graphing Tracker

//@authors - Tadeas Kachyna, xkachy00@fit.vutbr.cz
//@date - 5.12.2021
//****************************************************
using System;
using Xamarin.Forms;

namespace GraphingTracker
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {

            InitializeComponent();

        }

        protected async void Button_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddRecord());
        }

        protected async void Button_ClickedAsync2(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new ManageGraphs());
        }

        protected async void Button_ClickedAsync3(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new ManageCategories());
        }

        protected async void Button_ClickedAsync4( object sender, EventArgs e)
        {

            await Navigation.PushAsync(new ManageRecords());
        }

        protected async void ImageButton_Clicked(System.Object sender, System.EventArgs e)
        {

            await Navigation.PushAsync(new AboutAppPage());
        }
    }
}
