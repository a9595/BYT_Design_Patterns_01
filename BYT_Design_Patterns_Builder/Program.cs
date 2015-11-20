using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_Design_Patterns_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var workLaptopBuilder = new WorkLaptopBuilder();
            var GamingLaptopBuilder= new GamingLaptopBuilder();
            var shopForYou = new BuyLaptop();

            //customer which wants to play games :)
            shopForYou.SetLaptopBuilder(GamingLaptopBuilder);
            shopForYou.ContructLatop();

            //give it to him 
            Laptop laptop = shopForYou.GetLaptop();
            Console.WriteLine(laptop.ToString());

        }
    }
}
