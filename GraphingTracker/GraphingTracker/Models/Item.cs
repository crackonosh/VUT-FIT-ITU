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
        public int UnitID { get; set; }
    }
}
