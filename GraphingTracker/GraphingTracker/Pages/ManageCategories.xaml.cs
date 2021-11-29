using System;
using System.Collections.Generic;
using System.Linq;
using GraphingTracker.Pages;
using Xamarin.Forms;
using static GraphingTracker.AddCategoryViewModel;
using static GraphingTracker.ManageCategoriesViewModel;



namespace GraphingTracker
{
    public partial class ManageCategories : ContentPage
    {
        public ManageCategories()
        {
            InitializeComponent();
            
        
            
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            
            await Navigation.PushAsync(new AddCategory());
            
        }



        private void TapGestureRecognizer_Tapped_Edit(Object sender, EventArgs e)
        {
            TappedEventArgs tappedEventArgs = (TappedEventArgs)e;

            CategoryInfo category = ((ManageCategoriesViewModel)BindingContext).List.Where(emp => emp.Name == (string)tappedEventArgs.Parameter).FirstOrDefault();

            Navigation.PushAsync(new AddCategory(category));
        }

        private void TapGestureRecognizer_Tapped_Remove(object sender, EventArgs e)
        {
            TappedEventArgs tappedEventArgs = (TappedEventArgs)e;

            CategoryInfo category = ((ManageCategoriesViewModel)BindingContext).List.Where(emp => emp.Name == (string)tappedEventArgs.Parameter).FirstOrDefault();

            ((ManageCategoriesViewModel)BindingContext).List.Remove(category);
        }

        async void Selected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {

            var category = e.SelectedItem as CategoryInfo;
            await Navigation.PushAsync(new CatInfo(category.Name));


        }

    }
}
