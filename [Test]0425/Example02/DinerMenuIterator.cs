using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    class DinerMenuIterator : Iterator
    {
        MenuItems[] menuItems;
        int Position = 0;

        public DinerMenuIterator(MenuItems[] menuItem)
        {
            this.menuItems = menuItem;
        }
        
        public bool HasNext()
        {
            if (Position >= menuItems.Length || menuItems[Position] == null)
            //if (Position >= menuItems.Length)
            {
                return false;
            }
            else
            {
                return true;
            }
            
            //return (this.Position < menuItems.Length);
        }

        public object Next()
        {
            object menuItem = menuItems[this.Position];
            this.Position++;
            return menuItem;
        }
    }
}
