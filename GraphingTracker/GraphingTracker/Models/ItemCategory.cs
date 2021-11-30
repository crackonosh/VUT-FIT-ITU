using SQLite;
namespace GraphingTracker.Models
{
    public class ItemCategory
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        [Indexed]
        public int UnitCategoryId { get; set; }
    }
}
