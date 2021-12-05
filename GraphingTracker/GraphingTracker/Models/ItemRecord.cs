//****************************************************
//ITU project 2021 - Graphing Tracker

//@authors - Lukas Hais, xhaisl00@fit.vutbr.cz
//@date - 5.12.2021
//****************************************************
using SQLite;
namespace GraphingTracker.Models
{
    public class ItemRecord
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Indexed]
        public int ItemId { get; set; }
        [Indexed]
        public int ItemCategoryId { get; set; }
        public int Count { get; set; }
    }
}
