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
        public int GraphType { get; set; } // should be {0, 1, 2} [line, pie, bar]
        public int GraphRange { get; set; } // should be {0, 1, 2, 3} [daily, weekly, monthly, date_range]
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}
