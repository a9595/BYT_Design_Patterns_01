using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_Design_Patterns_01
{
    //mediator class
    class Brain
    {
        public Ears Ears { get; private set; }
        public Eyes Eyes { get; private set; }
        public Face Face { get; private set; }
        public Leg Leg { get; private set; }
        public Hand Hand { get; private set; }

        public Brain()
        {
            CreateBodyParts();
        }

        private void CreateBodyParts()
        {
            Ears = new Ears(this);
            Face = new Face(this);
            Eyes = new Eyes(this);
            Leg = new Leg(this);
        }

        public void SomethingHappenedToBodyPart(BodyPart bodyPart)
        {
            var ears = bodyPart as Ears;
            var eyes = bodyPart as Eyes;
            var leg = bodyPart as Leg;
            if (ears != null)
            {
                var heardSounds = ears.Sound;
                if (heardSounds.Contains("1")) //chuck norris
                {
                    Leg.KickInTheHead();
                }
                else if (heardSounds.Contains("2")) // normal person
                {
                    Face.Smile();
                    
                }
            }
            else if (eyes != null)
            {
                var seenPicture = eyes.Picture;
                if (seenPicture.Contains("1")) //chuck norris
                {
                    Hand.Embrace();
       
                }
                else  if(seenPicture.Contains("2")) // normal
                {
                    Leg.KickInTheHead();   
                }
            }
            
        }

        
    }
}
