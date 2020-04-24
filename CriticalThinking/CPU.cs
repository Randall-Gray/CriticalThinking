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
        public void ProcessInstall(Applications app, HardDrive hardDrive, RAM ram)
        {
            if (CheckRequirements(app, hardDrive, ram))
            {
                hardDrive.applicationsInHardDrive.Add(app);
                hardDrive.availableStorage -= app.requiredStorage;
            }
        }
        public bool CheckRequirements(Applications app, HardDrive hardDrive, RAM ram)
        {
            bool rtn = false;

            if (ram.totalGigabytes >= app.requiredRAM &&
              hardDrive.availableStorage >= app.requiredStorage)
                rtn = true;

            return rtn;
        }
    }
}
