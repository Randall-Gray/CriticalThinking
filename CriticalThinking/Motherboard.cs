using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinking
{
    class Motherboard
    {
        // Member variables
        string manufacturer;
        CPU processor;
        RAM temporaryMemory;
        HardDrive storage;
        GPU graphics;

        // constructor
        public Motherboard(string manufacturer, RAM ram, CPU cpu, HardDrive hardDrive, GPU gpu)
        {
            this.manufacturer = manufacturer;
            temporaryMemory = ram;
            processor = cpu;
            storage = hardDrive;
            graphics = gpu;
        }

        // Member methods
        public bool InstallApplication(Applications application)
        {
            return processor.ProcessInstall(application, storage, temporaryMemory, graphics);
         
        }
    }
}
