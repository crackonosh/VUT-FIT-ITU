
using Xamarin.Forms;
using Xamarin.CommunityToolkit;
using Xamarin.Essentials;
using System.Collections.ObjectModel;
using System.Windows.Input;
using static GraphingTracker.AddCategoryViewModel;
using System.Linq;

namespace GraphingTracker

{
    class ManageCategoriesViewModel
    {



        public ObservableCollection<CategoryInfo> List { get; set; }



        public ManageCategoriesViewModel()
        {
            List = new ObservableCollection<CategoryInfo>();
            List.Add(new CategoryInfo() { Name = "Category 1" });
            List.Add(new CategoryInfo() { Name = "Category 2" });
            List.Add(new CategoryInfo() { Name = "Category 3" });

            MessagingCenter.Subscribe<AddCategory, CategoryInfo>(this, "AddCategory", (page, category) =>
            {
                if(category.Name == "\0")
                {
                    List.Add(category);
                } else
                {


                    CategoryInfo categoryToEdit = List.Where(emp => emp.Name == category.Name).FirstOrDefault();
                    List.Remove(categoryToEdit);

                    List.Add(category);

                }



            });



        }


        

        
    }
}
