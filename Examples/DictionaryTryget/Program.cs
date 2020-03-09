using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryTryget
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1,"one");
            dictionary.Add(2, "Two");
            dictionary.Add(3, "Three");
            dictionary.Add(4, "Four");
            dictionary.Add(5, "Five");
            dictionary.Add(6, "Six");
            dictionary.Add(7, "Seven");
            dictionary.Add(8, "Eight");
            dictionary.Add(9, "Nine");
            dictionary.Add(-1, "Exit");

            string result = string.Empty;

            do
            {
                Console.WriteLine("Enter Number");
                int number = Convert.ToInt32(Console.ReadLine());

                if (dictionary.TryGetValue(number, out result))
                {
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("Not Found!");
                }

            } while (result != "Exit");



            Customer c1 = new Customer(3, "Moshe", "Hertzelia", 1987);
            Customer c2 = new Customer(100, "Mor", "Jerusalem", 1987);
            Customer c3 = new Customer(2, "Leon", "Tel Aviv", 1987);

            Dictionary<Customer, string> dictionarySecret = new Dictionary<Customer, string>();
            dictionarySecret.Add(c1, "one");
            if (dictionarySecret.TryGetValue(c1, out string custPwd))
            {
                Console.WriteLine(custPwd);
            }
            //Dictionary<int, Customer> dictionary = new Dictionary<int, Customer>();
            //dictionary.Add(3, c1);
            //dictionary.Add(100, c2);
            //dictionary.Add(2, c3);

            //Customer cust = dictionary[2];


            //Customer cust = null;
            //if (dictionary.ContainsKey(55))
            //{
            //    cust = dictionary[55];
            //}

            //if (dictionary.TryGetValue(55, out Customer ress55))
            //{
            //    Console.WriteLine(ress55);
            //}

            //ress55 = null;
            //Console.WriteLine(cust);

        }
    }
}
