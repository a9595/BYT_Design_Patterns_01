using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_Design_Patterns_Builder
{
    abstract class LaptopBuilder
    {
        protected Laptop Laptop { get; private set; }

        public void CreateNewLaptop()
        {
            Laptop = new Laptop();
        }

        public Laptop GetMyLaptop()
        {
            return Laptop;
        }

        public abstract void SetMonitorResolution();
        public abstract void SetProcessor();
        public abstract void SetMemory();
        public abstract void SetHDD();

    }
}
