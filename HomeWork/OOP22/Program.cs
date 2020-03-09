using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP22
{
    class Program
    {
        static void Main(string[] args)
        {
            Camp Avivim = new Camp(1000, 350, 1600, 200, 30);

            Camp Afikim = new Camp(500, 200, 900, 3000, 1700);

            Camp avivimAfikim = Avivim + Afikim;

            Console.WriteLine($"new camp: = {avivimAfikim}");

            Console.WriteLine($"Avivim > Afikim {Avivim > Afikim}");

            Console.WriteLine($"Avivim < Afikim {Avivim < Afikim}");

            Console.WriteLine(Avivim == Afikim);

            if (Avivim > Afikim)
                Console.WriteLine("Avivim is bigger");


        }
    }
}
