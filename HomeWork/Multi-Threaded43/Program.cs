using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multi_Threaded_43
{
    class Program
    {
        static void Main(string[] args)
        {
;
            Console.WriteLine(MyTimer.GetInstance().GetTime());
            Thread.Sleep(2000);
            Console.WriteLine($"----------------------------------");
            AsyncPrinter printer = new AsyncPrinter();
            List<Thread> threads = new List<Thread>();

            AsyncPrinter async = new AsyncPrinter();
            new Thread(() => { async.CheckPrintMessage(); }).Start();
            new Thread(() => { async.CheckPrintMessage(); }).Start();
            new Thread(() => { async.CheckPrintMessage(); }).Start();
            new Thread(() => { async.CheckPrintMessage(); }).Start();
            new Thread(() => { async.CheckPrintMessage(); }).Start();
            new Thread(() => { async.CheckPrintMessage(); }).Start();
            new Thread(() => { async.CheckPrintMessage(); }).Start();
            new Thread(() => { async.CheckPrintMessage(); }).Start();
            new Thread(() => { async.CheckPrintMessage(); }).Start();
            new Thread(() => { async.CheckPrintMessage(); }).Start();
            for (int i = 1; i <= 10; i++)
            {
                async.AddMessage(MyTimer.GetInstance().GetTime());
                Thread.Sleep(100);
            }

            for (int i = 0; i < 100; i++)
            {
                Thread Print = new Thread(() => printer.AddMessage(Convert.ToString(DateTime.Now)));
                Print.Start();
                for (int j = 0; j <= 100; j++)
                {
                    // Console.Write("Counting: ");
                    Console.WriteLine(string.Format("{0}", j));
                    Thread.Sleep(3);
                }
            }
            Console.WriteLine("Thread Ninja!!!");


            Console.ReadLine();
        }
    }
}
