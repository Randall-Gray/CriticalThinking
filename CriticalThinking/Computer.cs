using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinking
{
    class Computer
    {
        // Member variables
        public Motherboard motherboard;
        CPU cpu;
        RAM ram;
        GPU gpu;
        HardDrive hardDrive;

        // constructor
        public Computer()
        {
            cpu = new CPU("Intel", "i5-8265U");
            ram = new RAM(12, "Samsung");
            gpu = new GPU("Nvidia", 32);
            hardDrive = new HardDrive(256, 256);
            motherboard = new Motherboard("Intel", ram, cpu, hardDrive, gpu);
        }
      
        // Member methods
    }
}
