using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_Design_Patterns_03_Momento
{
    class Program
    {
        static void Main(string[] args)
        {
            var caretaker = new Caretaker(); caretaker.F5();
            caretaker.ShootThatDumbAss();
            caretaker.F5();
            caretaker.ShootThatDumbAss();
            caretaker.ShootThatDumbAss();
            caretaker.ShootThatDumbAss();
            caretaker.ShootThatDumbAss();
            caretaker.F9();
            caretaker.ShootThatDumbAss();

            Console.ReadLine();
        }
    }
}
