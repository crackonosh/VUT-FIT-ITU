using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;


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


namespace GraphingTracker
{
    /*public class AddGraphViewModel
    {
        private GetGraph _graph;

        public class GetGraph
        {
            public string Name { get; set; }

            public GetGraph(string name)
            {
                Name = name;
            }

            public GetGraph()
            {

            }


        }

        public GetGraph Graph
        {

            get { return _graph; }
            set { _graph = value; OnGraphChaned(); }
        }

        public AddGraphViewModel()
        {
            Graph = new GetGraph();

        }

        public event PropertyChangedEventHandler GraphChanged;

        protected virtual void OnGraphChaned([CallerMemberName] string propertyName = null)
        {
            GraphChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }




    */

    /*public class AddGraphViewModel
    {
        private GetGraph _graph;

        public class GetGraph
        {

            //public List<Entry> Name { get; set; }
            public Chart Ppl;

            public GetGraph(Chart name) => Ppl = name;

            public GetGraph()
            {

            }


        }

        public GetGraph Graph
        {

            get { return _graph; }
            set { _graph = value; OnGraphChaned(); }
        }

        public AddGraphViewModel()
        {
            Graph = new GetGraph();

        }

        public event PropertyChangedEventHandler GraphChanged;

        protected virtual void OnGraphChaned([CallerMemberName] string propertyName = null)
        {
            GraphChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }*/


    public class AddGraphViewModel
    {

    }




}
