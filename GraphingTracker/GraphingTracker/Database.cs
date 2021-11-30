using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using GraphingTracker.Models;
namespace GraphingTracker
{
    public class Database
    {
        private readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<UnitCategory>();
            _database.CreateTableAsync<Unit>();
            _database.CreateTableAsync<ItemCategory>();
            _database.CreateTableAsync<Item>();
            _database.CreateTableAsync<ItemRecord>();
            _database.CreateTableAsync<Graph>();
            _database.CreateTableAsync<GraphItem>();
        }

        public Task<List<UnitCategory>> GetUnitCategories()
        {
            return _database.Table<UnitCategory>().ToListAsync();
        }
    }
}
