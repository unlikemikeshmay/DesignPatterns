using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPatternsSol.Decorator.interfaces;

namespace StrategyPatternsSol.Decorator
{
    internal class VanillaCake : ICake
    {
        private IList<string> layers = new List<string>();

        public void AddLayer(string layer)
        {
            layers.Add(layer);

        }

        public void PrintLayers()
        {
            foreach(var layer in layers)
            {
                Console.WriteLine($"Layer: {layer}");
            }
        }
    }
}
