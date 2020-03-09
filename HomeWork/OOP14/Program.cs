using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP14
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Computer ASUS = new Computer("ASUS", 7500, 9, 17.5);
            ASUS.TellMeThePrice();
            ASUS.TellMeTheScreenSize();


           
            //2
            Computer DELL = new Computer("DELL", 9000, 8, 15.5);
            DELL.TellMeThePrice();
            DELL.TellMeTheScreenSize();

            //3
            Computer Apple = new Computer("Apple", 11000, 10, 16.5);
            Apple.TellMeThePrice();
            Apple.TellMeTheScreenSize();

          // Apple.TurnOff(); not working good!!!

            Console.WriteLine(ASUS);

            Console.WriteLine(DELL);

            Console.WriteLine(Apple);

            Console.ReadLine();
        }
    }
}
