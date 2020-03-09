using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP23
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer(1254785,"Gil",1978,"Paris",2500,9800),
                new Customer(1254785,"Mor",1992,"Rome",7000,3600),
                new Customer(1254785,"Leon",1985,"New York",5000,9800),
                new Customer(1254785,"Tom",1987,"Tel Aviv",8900,2870),
                new Customer(1254785,"Guy",1987,"Jerusalem",2780,2500),
                new Customer(1254785,"Meir",1955,"Paris",1500,3400)
            };

            customers.ForEach(c => Console.WriteLine(c));

            Console.WriteLine("==========================================");

            customers.Sort();


            MyQueue stack = new MyQueue();
            stack.Init(customers);
            Console.WriteLine(stack.Dequeue());
        }
    }
}

