using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternsSol.Decorator.interfaces
{
    internal interface ICake
    {
        void AddLayer(string layer);
        void PrintLayers();
    }
}
