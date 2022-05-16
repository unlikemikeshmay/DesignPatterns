using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPatternsSol.Decorator.interfaces;

namespace StrategyPatternsSol.Decorator
{
    internal class CakeMessageDecorator : ICakeMessageDecorator
    {
        private readonly ICake cake;
        public CakeMessageDecorator(ICake cake)
        {
            this.cake = cake;
        }
        public void Decorate(string message)
        {
            cake.AddLayer($"message for the cake: {message}");
        }
    }
}
