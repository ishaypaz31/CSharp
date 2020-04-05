using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL31HW
{
    class ClassRoom
    {
        public Int64 Id { get; set; }
        public string Name { get; set; }
        public Int64 Code { get; set; }
        public Int64 NumberOfStudents { get; set; }
        public Int64 NumberOfVip { get; set; }
        public Int64 AgeAverage { get; set; }
        public string MostPopularCity { get; set; }
        public Int64 OldestVip { get; set; }
        public Int64 YoungestVip { get; set; }

        public static bool operator == (ClassRoom c1, ClassRoom c2)
        {
            if (ReferenceEquals(c1, null) && ReferenceEquals(c2, null))
                return true;
            if (ReferenceEquals(c1, null) || ReferenceEquals(c2, null))
                return false;
            return (c1.Id == c2.Id);
        }

        public static bool operator !=(ClassRoom c1, ClassRoom c2)
        {
            return !(c1.Id == c2.Id);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(obj,null))
                return false;

            ClassRoom c = obj as ClassRoom;

            if (ReferenceEquals(c, null))
                return false;
            return this.Id == c.Id;
        }

        public override int GetHashCode()
        {
            return Convert.ToInt32(this.Id);
        }

        public override string ToString()
        {
            return $"Class Id is {Id}, Name is {Name}, Code is {Code}, Number Of Students is {NumberOfStudents}, Number  OfVip " +
                $"{NumberOfVip}, Age Average {AgeAverage}, Most Popular City {MostPopularCity}, Oldest VIP {OldestVip}, Youngest VIP {YoungestVip}";
        }
    }
}
