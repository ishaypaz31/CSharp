using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multi_Threaded44
{
    public class Customer
    {
        public AutoResetEvent are = new AutoResetEvent(false);


        public void ConnectToDB()
        {
            Console.WriteLine("Connecting to DataBase......");
            Thread.Sleep(4000);
            Console.WriteLine("Connected to DataBase! :)");
            Console.WriteLine();
            are.Set();
        }

        public void CustomerCreate()
        {
            are.WaitOne();
            Console.WriteLine("Create a new Customer....");
            Thread.Sleep(3000);
            Console.WriteLine("Customer Created! :)");
            Console.WriteLine();
            are.Set();
        }

        public void DeleteCustomer()
        {
            are.WaitOne();
            Console.WriteLine("Deleting Customer.....");
            Thread.Sleep(3000);
            Console.WriteLine("Customer deleted! :) ");
            Console.WriteLine();
            are.Set();
        }

        public void DisconnectFromDB()
        {
            are.WaitOne();
            Console.WriteLine("Disconnecting from DataBase.....");
            Thread.Sleep(3000);
            Console.WriteLine("DataBase is detached thank you! :) ");
            Console.WriteLine();
            are.Set();
        }
    }
}
