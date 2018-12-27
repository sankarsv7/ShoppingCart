using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Offer : IOffer
    {

        public int BuyOneGetOne(int fruits)
        {
            return fruits / 2 + fruits % 2;
        }

        public int ThreeForTwo(int fruits)
        {
            return (fruits / 3) * 2 + fruits % 3;
        }

    }
}
