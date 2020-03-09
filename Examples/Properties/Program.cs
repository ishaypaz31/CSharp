using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit fruit = new Fruit("Apple", 200);

            int cal = fruit.GetCalories();

            int cal2 = fruit.Calories;
            fruit.Calories = 300;//change the value to 300 from 200

            Console.WriteLine(fruit.Description);//apply Description function
        }
    }
}
