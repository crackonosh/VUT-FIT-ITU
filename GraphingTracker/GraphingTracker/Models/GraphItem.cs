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
