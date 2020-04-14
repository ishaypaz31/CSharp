using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreaded37
{
    class Program
    {

        static void Main(string[] args)
        {
            SimpleCalculator Simple = new SimpleCalculator();
            AtomicCalculator Atomic = new AtomicCalculator();

            Atomic.Calculate = Simple.Calculate;

            Atomic.GetNumberFromUser = Simple.NumberGetter;

            Atomic.GetUserChoice = Simple.GetUserChoice;

            Atomic.MenuPrinter = Simple.PrintMenu;

            Atomic.ResultPrinter = Simple.PrintResultNicely;


            Atomic.Run();

        }
    }
}
