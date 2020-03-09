using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP19
{
    class Flash : Human, ISuperHero, IFlash
    {

        public Flash(string name, int age, int voltage) : base(name, age)
        {
            Voltage = voltage;
        }

        public int Voltage { get; private set; }

        public void ActivateSuperPowers()
        {
            FireLightnings();
        }
        public void FireLightnings()
        {
            Console.WriteLine("Firing!");
        }

        public override string ToString()
        {
            return $"Flash name: {GetName()}, his age: {GetAge()}, and his voltage:{Voltage}";
        }
    }
}
