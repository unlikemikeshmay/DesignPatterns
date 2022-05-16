using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPatternsSol.Interfaces;

namespace StrategyPatternsSol.Algorithms
{
    class RoundHouse : IKicks
    {
        public void KickTarget(string kickTarget)
        {
            Console.WriteLine("Hee-yaaah! Round House kick to the " + kickTarget + "!");
        }
    }
}
