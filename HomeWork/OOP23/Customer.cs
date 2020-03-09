using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP23
{
    class Customer : IComparable<Customer>
    {

        public int ID { get; set; }

        public string Name { get; set; }

        public int BirthYear { get; set; }

        public string Address { get; set; }

        public int Protection { get; set; }

        public int TotalPurchases { get; set; }

        public Customer()
        {

        }

        public Customer(int iD, string name, int birthYear, string address, int protection, int totalPurchases)
        {
            ID = iD;
            Name = name;
            BirthYear = birthYear;
            Address = address;
            Protection = protection;
            TotalPurchases = totalPurchases;
        }

        public override string ToString()
        {
            return $"ID: {ID} , Name: {Name} , BirthYear: {BirthYear}, Address: {Address} , Protection: {Protection} , TotalPurchases: {TotalPurchases}";
        }

        public int CompareTo(Customer other)
        {
            return other.BirthYear = this.BirthYear;
        }


        public class CustomerCompareByProtection : IComparer<Customer>
        {
            public int Compare(Customer x, Customer y)
            {
                return y.Protection = x.Protection;
            }
        }
        public class CustomerCompareByTotalPurshases : IComparer<Customer>
        {
            public int Compare(Customer x, Customer y)
            {
                return y.TotalPurchases = x.TotalPurchases;
            }
        }
    }


}
