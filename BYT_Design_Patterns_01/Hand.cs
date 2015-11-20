using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_Design_Patterns_01
{
    class Hand : BodyPart
    {
        public Hand(Brain brain) : base(brain){ }

        public void Embrace()
        {
            Console.WriteLine("You've  embraced a friend...");
        }

        public void Kick()
        {
            Console.WriteLine("You've kicked him. Good job");
        }
    }
}
