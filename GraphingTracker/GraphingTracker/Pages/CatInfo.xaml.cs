using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GraphingTracker
{
    public partial class CatInfo : ContentPage
    {
        public CatInfo(string name)
        {
            InitializeComponent();
            lblName.Text = name;

            
        }

        private void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AddItem());
        }
    }
}
