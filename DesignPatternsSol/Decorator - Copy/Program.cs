using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternsSol.Decorator
{
    internal class Program
    {

        void Main(string[] args)
        {
            RegularOrder regularOrder = new RegularOrder();
            Console.WriteLine(regularOrder.CalculateTotalOrderPrice());
            Console.WriteLine();

            Preorder preorder = new Preorder();
            Console.WriteLine(preorder.CalculateTotalOrderPrice());
            Console.WriteLine();
        }
    }
}
