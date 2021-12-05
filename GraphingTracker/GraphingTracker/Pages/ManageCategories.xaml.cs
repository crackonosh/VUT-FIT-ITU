using System;
using System.Collections.Generic;
using System.Linq;
using GraphingTracker.Models;
using GraphingTracker.Pages;
using Xamarin.Forms;
using static GraphingTracker.AddCategoryViewModel;
using static GraphingTracker.AddCategory;
using static GraphingTracker.ManageCategoriesViewModel;
using System.Windows.Input;

namespace GraphingTracker
{
    public partial class ManageCategories : ContentPage
    {
        public ManageCategories()
        {
            InitializeComponent();
   
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            catlist.ItemsSource = await App.Database.GetItemCategories();
            
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {

            await Navigation.PushAsync(new AddCategory());

        }

        Models.ItemCategory item;



        async void catlist_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            item = e.SelectedItem as ItemCategory;
            if(e.SelectedItem != null)
            {
                await Navigation.PushAsync(new CatInfo(item) {BindingContext = e.SelectedItem});
            }
        }



        async void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {

            var button = sender as Image;
            var plane = button?.BindingContext as ItemCategory;

            await App.Database.RemoveItemCategory(plane);
            catlist.ItemsSource = await App.Database.GetItemCategories();
           

  
        }

     
        async void TapGestureRecognizer_Tapped_1(System.Object sender, System.EventArgs e)
        {

            var button = sender as Image;
            var plane = button?.BindingContext as ItemCategory;

            await App.Database.UpdateItemCategory(plane);
            catlist.ItemsSource = await App.Database.GetItemCategories();

        }

        async void TapGestureRecognizer_Tapped_2(System.Object sender, System.EventArgs e)
        {

            await Navigation.PushAsync(new MainPage());
        }



    }
}
