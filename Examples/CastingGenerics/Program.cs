using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r2 = new Rectangle();
            Circle c3 = new Circle();

            Console.WriteLine(r2.Igul);
            WorkWishShape(new Rectangle());
          
        }


        static void WorkWishShape(Shape s)
        {
            //Circle
            // 1
            Circle c = s as Circle;
            if (c != null)
            {

            }

            // 2
            if (s is Circle)
            {
                Circle thisShapeIsCircle = s as Circle;
                Console.WriteLine((s as Circle).Radius);

              //  Circle thisShapeIsCircle_ = (Circle)s; // direct casting 

            }

            // 3 - casting
            Circle c3 = (Circle)s; // crash if s is not Circle

            Console.WriteLine();
            // Rectangle
        }
    }
}
