using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP18
{
    internal class Point
    {
        private int _x;
        private int _y;


        internal Point(int x , int y)
        {
            this._x = x;
            this._y = y;
        }

        internal int GetX()
        {
            return _x;
        }

        internal int GetY()
        {
            return _y;
        }

        internal void SetX(int x)
        {
            if (x < 0 || x > MyCanvas.MaxWidth)
            {
                Console.WriteLine($"the value {x} is illegal");
            }
            else
            {
                _x = x;
                Console.WriteLine($"the Value {x} has been Set");
            }
        }

        internal void SetY (int y)
        {
            if (y < 0 || y > MyCanvas.MaxHeight)
            {
                Console.WriteLine($"the value {y} is illegal");
            }
            else
            {
                _y = y;
                Console.WriteLine($"the Value {y} has been Set");
            }
        }

        public override string ToString()
        {
           return $"x is {_x} and y is {_y}";
        }
    }
}
