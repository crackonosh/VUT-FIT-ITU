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
