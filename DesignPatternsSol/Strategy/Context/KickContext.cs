using StrategyPatternsSol.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternsSol.Context
{
    internal class KickContext
    {
        private IKicks Kicks;
        public KickContext(IKicks Kicks)
        {
            this.Kicks = Kicks;
        }
        public void SetKick(IKicks Kicks)
        {
            this.Kicks = Kicks;
        }
        public void DoKick(string kickTarget)
        {
            Kicks.KickTarget(kickTarget);
        }
    }
}
