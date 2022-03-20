using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger_Restaurant
{
    public class Menu
    {
        //This class has the properties of extra products
        public string MenuName { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return MenuName + "Menu";
        }
    }
}
