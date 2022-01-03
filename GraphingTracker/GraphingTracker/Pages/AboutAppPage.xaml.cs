//****************************************************
//ITU project 2021 - Graphing Tracker

//@authors - Tadeas Kachyna, xkachy00@fit.vutbr.cz
//@date - 5.12.2021
//****************************************************
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
