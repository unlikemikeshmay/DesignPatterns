using System;
using StrategyPatternsSol.Context;
using StrategyPatternsSol.Algorithms;

namespace StrategyPatternsSol.Strategy;

class KickStrategyDesign
{
    static void Main(string[] args)
    {
        KickContext kickContext = new KickContext(new RoundHouse());
        kickContext.DoKick("right in the kisser");

        kickContext.SetKick(new FrontKick());
        kickContext.DoKick("Butt");
    }
}
