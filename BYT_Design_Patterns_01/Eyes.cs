using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_Design_Patterns_01
{
    class Eyes : BodyPart
    {
        public string Picture { get; private set; } = string.Empty;
        public Eyes(Brain brain) : base(brain) { }

        public void SeeSomething()
        {
            Console.WriteLine("Enter what you see: ");
            Picture = Console.ReadLine();

            Changed();
        }

        
    }
}
