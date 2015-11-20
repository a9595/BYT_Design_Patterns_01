using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_Design_Patterns_01
{
    class Leg : BodyPart
    {
        public Leg(Brain brain) : base(brain) { }

        public void KickInTheHead()
        {
            Console.WriteLine("Kicked directly in the head with a leg. Knocked-out..");
        }


    }
}
