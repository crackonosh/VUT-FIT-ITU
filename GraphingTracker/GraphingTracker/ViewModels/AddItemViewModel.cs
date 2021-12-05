using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GraphingTracker
{
    public class AddItemViewModel : INotifyPropertyChanged
    {

        private Item _item;

       
        
        public class Item
        {
            public string Name { get; set; }
            public string Unit { get; set; }

            public Item(string name, string unit)
            {
                Name = name;
                Unit = unit;
            }

            public Item()
            {

            }
        }

        public Item IItem
        {
            get { return _item; }
            set { _item = value; OnPropertyChanged(); }
        }

        public AddItemViewModel() 
        {
            IItem = new Item();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
