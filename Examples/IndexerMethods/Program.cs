using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("Honda", 200_000, "Blue", "Engine Replacement");

            //option 1
            Console.WriteLine(c1["Color"]); //return Color

            c1["Color"] = "Green";
            Console.WriteLine(c1);

            //option 2
            Console.WriteLine(c1.getData("Color")); //return Color

            Garage<Car> g = new Garage<Car>();
            g.AddHeavy(c1);
            g.AddHeavy(new Car("Ford", 230_000, "Yellow", "Shasi"));


            g.AddLight(new Car("Fiat", 130_00, "White", "Clean"));
            g.AddLight(new Car("Suzuki", 90_000, "Black", "Visher"));

            Console.WriteLine(g[2]);

            foreach(Car car in g)
            {
                Console.WriteLine(car);
            }

        }
    }
}
