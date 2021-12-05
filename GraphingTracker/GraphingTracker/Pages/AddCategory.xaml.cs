using System;
using GraphingTracker.Models;
using Xamarin.Forms;
namespace GraphingTracker
{
    public partial class AddCategory : ContentPage
    {

        public AddCategory()
        {
            InitializeComponent();
 
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            pick_unit_category.ItemsSource = await App.Database.GetUnitCategories();
            pick_unit_category.SelectedIndex = 0;
        }

        async void Button_Clicked1(object sender, EventArgs e)
        {
           
            if (!string.IsNullOrWhiteSpace(category_name.Text))
            {
                await App.Database.SaveItemCategory(new ItemCategory
                {
                    Name = category_name.Text,
                    UnitCategoryId = ((UnitCategory) pick_unit_category.SelectedItem).Id,
                }) ;

                  category_name.Text = string.Empty; 
            }

            await Navigation.PopAsync();
        }

        void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
