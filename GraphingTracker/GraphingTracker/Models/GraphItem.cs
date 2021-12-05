﻿//****************************************************
//ITU project 2021 - Graphing Tracker

//@authors - Lukas Hais, xhaisl00@fit.vutbr.cz
//@date - 5.12.2021
//****************************************************
using SQLite;
namespace GraphingTracker.Models
{
    public class GraphItem
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Indexed]
        public int GraphId { get; set; }
        [Indexed]
        public int ItemId { get; set; }
    }
}
