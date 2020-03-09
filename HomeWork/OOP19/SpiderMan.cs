using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP19
{
    class SpiderMan : Human, ISuperHero, IClimb
    {
        public SpiderMan(string name, int age, int webLeft) : base(name, age)
        {
            WebLeft = webLeft;
        }

        public int WebLeft { get; set; }


        public void ActivateSuperPowers()
        {
            Climb();
        }
        public void Climb()
        {
            Console.WriteLine("SpiderMan, spiderMan!");
        }

        public override string ToString()
        {
            return $"SpiderMan name: {GetName()}, his age: {GetAge()}, he has {WebLeft} webs ";
        }
    }
}
