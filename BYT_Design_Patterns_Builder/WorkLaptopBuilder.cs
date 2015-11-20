using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_Design_Patterns_Builder
{
    class WorkLaptopBuilder : LaptopBuilder
    {
        public override void SetMonitorResolution()
        {
            Laptop.MonitorResolution = "1200x800";
        }

        public override void SetProcessor()
        {
            Laptop.Processor = "i3";
        }

        public override void SetMemory()
        {
            Laptop.Memory = "2048 Mb";
        }

        public override void SetHDD()
        {
            Laptop.Hdd = "300 Gb";
        }

    }
}
