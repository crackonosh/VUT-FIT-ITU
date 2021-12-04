using System;
using System.Collections.Generic;
using GraphingTracker.Pages;
using Xamarin.Forms;


using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Xaml;
using static GraphingTracker.ManageGraphsViewModel;
using Microcharts;
using Microcharts.Forms;
using Entry = Microcharts.ChartEntry;

namespace GraphingTracker
{

    public partial class ManageGraphs : ContentPage
    {
        List<Entry> entries = new List<Entry>
        {
            new Entry(20)
            {
                Color = SkiaSharp.SKColor.Parse("#FF1493"),
                Label = "ppl",
                ValueLabel = "20"
            },

            new Entry(30)
            {
                Color = SkiaSharp.SKColor.Parse("#F01493"),
                Label = "spp",
                ValueLabel = "30"
            },

            new Entry(50)
            {
                Color = SkiaSharp.SKColor.Parse("#F51493"),
                Label = "ccl",
                ValueLabel = "50"
            }
        };
        public ManageGraphs()
        {

            InitializeComponent();

            //Chart1.Chart = new BarChart { Entries = entries };
            //Chart2.Chart = new PieChart { Entries = entries };
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AddGraph());

        }

    }
}
