﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinking
{
    class HardDrive
    {
        // Member variables
        double totalStorage;
        public double availableStorage;
        public List<Applications> applicationsInHardDrive;

        // constructor
        public HardDrive(double totalStorage, double availableStorage)
        {
            this.totalStorage = totalStorage;
            this.availableStorage = availableStorage;
            applicationsInHardDrive = new List<Applications>();
        }

        // Member methods
    }
}
