using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    class DinerMenu : Menu
    {
        public const int MAX_ITEMS = 6;
        private MenuItems[] menuItems;
        public int NumberOfItems = 0;

        public DinerMenu()
        {
            menuItems = new MenuItems[MAX_ITEMS];
        }

        public void AddMenuItem(string name, string description, bool vegetarian, double price)
        {
            MenuItems menuItem = new MenuItems()
            {
                Name = name,
                Description = description,
                Vegetarian = vegetarian,
                Price = price,
            };
            if (this.NumberOfItems >= MAX_ITEMS)
                Console.WriteLine("菜單滿了");
            else
            {
                menuItems[NumberOfItems] = menuItem;
                NumberOfItems++;
            }

        }

        public Iterator CreateIterator()
        {
            return new DinerMenuIterator(menuItems);
        }
    }
}
