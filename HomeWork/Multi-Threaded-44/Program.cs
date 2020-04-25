using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multi_Threaded44
{
    class Program
    {
        public static Random random = new Random();

        static void Main(string[] args)
        {
            Task<int> TaskINT1 = new Task<int>(() =>
            {
                Console.WriteLine($"Task ID: {Thread.CurrentThread.ManagedThreadId}");
                int t1 = random.Next(1000, 2000);
                Thread.Sleep(t1);
                return t1;
            }, TaskCreationOptions.LongRunning);
            Task<int> TaskINT2 = new Task<int>(() =>
            {
                Console.WriteLine($"Task ID: {Thread.CurrentThread.ManagedThreadId}");
                int t2 = random.Next(1000, 2000);
                Thread.Sleep(t2);
                return t2;
            }, TaskCreationOptions.LongRunning);

            TaskINT1.Start();
            TaskINT2.Start();
            Task.WaitAny(TaskINT1, TaskINT2);
            if (TaskINT1.IsCompleted)
            {
                Console.WriteLine($"Task result is {TaskINT1.Result}");
                Console.WriteLine($"Task result is {TaskINT2.Result}");
            }
            else
            {
                Console.WriteLine($"Task result is {TaskINT1.Result}");
                Console.WriteLine($"Task result is {TaskINT2.Result}");
            }

            Console.WriteLine("---------------------------");

            Customer cust = new Customer();
            new Thread(cust.ConnectToDB).Start();
            new Thread(cust.CustomerCreate).Start();
            new Thread(cust.DeleteCustomer).Start();
            new Thread(cust.DisconnectFromDB).Start();



        }
    
    }
}
