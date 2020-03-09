using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP25
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight Tom = new Knight("Tom", "Haifa", "magic tricks cards");
            Knight Leon = new Knight("Leon", "Tel Aviv", "Illusionist");
            Knight Jack = new Knight("Jack", "New York", "Mentalist ");
            Magician Zehev = new Magician("Zehev","Netanya", "Mathmagician ");
            Magician Daniel = new Magician("Daniel","Jerusalem", "Clairvoyant ");
            Magician Yotam = new Magician("Yotam","Zefat", "Mind reader");


            RoundTable<Knight> knights = new RoundTable<Knight>();
            RoundTable<Magician> magician = new RoundTable<Magician>();
            knights.Add(Tom);
            knights.Add(Leon);
            knights.Add(Jack);
            magician.Add(Zehev);
            magician.Add(Daniel);
            magician.Add(Yotam);
            magician.InsertAt(1, new Magician("Donald", "Miami", "Hypnotist "));

            Yotam["Name"] = "Alex";
            Console.WriteLine(knights[0]);
            foreach(Knight knight in knights)
            {
                Console.WriteLine(knight);
            }
            foreach(Magician magi in magician)
            {
                Console.WriteLine(magi);
            }
            magician.RemoveAt(2);
            magician.RemoveAt(0);
            
            foreach(Magician mag in magician)
            {
                Console.WriteLine(mag);
            }

        }
    }
}
