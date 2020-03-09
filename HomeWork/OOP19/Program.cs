using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP19
{
    class Program
    {
        static void ActivateSuperhero(ISuperHero Hero)
        {
            Console.WriteLine($"{Hero.GetType()} Powers activated!");
        }

        static void IdentifyHero(ISuperHero Heroes)
        {
            if (Heroes.GetType() == typeof(Flash))
            {
                Console.WriteLine($"Flash detected");
            }
            if (Heroes.GetType() == typeof(SpiderMan))
            {
                Console.WriteLine($"SpiderMan detected");
            }
            if (Heroes.GetType() == typeof(SuperMan))
            {
                Console.WriteLine($"SuperMan detected");
            }


        }
        static void GetMoreHeroData(ISuperHero Heroes2)
        {
            if (Heroes2 is Flash)
            {
                Flash flash1 = (Flash)Heroes2;
                Console.WriteLine($"Flash voltage: {flash1.Voltage} V");
            }

            if (Heroes2 is SpiderMan)
            {
                SpiderMan spider1 = (SpiderMan)Heroes2;
                Console.WriteLine($"SpiderMan has: {spider1.WebLeft} web left ");
            }

            else if (Heroes2 is SuperMan)
            {
                SuperMan super1 = (SuperMan)Heroes2;
                Console.WriteLine($"SuperMan speed is: {super1.speed} ");
            }
        }

        static void CreateHero(ISuperHero Heroes)
        {

            if (Heroes.GetType() == typeof(Flash))
            {
                Flash flash1 = new Flash("New Flash", 20, 600);
                Console.WriteLine("New object");
                Console.WriteLine(flash1.ToString());
            }

            if (Heroes.GetType() == typeof(SuperMan))
            {
                SuperMan super1 = new SuperMan("New Clark", 33, "270");
                Console.WriteLine("New object");
                Console.WriteLine(super1.ToString());
            }
            else if (Heroes.GetType() == typeof(SpiderMan))
            {
                SpiderMan spider1 = new SpiderMan("New Spider", 21, 200);
                Console.WriteLine("New object");
                Console.WriteLine(spider1.ToString());
            }
        }
        static void Main(string[] args)
        {
            Flash flash = new Flash("Flash", 24, 250);

            SpiderMan spiderman = new SpiderMan("Peter Parker", 28, 1000);

            SuperMan superman = new SuperMan("Clark Kent", 500, "Faster");

            Console.WriteLine(flash.ToString());
            ActivateSuperhero(flash);
            Console.WriteLine(spiderman.ToString());
            ActivateSuperhero(spiderman);
            Console.WriteLine(superman.ToString());
            ActivateSuperhero(superman);

            IdentifyHero(spiderman);
            IdentifyHero(superman);
            IdentifyHero(flash);
            Console.WriteLine();

            GetMoreHeroData(flash);
            GetMoreHeroData(superman);
            GetMoreHeroData(spiderman);
            Console.WriteLine();

            CreateHero(flash);
            CreateHero(spiderman);
            CreateHero(superman);
        }
    }
}
