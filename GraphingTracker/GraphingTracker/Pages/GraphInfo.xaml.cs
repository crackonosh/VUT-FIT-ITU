using System;
using System.Collections.Generic;
using GraphingTracker.Models;
using Xamarin.Forms;
using System.Linq;
using Microcharts;
using Microcharts.Forms;
using SkiaSharp;
using System.Threading.Tasks;

namespace GraphingTracker
{
    public partial class GraphInfo : ContentPage
    {
        private Graph _graph;
        private List<string> colors = new List<string>
        {
            { "#ff0000" },
            { "#7f00ff" },
            { "#00ffff" },
            { "#7fff00" },
            { "#ff007f" },
            { "#0000ff" },
            { "#00ff7f" },
            { "#ffff00" },
            { "#ff00ff" },
            { "#007fff" },
            { "#00ff00" },
            { "#ff7f00" }
        };

        public GraphInfo(Graph graph)
        {
            InitializeComponent();
            _graph = graph;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            switch (_graph.GraphType)
            {
                // pie
                case 0:
                    createPieGraph();
                    break;
                // bar
                case 1:
                    createBarGraph();
                    break;
            }
        }

        private async Task<List<ChartEntry>> PrepareEntries()
        {
            var records = (await App.Database.GetItemRecords())
                .Where(i => i.ItemCategoryId == _graph.CategoryId)
                .ToList();

            // Dictionary<itemName, {value, scale}>
            var entries = new Dictionary<string, List<float>>();

            foreach (var record in records)
            {
                var item = await App.Database.GetItem(record.ItemId);
                var itemUnitId = (await App.Database.GetItem(record.ItemId)).UnitId;
                var unit = await App.Database.GetUnit(itemUnitId);

                if (!entries.ContainsKey(item.Name))
                {
                    entries.Add(item.Name, new List<float>
                    {
                        { item.Value * record.Count },
                        { (float) unit.DifferenceFromStandardUnit }
                    });
                }
                else
                {
                    var tmp = entries.Where(i => i.Key == item.Name).First();
                    tmp.Value[0] += item.Value * record.Count;
                }
            }

            var preparedEntries = new List<ChartEntry>();
            var colorIterator = 0;
            foreach (var entry in entries)
            {
                preparedEntries.Add(
                    new ChartEntry(entry.Value[0] * entry.Value[1])
                    {
                        Label = entry.Key,
                        Color = SKColor.Parse(colors[colorIterator++])
                    }
                );
            }

            return preparedEntries;
        }

        private async void createPieGraph()
        {
            var entries = await PrepareEntries();

            var chart = new PieChart {
                Entries = entries,
                LabelColor = SKColor.Parse("#ff00ff"),
                LabelTextSize = 30
            };
            chartView.Chart = chart;
        }

        private async void createBarGraph()
        {
            var entries = await PrepareEntries();

            var chart = new BarChart { Entries = entries };
            chartView.Chart = chart;
        }
    }
}
