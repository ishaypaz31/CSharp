using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    // marker interface
    interface IOldColde
    {

    }

    interface IGoodCode
    {

    }

    interface IAreaCalculator
    {
        double GetArea(); // public and abstract

    }

    abstract class Shape
    {
        public abstract void do1();
        //public abstract double GetArea();
    }

    abstract class Circle : Shape, IOldColde, IGoodCode,IAreaCalculator
    {
        abstract public double GetArea();
    }

    class BigCircle : Circle
    {
        public override void do1()
        {
            throw new NotImplementedException();
        }

        public override double GetArea()
        {
            throw new NotImplementedException();
        }
    }
    //marker interface
    //interface - contract of abilities
}
