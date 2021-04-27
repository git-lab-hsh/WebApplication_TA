using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4_2_Shop
{
    public class Menu
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int Order { get; set; }

        public decimal Total()
        {
            return Price * Order;
        }


    }

}
