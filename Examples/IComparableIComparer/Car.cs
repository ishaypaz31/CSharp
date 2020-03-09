using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableIComparer
{
    class Car : IComparable<Car>
    {
        public string Model { get; private set; }
        public int Year { get; private set; }
        public int HorsePower { get; private set; }

        public Car(string model, int year, int horsePower)
        {
            Model = model;
            Year = year;
            HorsePower = horsePower;
        }

        public override string ToString()
        {
            return $"Car Model : {Model,15}    Year : {Year,5}    Horse Power : {HorsePower,7}";
        }

        public int CompareTo(Car CarToCompareWith)
        {
            //obj - car 2
            //this - car 1

            //return 1 (positive) - mean this is first before obj
            // return 0 - mean both of us in same place
            // return -1 (negative) - mean obj is before this

           // Car CarToCompareWith = obj as Car;
            
            //if (this.Year > CarToCompareWith.Year)
            //{
            //    return 1;
            //}
            //if (this.Year == CarToCompareWith.Year)
            //    return 0;
            //    return -1; // negative

            return this.Year - CarToCompareWith.Year; 
        }
    }
}
