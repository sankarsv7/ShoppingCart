using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Calculate : ICalculate
    {
       
        public decimal CalculateTotal(int apples, int oranges, decimal applePrice, decimal orangePrice)
        {
            return (apples * applePrice) + (oranges * orangePrice);
        }
    }
}
