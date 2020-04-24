using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinking
{
    abstract class Applications
    {
        // Member variables
        public string applicationName;
        public string applicationType;
        public double requiredRAM;
        public double requiredStorage;

        // constructor
        public Applications(string name, string type, double reqRam, double reqStorage)
        {
            applicationName = name;
            applicationType = type;
            requiredRAM = reqRam;
            requiredStorage = reqStorage;
        }

        // Member methods
        public virtual double GraphicsRequirement()
        {
            return 0;
        }
    }
}
