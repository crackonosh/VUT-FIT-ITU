using System;
using System.Collections.Generic;
using GraphingTracker.Models;
using Xamarin.Forms;

namespace GraphingTracker
{
    public partial class ManageRecords : ContentPage
    {
        public ManageRecords()
        {
            InitializeComponent();
            
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            recordlist.ItemsSource = await App.Database.GetItemRecords();
           
            
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

        void TapGestureRecognizer_Tapped_Edit(System.Object sender, System.EventArgs e)
        {
            
        }
    }
}
