using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 1, 2, 3, };

            //string[] words = { "i", "Love", "PS4" };

            //ArrayList list = new ArrayList() { 1, 2, 3 };

            //list.Add(50);

            //list.RemoveAt(1);

            //list.Add("hello");

            List<Mobile> phones = new List<Mobile>()
            {
                new Mobile(2020,"IPhone 10x" ,0.9f,5500),
                new Mobile(2020,"Samsung s10" ,0.7f,4500),
                new Mobile(2020,"LG V50" ,0.5f,2700),
                new Mobile(2020,"Nokia 900" ,0.9f,3300)
            };

            phones.ForEach(m => Console.WriteLine(m));

            Console.WriteLine("============================================");

            phones.Sort(new MobileCompareByYear());


            phones.ForEach(m => Console.WriteLine(m));

            MyMobileStack stack = new MyMobileStack();
            stack.Init(phones);
            Console.WriteLine(stack.Pop());
        }
    }
}
