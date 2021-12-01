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

        /************ UNIT CATEGORY ************/
        public Task<List<UnitCategory>> GetUnitCategories()
        {
            return _database.Table<UnitCategory>().ToListAsync();
        }
        public Task<int> SaveUnitCategory(UnitCategory unitCategory)
        {
            return _database.InsertAsync(unitCategory);
        }
        
        /************ UNIT ************/
        public Task<List<Unit>> GetUnits()
        {
            return _database.Table<Unit>().ToListAsync();
        }
        public Task<int> SaveUnit(Unit unit)
        {
            return _database.InsertAsync(unit);
        }
        
        /************ ITEM CATEGORY ************/
        public Task<List<ItemCategory>> GetItemCategories()
        {
            return _database.Table<ItemCategory>().ToListAsync();
        }
        public Task<int> SaveItemCategory(ItemCategory itemCategory)
        {
            return _database.InsertAsync(itemCategory);
        }
        
        /************ ITEM  ************/
        public Task<List<Item>> GetItems()
        {
            return _database.Table<Item>().ToListAsync();
        }
        public Task<int> SaveItem(Item item)
        {
            return _database.InsertAsync(item);
        }
        
        /************ ITEM RECORD ************/
        public Task<List<ItemRecord>> GetItemRecords()
        {
            return _database.Table<ItemRecord>().ToListAsync();
        }
        public Task<int> SaveUnitCategory(ItemRecord itemRecord)
        {
            return _database.InsertAsync(itemRecord);
        }
        
        /************ GRAPH ************/
        public Task<List<Graph>> GetGraphs()
        {
            return _database.Table<Graph>().ToListAsync();
        }
        public Task<int> SaveGraph(Graph graph)
        {
            return _database.InsertAsync(graph);
        }
        
        /************ GRAPH ITEM ************/
        public Task<List<GraphItem>> GetGraphItems()
        {
            return _database.Table<GraphItem>().ToListAsync();
        }
        public Task<int> SaveGraphItem(GraphItem graphItem)
        {
            return _database.InsertAsync(graphItem);
        }
    }
}
