using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multi_Threaded_47
{
    class Program
    {
        public const string FilePath = @"C:\sqllite\Text.txt";
        public const int Range = 1000;
        public const int Delay = 100;

        private async static Task WriteToFile()
        {
            StreamWriter sw = new StreamWriter(FilePath);
            for (int i = 1; i <= Range; i++)
            {
                await sw.WriteAsync(i.ToString() + " ");
                Thread.Sleep(10);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ready. Wait 5 seconds ... very busy now");
            Task t = WriteToFile();
            while (!t.Wait(10))
            {
                Console.Write(".");
                Console.WriteLine();
            }

            Console.WriteLine("Done!!!");
        }
        
    }
}


