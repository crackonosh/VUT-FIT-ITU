using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using GraphingTracker.Models;
using System.Linq;
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

        public async void InitializeDatabaseData()
        {
            // check that initialization already run
            var tmp = await _database.Table<UnitCategory>().ToListAsync();
            if (tmp.Count != 0) return;

            var unitCategories = new List<UnitCategory>()
            {
                { new UnitCategory { Name = "Time" } },
                { new UnitCategory { Name = "Volume" } },
                { new UnitCategory { Name = "Weight" } },
                { new UnitCategory { Name = "Length" } },
                { new UnitCategory { Name = "Energy" } },
                { new UnitCategory { Name = "Count" } },
                { new UnitCategory { Name = "Area" } }
            };

            foreach (var unitCategory in unitCategories)
            {
                await _database.InsertAsync(unitCategory);
            }

            var timeUnits = new List<Unit>()
            {
                {
                    new Unit
                    {
                        Name = "Hours",
                        Shortcut = "h",
                        DifferenceFromStandardUnit = 1,
                        UnitCategoryId = 1
                    }
                },
                {
                    new Unit
                    {
                        Name = "Seconds",
                        Shortcut = "sec",
                        DifferenceFromStandardUnit = 3600,
                        UnitCategoryId = 1
                    }
                },
                {
                    new Unit
                    {
                        Name = "Minutes",
                        Shortcut = "min",
                        DifferenceFromStandardUnit = 60,
                        UnitCategoryId = 1
                    }
                },
                {
                    new Unit
                    {
                        Name = "Days",
                        Shortcut = "d",
                        DifferenceFromStandardUnit = 86400,
                        UnitCategoryId = 1
                    }
                }
            };
            var volumeUnits = new List<Unit>()
            {
                {
                    new Unit
                    {
                        Name = "Liters",
                        Shortcut = "l",
                        DifferenceFromStandardUnit = 1,
                        UnitCategoryId = 2
                    }
                },
                {
                    new Unit
                    {
                        Name = "Cubic centimeters",
                        Shortcut = "cmˆ3",
                        DifferenceFromStandardUnit = 1000,
                        UnitCategoryId = 2
                    }
                },
                {
                    new Unit
                    {
                        Name = "Mililiters",
                        Shortcut = "ml",
                        DifferenceFromStandardUnit = 1000,
                        UnitCategoryId = 2
                    }
                },
                {
                    new Unit
                    {
                        Name = "Cubic decimeters",
                        Shortcut = "dmˆ3",
                        DifferenceFromStandardUnit = 1,
                        UnitCategoryId = 2
                    }
                },
            };
            var wieghtUnits = new List<Unit>()
            {
                {
                    new Unit
                    {
                        Name = "Kilograms",
                        Shortcut = "kg",
                        DifferenceFromStandardUnit = 1,
                        UnitCategoryId = 3
                    }
                },
                {
                    new Unit
                    {
                        Name = "Grams",
                        Shortcut = "g",
                        DifferenceFromStandardUnit = 1000,
                        UnitCategoryId = 3
                    }
                },
                {
                    new Unit
                    {
                        Name = "Tons",
                        Shortcut = "t",
                        DifferenceFromStandardUnit = 0.001,
                        UnitCategoryId = 3
                    }
                },
            };
            var lengthUnits = new List<Unit>()
            {
                {
                    new Unit
                    {
                        Name = "Meters",
                        Shortcut = "m",
                        DifferenceFromStandardUnit = 1,
                        UnitCategoryId = 4
                    }
                },
                {
                    new Unit
                    {
                        Name = "Kilometers",
                        Shortcut = "km",
                        DifferenceFromStandardUnit = 0.001,
                        UnitCategoryId = 4
                    }
                },
                {
                    new Unit
                    {
                        Name = "Decimeter",
                        Shortcut = "dm",
                        DifferenceFromStandardUnit = 10,
                        UnitCategoryId = 4
                    }
                },
                {
                    new Unit
                    {
                        Name = "Centimeters",
                        Shortcut = "cm",
                        DifferenceFromStandardUnit = 100,
                        UnitCategoryId = 4
                    }
                },
                {
                    new Unit
                    {
                        Name = "Milimeters",
                        Shortcut = "mm",
                        DifferenceFromStandardUnit = 1000,
                        UnitCategoryId = 4
                    }
                },
            };
            var energyUnits = new List<Unit>()
            {
                {
                    new Unit
                    {
                        Name = "Kilocalories",
                        Shortcut = "kcal",
                        DifferenceFromStandardUnit = 1,
                        UnitCategoryId = 5
                    }
                },
                {
                    new Unit
                    {
                        Name = "Calories",
                        Shortcut = "cal",
                        DifferenceFromStandardUnit = 1000,
                        UnitCategoryId = 5
                    }
                },
            };
            var countUnits = new List<Unit>()
            {
                {
                    new Unit
                    {
                        Name = "Pieces",
                        Shortcut = "piece",
                        DifferenceFromStandardUnit = 1,
                        UnitCategoryId = 6
                    }
                },
            };
            var areaUnits = new List<Unit>()
            {
                {
                    new Unit
                    {
                        Name = "Square meters",
                        Shortcut = "mˆ2",
                        DifferenceFromStandardUnit = 1,
                        UnitCategoryId = 7
                    }
                },
                {
                    new Unit
                    {
                        Name = "Square kilometers",
                        Shortcut = "kmˆ2",
                        DifferenceFromStandardUnit = 0.000001,
                        UnitCategoryId = 7
                    }
                },
                {
                    new Unit
                    {
                        Name = "Square decimeters",
                        Shortcut = "dmˆ2",
                        DifferenceFromStandardUnit = 100,
                        UnitCategoryId = 7
                    }
                },
                {
                    new Unit
                    {
                        Name = "Square centimeters",
                        Shortcut = "cmˆ2",
                        DifferenceFromStandardUnit = 10000,
                        UnitCategoryId = 7
                    }
                },
                {
                    new Unit
                    {
                        Name = "Square milimeters",
                        Shortcut = "mmˆ2",
                        DifferenceFromStandardUnit = 1000000,
                        UnitCategoryId = 7
                    }
                },
            };

            var categoryUnits = new List<List<Unit>>()
            {
                timeUnits,
                volumeUnits,
                wieghtUnits,
                lengthUnits,
                energyUnits,
                countUnits,
                areaUnits
            };

            foreach (var category in categoryUnits)
            { 
                foreach (var unit in category)
                {
                    await _database.InsertAsync(unit);
                }
            }
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
        public async Task<List<Unit>> GetUnitsForCategory(int categoryId)
        {
            return (await _database.Table<Unit>().ToListAsync()).Where(i => i.UnitCategoryId == categoryId).ToList();
        }
        public async Task<Unit> GetUnit(int unitId)
        {
            return (await _database.Table<Unit>().ToListAsync())
                .Where(i => i.Id == unitId)
                .First();
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

        public Task<int> UpdateItemCategory(ItemCategory itemCategory)
        {
            return _database.UpdateAsync(itemCategory);
        }

        public Task<int> RemoveItemCategory(ItemCategory itemCategory)
        {
            return _database.DeleteAsync(itemCategory);
        }

        /************ ITEM  ************/
        public Task<List<Item>> GetItems()
        {
            return _database.Table<Item>().ToListAsync();
        }
        public async Task<List<Item>> GetItemsForCategory(int categoryId)
        {
            var tmp = (await _database.Table<Item>().ToListAsync())
                .Where(
                    item => item.UnitCategoryId == categoryId
                ).ToList();
            return tmp;
        }
        public async Task<Item> GetItem(int itemId)
        {
            return (await _database.Table<Item>().ToListAsync())
                .Where(i => i.Id == itemId)
                .First();
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

        public Task<int> RemoveItemRecord(ItemRecord itemRecord)
        {
            return _database.DeleteAsync(itemRecord);
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