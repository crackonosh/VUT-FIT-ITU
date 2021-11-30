using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphingTracker.Pages;
using Xamarin.CommunityToolkit.Extensions;
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
