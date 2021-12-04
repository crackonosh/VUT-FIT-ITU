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
using SkiaSharp;





namespace GraphingTracker
{



    public partial class ManageGraphs : ContentPage
    {
        string[] colors = { "#b455b6", "#3498db", "#878f99", "#b5e7a0", "#f7cac9", "#f4e1d2", "#b0aac0", "#8ca3a3", "#c8c3cc" };



        List<MyChart> MyCharts;

        public ManageGraphs()
        {

            InitializeComponent();
            MyCharts = new List<MyChart>();
            PopulateCharts();
        }


        public void PopulateCharts()
        {
            MyCharts.Add(new MyChart() { ChartData = Chart1 });
            MyCharts.Add(new MyChart() { ChartData = Chart2 });
            MyCharts.Add(new MyChart() { ChartData = Chart3 });
            MyListview.ItemsSource = MyCharts;
        }

        public class MyChart
        {
            public Chart ChartData { get; set; }
        }

        public Chart Chart1 => new BarChart()
        {
            Entries = new[]
            {
             new Microcharts.ChartEntry(406)
             {
                 Label = "Monday",
                 ValueLabel = "406",
                 Color = SKColor.Parse(colors[0])
             },
             new Microcharts.ChartEntry(317)
             {
                 Label = "Tuesday",
                 ValueLabel = "317",
                 Color = SKColor.Parse(colors[1])
              },
             new Microcharts.ChartEntry(514)
             {
                 Label = "Wednesday",
                 ValueLabel = "514",
                 Color = SKColor.Parse(colors[2])
              }
            },
            BackgroundColor = SKColors.White,
            LabelTextSize = 60f
        };

        public Chart Chart2 => new PieChart()
        {
            Entries = new[]
        {
             new Microcharts.ChartEntry(178)
             {
                 Label = "Carbs",
                 ValueLabel = "178",
                 Color = SKColor.Parse(colors[0])

             },
             new Microcharts.ChartEntry(86)
             {
                 Label = "Protein",
                 ValueLabel = "86",
                 Color = SKColor.Parse(colors[1])
                },
             new Microcharts.ChartEntry(45)
             {
                 Label = "Fat",
                 ValueLabel = "45",
                 Color = SKColor.Parse(colors[2])
                }
            },
            BackgroundColor = SKColors.WhiteSmoke,
            LabelTextSize = 60f
        };

        public Chart Chart3 => new LineChart()
        {
            Entries = new[]
        {
             new Microcharts.ChartEntry(1289)
             {
                 Label = "Monday",
                 ValueLabel = "1289",
                 Color = SKColor.Parse(colors[0])
             },
             new Microcharts.ChartEntry(6073)
             {
                 Label = "Tuestay",
                 ValueLabel = "6073",
                 Color = SKColor.Parse(colors[1])
              },
             new Microcharts.ChartEntry(4391)
             {
                 Label = "Wednesday",
                 ValueLabel = "4391",
                 Color = SKColor.Parse(colors[2])
              }
            },
            BackgroundColor = SKColors.White,
            LabelTextSize = 60f
        };

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AddGraph());

        }

    }
}
