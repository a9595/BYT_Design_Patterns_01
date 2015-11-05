using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_Design_Patterns_01
{
    class Ears : BodyPart
    {
        public string Sound { get; private set; } = String.Empty;
        public Ears(Brain brain) : base(brain) { }

        public void HearSomething()
        {
            Console.WriteLine("Enter what you hear:");
            Sound = Console.ReadLine();

            Changed();
        }
        
    }
}
