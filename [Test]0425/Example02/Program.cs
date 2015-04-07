using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    class Program
    {
        static void Main(string[] args)
        {
            DinerMenu dinerMenu = new DinerMenu();
            dinerMenu.AddMenuItem("aaa","a-1,a-2",true ,2.99);
            dinerMenu.AddMenuItem("bbb", "b-1,b-2", false, 2.99);

            Waitress waitress = new Waitress(dinerMenu);
            waitress.PrintMenu();
        }
    }
}
