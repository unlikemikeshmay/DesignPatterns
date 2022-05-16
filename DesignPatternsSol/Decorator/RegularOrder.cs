using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternsSol.Decorator
{
    internal class RegularOrder : OrderBase
    {
        public override double CalculateTotalOrderPrice()
        {
            Console.WriteLine("Calculating the total price of a regular order");
            return products.Sum(p => p.Price);
        }
    }
}
