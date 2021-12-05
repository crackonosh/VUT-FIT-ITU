using System;
using System.Collections.Generic;
using System.Linq;
using GraphingTracker.Models;
using Xamarin.Forms;
using static GraphingTracker.AddItemViewModel;

namespace GraphingTracker
{
    public partial class CatInfo : ContentPage
    {
        private ItemCategory _category { get; set; }
     
        public CatInfo(ItemCategory category)
        {
            InitializeComponent();
            Title = category.Name;
            _category = category;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            llist.ItemsSource = await App.Database.GetItemsForCategory(_category.UnitCategoryId);
        }


        private void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AddItem(_category));
        }

        void TapGestureRecognizer_edit(System.Object sender, System.EventArgs e)
        {
            
        }

        void TapGestureRecognizer_delete(System.Object sender, System.EventArgs e)
        {
        }
    }
}
