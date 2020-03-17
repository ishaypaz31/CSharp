using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP27
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage merkaz = new Garage();
            Car mazda5 = new Car("Mazda", false, true);
            Car ford = new Car("Ford", false, true);
            merkaz.AddCar(mazda5);
            merkaz.AddCar(ford);
            merkaz.RemoveCar(ford);

           
            
        }
    }
}
