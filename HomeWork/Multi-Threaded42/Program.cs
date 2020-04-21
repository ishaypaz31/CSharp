using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multi_Threaded_42
{
    class Program
    {
        private static void PrintNumbers()
        {
            Stopwatch Timer = new Stopwatch();
            Timer.Start();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(500);
            }
            Timer.Stop();
            Console.WriteLine("Time Elapsed:" + Timer.ElapsedMilliseconds);

        }

        private static void HelloWorld()
        {
            Stopwatch Timer2 = new Stopwatch();
            Timer2.Start();
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Hello world!");
                Thread.Sleep(250);
            }
            Timer2.Stop();
            Console.WriteLine("Time Elapsed:" + Timer2.ElapsedMilliseconds);


        }

        static void Main(string[] args)
        {
            ThreadExecutor executor = new ThreadExecutor();
            
            for (int i = 0; i < 20; i++)
            {
                executor.Add(new Thread(PrintNumbers));
                executor.Execute();

                executor.Add(new Thread(HelloWorld));
                executor.Execute();

                executor.Add(new Thread(() => Console.WriteLine("Lambda Expression")));
                executor.Execute();
            }
            Console.WriteLine("Main Has Finished ! ! ! ");

            Thread.Sleep(10 * 1000);


        }
    }
}
