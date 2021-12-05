using System;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using static GraphingTracker.AddCategoryViewModel;
using static GraphingTracker.AddItemViewModel;

namespace GraphingTracker
{
    public class CatInfoViewModel
    {
        
         public  ObservableCollection<Item> ItemList { get; set; }

        public CatInfoViewModel()
        {
            ItemList = new ObservableCollection<Item>();
            ItemList.Add(new Item() { Name = "Radegast 10", Unit = "litry" });
            ItemList.Add(new Item() { Name = "Radegast 12", Unit = "litry" });
            ItemList.Add(new Item() { Name = "Radegast Ratar", Unit = "litry" });
            ItemList.Add(new Item() { Name = "Radegast 14", Unit = "litry" });

            MessagingCenter.Subscribe<AddItem, Item>(this, "Add Item", (page, item) =>
            {
                if(item.Name == "\0")
                {
                    ItemList.Add(item);

                }
                else
                {
                    Item itemToEdit = ItemList.Where(emp => emp.Name == item.Name).FirstOrDefault();
                    ItemList.Remove(itemToEdit);
                    ItemList.Add(item);
                }
            });
        }


    }

}
