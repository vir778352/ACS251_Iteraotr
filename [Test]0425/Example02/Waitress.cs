using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    class Waitress
    {
        DinerMenu dinerMenu;
        PancakeHouseMenu pancakeHouseMenu;

        public Waitress(DinerMenu dinerMenus, PancakeHouseMenu pancakeHouseMenus)
        {
            this.dinerMenu = dinerMenus;
            this.pancakeHouseMenu = pancakeHouseMenus;
        }

        public void PrintMenu()
        {
            Iterator dinerIterator = dinerMenu.CreateIterator();
            PrintMenu(dinerIterator);
            Iterator pancakeHouseMenuIterator = pancakeHouseMenu.CreateIterator();
            PrintMenu(pancakeHouseMenuIterator);
        }

        public void PrintMenu(Iterator iterator)
        {
            while (iterator.HasNext())
            {
                MenuItems menuItems = (MenuItems)iterator.Next();
                Console.WriteLine("菜名：{0}, 價格:{1}", menuItems.Name, menuItems.Price);
            }
        }
    }
}
