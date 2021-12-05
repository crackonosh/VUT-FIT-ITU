using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GraphingTracker.Pages
{
    public partial class AddGraph : ContentPage
    {
        public AddGraph()
        {
            InitializeComponent();
            category_picker.SelectedIndex = 0;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            category_picker.ItemsSource = await App.Database.GetItemCategories();
            category_picker.SelectedIndex = 0;
            category_picker.SelectedIndexChanged += categoryChanged;
            category_unit_picker.ItemsSource = await App.Database.GetUnitsForCategory(
                ((Models.ItemCategory) category_picker.SelectedItem).UnitCategoryId
            );
            category_unit_picker.SelectedIndex = 0;
            graph_type_picker.SelectedIndex = 0;
        }

        private async void categoryChanged(object sender, System.EventArgs e)
        {
            category_unit_picker.ItemsSource = await App.Database.GetUnitsForCategory(
                ((Models.ItemCategory) category_picker.SelectedItem).UnitCategoryId
                );
            category_unit_picker.SelectedIndex = 0;
        }

        protected async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        protected async void Button_Clicked_2(System.Object sender, System.EventArgs e)
        {
            await App.Database.SaveGraph(new Models.Graph
            {
                Name = graph_name_entry.Text,
                CategoryId = ((Models.ItemCategory) category_picker.SelectedItem).Id,
                GraphType = graph_type_picker.SelectedIndex
            });

            await Navigation.PopAsync();
        }
    }
}
