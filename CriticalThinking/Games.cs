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
        public Games(string name, string type, double reqRam, double reqStorage, double reqEffectiveMemory) : base(name, type, reqRam, reqStorage)
        {
            this.requiredEffectiveMemory = reqEffectiveMemory;
        }

        // Member methods
        public override double GraphicsRequirement()
        {
            return requiredEffectiveMemory;
        }
    }
}
