using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multi_Threaded__41
{
    public class MultiPlan
    {
        int result;

        public void MathPlan()
        {
            int num1 = 7;
            int num2 = 18;
            int Answer = num1 * num2;

            Thread t = new Thread(() =>
            {
                Console.WriteLine("Please Answer The Following Multiplication Calculation: 7 * 18 ");
                Console.WriteLine("You Have 5 Second");
                Console.WriteLine("Starting Know........");
                Thread.Sleep(1500);
                for (int i = 5; i >= 1; i--)
                {
                    Console.WriteLine($"{i} Seconds left....");
                    Thread.Sleep(2000);
                }
                Console.WriteLine("Time over...........");
            });
            t.Start();

            result = Convert.ToInt32(Console.ReadLine());

            if (result == Answer)
            {
                Console.WriteLine("Great Answer ! ! !");
            }
            else
            {
                Console.WriteLine("Wrong Answer");
            }
            t.Abort();
        }




    }
}
