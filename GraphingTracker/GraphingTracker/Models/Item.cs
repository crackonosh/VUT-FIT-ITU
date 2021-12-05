//****************************************************
//ITU project 2021 - Graphing Tracker

//@authors - Lukas Hais, xhaisl00@fit.vutbr.cz
//@date - 5.12.2021
//****************************************************
using System;
using System.Collections.Generic;
using SQLite;
namespace GraphingTracker.Models
{
    public class Item
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public float Value { get; set; }
        [Indexed]
        public int UnitId { get; set; }
        [Indexed]
        public int ItemCategoryId { get; set; }
        [Indexed]
        public int UnitCategoryId { get; set; }
    }
}
