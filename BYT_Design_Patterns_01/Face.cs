using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_Design_Patterns_01
{
    class Face : BodyPart
    {
        public Face(Brain brain) : base(brain) { }

        public void Smile()
        {
            Console.WriteLine("FACE: Smilling =) ");
        }

    }
}
