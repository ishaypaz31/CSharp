using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableIComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            Car honda = new Car("Honda", 2036, 110);
            Car suzuki = new Car("Suzuki", 2016, 90);
            Car mitsubishi = new Car("Mitsubishi", 2030, 150);

            Car[] cars = { honda, suzuki, mitsubishi };

            PrintCars(cars);

            Array.Sort(cars);


            Console.WriteLine("Compare by year:");
            PrintCars(cars);

            Console.WriteLine("Compare by horse power:");
            CarHPComparer comparebyhp = new CarHPComparer();
            Array.Sort(cars,comparebyhp);
            PrintCars(cars);

        }

        static void PrintCars(Car[] cars)
        {
            foreach (Car c in cars)
            {
                Console.WriteLine(c);
            }
        }
    }
}
