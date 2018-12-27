using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class FruitsCount : IFruitsCount
    {
        public void Fruits(string[] fruit, ref int apple, ref int orange)
        {
            apple = fruit.Count(a => a.Trim().ToLower() == "apple");
            orange = fruit.Count(a => a.Trim().ToLower() == "orange");
        }
    }
}
