using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP19
{
    class SuperMan : Human, ISuperHero, IFly
    {
        public SuperMan(string name, int age, string speed) : base(name, age)
        {
            this.speed = speed;
        }

        public string speed { get; set; }
        public void ActivateSuperPowers()
        {
            fly();
        }
        public void fly()
        {
            Console.WriteLine("SuperMan fly!");
        }

        public override string ToString()
        {
            return $"SuperMan real name is: {GetName()}, he is ageless {GetAge()}M years, and his speed is {speed}";
        }
    }
}
