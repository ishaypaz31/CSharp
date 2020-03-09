using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatosOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(8, 10);

            Point b = new Point(8, 10);

            if (a == b)
            {
                Console.WriteLine("same value");
            }
            else
            {
                Console.WriteLine("not the same value");
            }

            Person p1 = new Person("Mike", "Brant", 40, 1);
            Person p2 = new Person("Mike", "Brant", 40, 1);

            if (p1.GetHashCode() == p2.GetHashCode())
            {
                Console.WriteLine("same person");
            }

        }
    }
}
