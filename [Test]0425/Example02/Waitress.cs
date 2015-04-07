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

        public Waitress(DinerMenu dinerMenus)
        {
            this.dinerMenu = dinerMenus;
        }

        public void PrintMenu()
        {
            Iterator dinerIterator = dinerMenu.CreateIterator();
            PrintMenu(dinerIterator);
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
