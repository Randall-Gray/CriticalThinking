using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinking
{
    class Games : Applications
    {
        // Member variables
        public double requiredEffectiveMemory;

        // constructor

        // Member methods
        public override double GraphicsRequirement()
        {
            return requiredEffectiveMemory;
        }
    }
}
