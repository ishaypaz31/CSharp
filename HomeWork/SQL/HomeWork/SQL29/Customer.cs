using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL29HW
{
    public class Customer
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AddressCity { get; set; }
        public string AddressStreet { get; set; }
        public string PhNumber { get; set; }

        public override int GetHashCode()
        {
            return (int)Id;
        }


        public override string ToString()
        {
            return $"{Id} {Age} {FirstName} {LastName} {LastName} {AddressCity} {AddressStreet} {PhNumber}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Customer other = obj as Customer;
            if (other == null)
                return false;

            return this.Id == other.Id;
        }
    }
}
