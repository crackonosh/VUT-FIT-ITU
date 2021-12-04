
using Xamarin.Forms;
using Xamarin.CommunityToolkit;
using Xamarin.Essentials;
using System.Collections.ObjectModel;
using System.Windows.Input;
using static GraphingTracker.AddGraphViewModel;
using System.Linq;
using GraphingTracker.Pages;

using Microcharts;
using Microcharts.Forms;
using Entry = Microcharts.ChartEntry;

using System.Collections.Generic;
using System.Xml.Linq;

namespace GraphingTracker

{

    class ManageGraphsViewModel
    {


        /*List<Entry> entries = new List<Entry>
        {
            new Entry(20)
            {
                Color = SkiaSharp.SKColor.Parse("#FF1493"),
                Label = "ppl",
                ValueLabel = "20"
            },

            new Entry(30)
            {
                Color = SkiaSharp.SKColor.Parse("#F0f4f3"),
                Label = "spp",
                ValueLabel = "30"
            },

            new Entry(50)
            {
                Color = SkiaSharp.SKColor.Parse("#051403"),
                Label = "ffl",
                ValueLabel = "50"
            }
        };*/

        //public ObservableCollection<GetGraph> List { get; set; }



        public ManageGraphsViewModel()
        {



            /*List = new ObservableCollection<GetGraph>();
            //List.Add(entries);
            Chart NewChart = new PieChart { Entries = entries };
            List.Add(new GetGraph() { Ppl = NewChart });
            Chart NewChart2 = new BarChart { };
            NewChart2.Entries = new List<Entry>
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
                Label = "ffl",
                ValueLabel = "50"
            }
        };
            List.Add(new GetGraph() { Ppl = NewChart2 });

            MessagingCenter.Subscribe<AddGraph, GetGraph>(this, "AddGraph", (page, graph) =>
            {
                if(graph.Ppl == null)
                {
                    List.Add(graph);
                } else
                {


                    GetGraph categoryToEdit = List.Where(emp => emp.Ppl == graph.Ppl).FirstOrDefault();
                    //List.Remove(graphToEdit);

                    List.Add(graph);

                }



            });*/



        }




    }




    /*class ManageGraphsViewModel
    {



        public ObservableCollection<GetGraph> List { get; set; }



        public ManageGraphsViewModel()
        {
            List = new ObservableCollection<GetGraph>();
            List.Add(new GetGraph() { Name = "Graph 1" });
            List.Add(new GetGraph() { Name = "Graph 2" });
            List.Add(new GetGraph() { Name = "Graph 3" });

            MessagingCenter.Subscribe<AddGraph, GetGraph>(this, "AddGraph", (page, graph) =>
            {
                if (graph.Name == "\0")
                {
                    List.Add(graph);
                }
                else
                {


                    GetGraph categoryToEdit = List.Where(emp => emp.Name == graph.Name).FirstOrDefault();
                    //List.Remove(graphToEdit);

                    List.Add(graph);

                }



            });



        }




    }*/

}
