using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public interface IFruitsCount
    {
        void Fruits(string[] fruit, ref int apple, ref int orange);
    }
}
