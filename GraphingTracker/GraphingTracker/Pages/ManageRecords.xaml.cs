using System;
using System.Collections.Generic;
using GraphingTracker.Models;
using Xamarin.Forms;

namespace GraphingTracker
{
    public class ItemRecordForDisplay
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int ItemCategoryId { get; set; }
        public int Count { get; set; }

        public string ItemName { get; set; }
    }

    public partial class ManageRecords : ContentPage
    {
        public ManageRecords()
        {
            InitializeComponent();
            
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var tmp = await App.Database.GetItemRecords();
            var items = new List<ItemRecordForDisplay>();

            foreach (var i in tmp)
            {
                var item = await App.Database.GetItem(i.Id);
                if (item == null) continue;
                items.Add(new ItemRecordForDisplay
                {
                    Id = i.Id,
                    ItemId = i.ItemId,
                    ItemCategoryId = i.ItemCategoryId,
                    Count = i.Count,
                    ItemName = item.Name
                });
            }
            recordlist.ItemsSource = items;
            
            
        }

        ItemRecord item;
        void catlist_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            item = e.SelectedItem as ItemRecord;
        }

        async void TapGestureRecognizer_Tapped_Remove(System.Object sender, System.EventArgs e)
        {

            var button = sender as Image;
            var plane = button?.BindingContext as ItemRecord;

            await App.Database.RemoveItemRecord(plane);
            recordlist.ItemsSource = await App.Database.GetItemRecords();

        }

        async void ToolbarItem_Clicked_Add(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AddRecord());
        }

        async void TapGestureRecognizer_Tapped_Edit(System.Object sender, System.EventArgs e)
        {
      
        }
    }
}
