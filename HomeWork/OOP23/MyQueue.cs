using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP23
{
    class MyQueue
    {
        List<Customer> customers;

        public MyQueue()
        {
            customers = new List<Customer>();
        }

        public void Enqueue(Customer c)
        {
            customers.Add(c);
        }

        public void Init(List<Customer> customers)
        {
            this.customers = customers;
        }

        public void Clear()
        {
            this.customers.Clear();
        }

        public Customer Dequeue()
        {
            if (customers.Count == 0)
                return null;

            Customer firstInLine = customers[0];
            customers.RemoveAt(0);
            return firstInLine;
        }

        public Customer WhoIsNext()
        {
            if (customers.Count == 0)
                return null;

            return customers[0];
        }

        public int Count
        {
            get
            {
                return customers.Count;
            }
        }

        public List<Customer> Dequeue(int number)
        {
            if (number > customers.Count)
            {
                Console.WriteLine("queue is shorter than dequeue");
            }

            if (customers.Count == 0)
            {
                return new List<Customer>();
            }

            List<Customer> result = new List<Customer>();
            while (customers.Count > 0 && result.Count < number)
            {
                result.Add(customers[0]);
                customers.RemoveAt(0);
            }

            return result;
        }
        public void AniRakSheela(Customer c)
        {
            customers.Insert(0, c);
        }

        public void SortByProtection()
        {
            customers.Sort(new Customer.CustomerCompareByProtection());
        }

        public void SortByTotalPurchases()
        {
            customers.Sort(new Customer.CustomerCompareByTotalPurshases());
        }

        public void SortByBirthYear()
        {
            customers.Sort();
        }


    }
}
