//****************************************************
//ITU project 2021 - Graphing Tracker

//@authors - Lukas Hais, xhaisl00@fit.vutbr.cz
//@date - 5.12.2021
//****************************************************
using SQLite;
namespace GraphingTracker.Models
{
    public class Unit
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Shortcut { get; set; }
        public double DifferenceFromStandardUnit { get; set; }
        [Indexed]
        public int UnitCategoryId { get; set; }
    }
}
