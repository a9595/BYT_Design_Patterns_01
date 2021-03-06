﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_Design_Patterns_Builder
{
    class GamingLaptopBuilder : LaptopBuilder
    {
        public override void SetMonitorResolution()
        {
            Laptop.MonitorResolution = "1900x1200";
        }

        public override void SetProcessor()
        {
            Laptop.Processor = "i7";
        }

        public override void SetMemory()
        {
            Laptop.Memory = "6144 Mb";
        }

        public override void SetHDD()
        {
            Laptop.Hdd = "2Tb";
        }

    }
}
