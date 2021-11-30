using SQLite;
namespace GraphingTracker.Models
{
    public class ItemRecord
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Indexed]
        public int ItemId { get; set; }
        public int Count { get; set; }
    }
}
