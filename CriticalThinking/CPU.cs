using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinking
{
    class CPU
    {
        // Member variables
        string manufacturer;
        string name;

        // constructor
        public CPU(string manufacturer, string name)
        {
            this.manufacturer = manufacturer;
            this.name = name;
        }

        // Member methods
        public bool ProcessInstall(Applications app, HardDrive hardDrive, RAM ram, GPU gpu)
        {
            bool installOK = CheckRequirements(app, hardDrive, ram, gpu);
            if (installOK)
            {
                hardDrive.applicationsInHardDrive.Add(app);
                hardDrive.availableStorage -= app.requiredStorage;
            }
            return installOK;
        }
        public bool CheckRequirements(Applications app, HardDrive hardDrive, RAM ram, GPU gpu)
        {
            bool rtn = false;

            if (ram.totalGigabytes >= app.requiredRAM &&
                hardDrive.availableStorage >= app.requiredStorage &&
                gpu.effectiveMemory >= app.GraphicsRequirement())
                rtn = true;

            return rtn;
        }
    }
}
