using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL31HW
{
    public class Student
    {
        public Int64 Id { get; set; }
        public string Name { get; set; }
        public Int64 Age { get; set; }
        public string AddressCity { get; set; }
        public string Vip { get; set; }
        public Int64 ClassID { get; set; }

        public static bool operator ==(Student s1, Student s2)
        {
            if (ReferenceEquals(s1, null) && ReferenceEquals(s2, null))
                return false;
            if (ReferenceEquals(s1, null) || ReferenceEquals(s2, null))
                return false;
            return (s1.Id == s2.Id);
        }
        public static bool operator !=(Student s1, Student s2)
        {
            return !(s1.Id == s2.Id);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(obj, null))
                return false;

            Student s = obj as Student;

            if (ReferenceEquals(s, null))
                return false;
            return this.Id == s.Id;
        }

        public override int GetHashCode()
        {
            return Convert.ToInt32(this.Id);
        }

        public override string ToString()
        {
            return $"Student Id is {Id}, Name is {Name}, Age is {Age}, Address City is {AddressCity}, If Vip? {Vip}, Class Id is {ClassID}";
        }
    }
}
