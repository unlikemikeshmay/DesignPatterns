using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternsSol.Decorator
{
    internal abstract class OrderBase
    {
        protected List<Product> products = new List<Product>
        {
            new Product {Name = "Phone",Price = 578},
            new Product {Name = "Tablet", Price = 666},
            new Product {Name = "PC",Price = 1233}
        };
        public abstract double CalculateTotalOrderPrice();

    }
}
