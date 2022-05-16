using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPatternsSol.Interfaces;

namespace StrategyPatternsSol.Algorithms
{
    internal class FrontKick : IKicks
    {
        public void KickTarget(string kickTarget)
        {
            Console.WriteLine("whamo - Front Kick to the " + kickTarget + "!");
        }
    }
}
