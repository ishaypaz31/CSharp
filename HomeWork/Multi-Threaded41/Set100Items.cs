using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;


namespace Multi_Threaded__41
{
    class Set100Items
    {
        static Stopwatch GlobalTimer = new Stopwatch();
        static Stopwatch Timer = new Stopwatch();
        static int[] Numbers = new int[1000];

        public static void Set100ItemsInArray(object parameter)
        {
            int param = (int)parameter;
            Timer.Start();
            for (int i = 0; i < param; i++)
            {
                Numbers[i] = i + (param - 1);
                Console.WriteLine(string.Format("{0}", i));

            }
            Timer.Stop();
            Console.WriteLine("Time Elapsed:" + Timer.ElapsedMilliseconds);
        }

        public static void Set100ItemsSimple()
        {
            Timer.Start();
            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = i;
                Console.WriteLine(string.Format("{0}", i));
            }
            Timer.Stop();
            Console.WriteLine("Time Elapsed:" + Timer.ElapsedMilliseconds);
        }

        public static void PrintArray()
        {
            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.Write(Numbers[i] + ",");
            }

        }
        public void Threads()
        {
            Thread p0 = new Thread(PrintArray);
            Thread t1 = new Thread(Set100ItemsInArray);
            Thread t2 = new Thread(Set100ItemsInArray);
            Thread t3 = new Thread(Set100ItemsInArray);
            Thread t4 = new Thread(Set100ItemsInArray);
            Thread t5 = new Thread(Set100ItemsInArray);
            Thread t6 = new Thread(Set100ItemsInArray);
            Thread t7 = new Thread(Set100ItemsInArray);
            Thread t8 = new Thread(Set100ItemsInArray);
            Thread t9 = new Thread(Set100ItemsInArray);
            Thread t10 = new Thread(Set100ItemsInArray);
            GlobalTimer.Start();

            t1.Start(0);
            t2.Start(100);
            t3.Start(200);
            t4.Start(300);
            t5.Start(400);
            t6.Start(500);
            t7.Start(600);
            t8.Start(700);
            t9.Start(800);
            t10.Start(900);

            //Set100ItemsSimple();
            GlobalTimer.Stop();
            Console.WriteLine("Global Thread time" + GlobalTimer.ElapsedMilliseconds);
            Thread.Sleep(3000);
            Console.WriteLine("-------------------------------------");
        }

    }
}
