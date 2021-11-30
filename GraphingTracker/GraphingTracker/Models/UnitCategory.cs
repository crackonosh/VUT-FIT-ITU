using SQLite;
namespace GraphingTracker.Models
{
    public class UnitCategory
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
