using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableIComparer
{
    
    // Here we store another comparison logic
  
    class CarHPComparer : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            //x - car 2
            //y - car 1

            //return 1 (positive) - mean x is first before obj
            // return 0 - mean both of us in same place
            // return -1 (negative) - mean y is before this

            // Car CarToCompareWith = obj as Car;

            //if (this.Year > CarToCompareWith.Year)
            //{
            //    return 1;
            //}
            //if (this.Year == CarToCompareWith.Year)
            //    return 0;
            //    return -1; // negative

            return x.HorsePower - y.HorsePower;
           // return -1 * (x.HorsePower - y.HorsePower);
        }
    }
}
