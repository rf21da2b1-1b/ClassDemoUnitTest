using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoUnitTest.model
{
    public class ItemKatalog
    {
        private readonly List<Item> items = new List<Item>();

        public ItemKatalog()
        {
            if (items.Count == 0) // empty
            {
                //hack fill the list if it's empty
                items.Add(new Item(1, "Milk", 15.5));
                items.Add(new Item(2, "Coffee", 34.5));
                items.Add(new Item(3, "Cola", 12));
                items.Add(new Item(4, "The", 37.5));
                items.Add(new Item(5, "Water - still", 10.0));
            }
        }


        public void Add(Item item)
        {
            items.Add(item);
        }

        public void Clear()
        {
            items.Clear();
        }

        public int Count => items.Count;

        public List<Item> GetItemsOverPrice(double price)
        {
            if (price < 0)
            {
                throw new ArgumentException("Can not search using negative values");
            }
            return items.Where(i => i.Price >= price).ToList();
        }
    }
}
