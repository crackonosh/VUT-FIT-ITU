//****************************************************
//ITU project 2021 - Graphing Tracker

//@authors - Lukas Hais, xhaisl00@fit.vutbr.cz
//@date - 5.12.2021
//****************************************************
using System;
using SQLite;
namespace GraphingTracker.Models
{
    public class Graph
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        [Indexed]
        public int CategoryId { get; set; }
        [Indexed]
        public int PreferredUnitId { get; set; }
        public int GraphType { get; set; } // should be {0, 1} [pie, bar]
    }
}
