using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using static GraphingTracker.AddItemViewModel;

namespace GraphingTracker
{
    public partial class CatInfo : ContentPage
    {
     
        public CatInfo(string name)
        {
            InitializeComponent();
            lblName.Text = name;

            
        }

        private void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AddItem());
        }

        void TapGestureRecognizer_edit(System.Object sender, System.EventArgs e)
        {
            TappedEventArgs tappedEventArgs = (TappedEventArgs)e;

            Item item = ((CatInfoViewModel)BindingContext).ItemList.Where(emp => emp.Name == (string)tappedEventArgs.Parameter).FirstOrDefault();

            Navigation.PushAsync(new AddItem(item));
        }

        void TapGestureRecognizer_delete(System.Object sender, System.EventArgs e)
        {
            TappedEventArgs tappedEventArgs = (TappedEventArgs)e;

            Item item = ((CatInfoViewModel)BindingContext).ItemList.Where(emp => emp.Name == (string)tappedEventArgs.Parameter).FirstOrDefault();

            ((CatInfoViewModel)BindingContext).ItemList.Remove(item); 
        }
    }
}
