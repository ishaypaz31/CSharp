using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryTryget
{
    public class Customer
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public int BirthYear { get; set; }

        public Customer(int iD, string name, string address, int birthYear)
        {
            ID = iD;
            Name = name;
            Address = address;
            BirthYear = birthYear;
        }

        public override string ToString()
        {
            return $"Customer ID: {ID} , Name: {Name} , Address: {Address} , Birth Year: {BirthYear}";
        }
    }
}
