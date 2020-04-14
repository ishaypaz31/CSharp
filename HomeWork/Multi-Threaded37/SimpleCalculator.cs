using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//delegate,Invoke,Action ,Func
namespace MultiThreaded37
{
    public class SimpleCalculator
    {
        public int NumberGetter()
        {
            int number = 0;
            bool numCheck = false;
            while (!numCheck || number <= 0)
            {
                Console.WriteLine("Please Type a Positive Number");
                numCheck = int.TryParse(Console.ReadLine(), out number);
            }
            return number;
        }

        public void PrintMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("-------------");
            Console.WriteLine("option 1 =  + ");
            Console.WriteLine("option 2 =  - ");
            Console.WriteLine("option 3 =  / ");
            Console.WriteLine("option 4 =  * ");
        }

        public int GetUserChoice()
        {
            int num = 0;
            bool num1Test = false;
            while (!num1Test || num <= 0 || num >= 5)
            {
                Console.WriteLine("Please Select One Of The Options (From The Menu Only!!)");
                Console.WriteLine("--------------------------------------");
                PrintMenu();
                num1Test = int.TryParse(Console.ReadLine(), out num);
            }
            return num;
            //Please select one of the options from the menu only
        }


        public double Calculate(int Number1,int Number2, int option)
        {
            switch (option)
            {
                case 1: return (double)Number1 + (double)Number2;
                case 2: return (double)Number1 - (double)Number2;
                case 3: return (double)Number1 / (double)Number2;
                case 4: return (double)Number1 * (double)Number2;
            }
            return 5.5;
        }

        public void PrintResultNicely(double Number)
        {
            Console.WriteLine();
            Console.WriteLine($"Your Result: ***{Number}***");
        }

    }
}
