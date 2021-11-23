using System;
using System.Collections.Generic;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;

namespace GraphingTracker
{
    public partial class ManageGraphs : ContentPage
    {
        public ManageGraphs()
        {
            InitializeComponent();
        }

        void ClickedPlus(System.Object sender, System.EventArgs e)
        {
            Navigation.ShowPopup(new AddGraph());
        }
    }
}
