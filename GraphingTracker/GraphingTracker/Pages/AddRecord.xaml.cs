//****************************************************
//ITU project 2021 - Graphing Tracker

//@authors - Lukas Hais, xhaisl00@fit.vutbr.cz
//         - Tadeas Kachyma, xkachy00fit.vutbr.cz
//@date - 5.12.2021
//****************************************************
using Xamarin.Forms;

namespace GraphingTracker
{
    public partial class AddRecord : ContentPage
    {

        public AddRecord()
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
            item_picker.ItemsSource = await App.Database.GetItemsForCategory(
                ((Models.ItemCategory)category_picker.SelectedItem).UnitCategoryId
            );
            item_picker.SelectedIndex = 0;
        }

        private async void categoryChanged(object sender, System.EventArgs e)
        {
            item_picker.ItemsSource = await App.Database.GetItemsForCategory(
                ((Models.ItemCategory)category_picker.SelectedItem).UnitCategoryId
                );
        }


        async void Button_Clicked_Add(System.Object sender, System.EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(counter.Text) && category_picker.IsEnabled)
            {
                await App.Database.SaveUnitCategory(new Models.ItemRecord
                {
                    Count = int.Parse(counter.Text),
                    ItemId = ((Models.Item) item_picker.SelectedItem).Id,
                    ItemCategoryId = ((Models.Item)item_picker.SelectedItem).ItemCategoryId
                });

                counter.Text = string.Empty;
                await Navigation.PopAsync();

            }
            else
            {
                await DisplayAlert("Warning", "You have to fill all fields for the item to added!", "Close");
            }  
        }

        async void Button_Clicked_Cancel(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}

