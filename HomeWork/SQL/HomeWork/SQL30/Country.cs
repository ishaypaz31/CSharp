using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL30HW
{
    class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SizeKm { get; set; }
        public int BirthYear { get; set; }
        public int CapitalCityId { get; set; }

        public static bool operator ==(Country c1, Country c2)
        {
            if (c1 == null && c2 == null)
                return true;
            if (c1 == null || c2 == null)
                return false;
            return c1.Id == c2.Id;
        }
        public static bool operator !=(Country c1, Country c2)
        {
            return !(c1 == c2);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Country c = obj as Country;
            if (c == null)
                return false;
            return this.Id == c.Id;
        }

        public override int GetHashCode()
        {
            return this.Id;
        }

        public override string ToString()
        {
            return $"Country ID: {Id}, Name:{Name},SizeKM{SizeKm},Birth Year:{BirthYear},Capital City ID:{CapitalCityId}";
        }
    }
}
