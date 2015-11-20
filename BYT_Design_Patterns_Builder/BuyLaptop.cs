using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_Design_Patterns_Builder
{
    class BuyLaptop
    {
        private LaptopBuilder _laptopBuilder;

        public void SetLaptopBuilder(LaptopBuilder lBuilder)
        {
            _laptopBuilder = lBuilder;
        }

        public Laptop GetLaptop()
        {
            return _laptopBuilder.GetMyLaptop();
        }

        public void ContructLatop()
        {
            _laptopBuilder.CreateNewLaptop();
            _laptopBuilder.SetHDD();
            _laptopBuilder.SetProcessor();
            _laptopBuilder.SetProcessor();
            _laptopBuilder.SetHDD();

        }
    }
}
