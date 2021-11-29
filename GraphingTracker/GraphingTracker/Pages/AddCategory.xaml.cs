using System;
using System.Collections.Generic;
using GraphingTracker.Pages;

using Xamarin.Forms;
using static GraphingTracker.AddCategoryViewModel;

namespace GraphingTracker
{
    public partial class AddCategory : ContentPage
    {
        
        public AddCategory(CategoryInfo category = null) 
        {
            InitializeComponent();
            volume.SelectedIndex = 0;
            weight.SelectedIndex = 0;
            length.SelectedIndex = 1;
            energy.SelectedIndex = 0;
            count.SelectedIndex = 0;
            area.SelectedIndex = 1;
            time.SelectedIndex = 2;


            if(category != null)
            {
                ((AddCategoryViewModel)BindingContext).Category = category;
            }    
        }


        void Button_Clicked1(System.Object sender, System.EventArgs e)
        {

            CategoryInfo category = ((AddCategoryViewModel)BindingContext).Category;


            MessagingCenter.Send(this, "AddCategory", category);
            Navigation.PopAsync();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }

    }
}
