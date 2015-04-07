using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Example02
{
    class PancakeHouseMenu
    {
        ArrayList menuItems;

        public PancakeHouseMenu()
        {
            menuItems = new ArrayList();
        }

        public void AddMenuItem(string name, string description, bool vegetarian, double price)
        {
            MenuItems menuItem = new MenuItems()
            {
                Name = name,
                Description = description,
                Vegetarian = vegetarian,
                Price = price
            };
            menuItems.Add(menuItem);
        }
        
        public Iterator CreateIterator()
        {
            return new PancakeHouseMenuIterator(menuItems);
        }
    }
}
