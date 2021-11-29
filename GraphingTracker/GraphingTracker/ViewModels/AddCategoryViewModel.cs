using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GraphingTracker
{
    public class AddCategoryViewModel : INotifyPropertyChanged
    {
        private CategoryInfo _category;

        public class CategoryInfo
        {
            public string Name { get; set; }

            public CategoryInfo(string name)
            {
                Name = name;
            }

            public CategoryInfo()
            {

            }

            
        }

        public CategoryInfo Category {

            get { return _category; }
            set { _category = value; OnPropertyChaned(); }
        }

        public AddCategoryViewModel()
        {
            Category = new CategoryInfo();

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChaned([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
