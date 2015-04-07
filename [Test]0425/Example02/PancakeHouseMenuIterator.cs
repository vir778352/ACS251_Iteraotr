using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Example02
{
    class PancakeHouseMenuIterator : Iterator
    {
        ArrayList menuItems;
        int Position = 0;

        public PancakeHouseMenuIterator(ArrayList menuItem)
        {
            this.menuItems = menuItem;
        }
        
        public bool HasNext()
        {
            if (Position >= menuItems.Count || menuItems[this.Position] == null)
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
