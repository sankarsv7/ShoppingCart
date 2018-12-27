using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
   public interface IOffer
    {
        int BuyOneGetOne(int fruits);
        int ThreeForTwo(int fruits);

    }
}
