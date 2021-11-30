using System;
using System.Collections.Generic;
using GraphingTracker.Pages;
using Xamarin.Forms;
using static GraphingTracker.AddItemViewModel;

namespace GraphingTracker
{
    public partial class AddItem : ContentPage
    {
        public AddItem(Item item = null)
        {
            InitializeComponent();

            if(item != null)
            {
                ((AddItemViewModel)BindingContext).IItem = item;
            }

        }

        

       

        void Button_Clicked_2(System.Object sender, System.EventArgs e)
        {
            Item item = ((AddItemViewModel)BindingContext).IItem;
            if (item.Name == "\0")
            {

            }
            else
            {
                MessagingCenter.Send(this, "AddItem", item);
                Navigation.PopAsync();
            }
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }

     

    }
}
