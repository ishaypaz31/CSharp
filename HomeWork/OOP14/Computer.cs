using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP14
{
    public class Computer
    {
        public string _model;

        public int _price;

        public int _numberOfProcessors;

        public double _screenSize;

        public bool _isTurnOn;


        public Computer(string Model,int Price,int NumberOfProcessors ,double ScreenSize)
        {
            this._model = Model;
            this._price = Price;
            this._numberOfProcessors = NumberOfProcessors;
            this._screenSize = ScreenSize;
        }

        public double TellMeThePrice()
        {
            return _price;
        }

        public double TellMeTheScreenSize()
        {
            return _screenSize;
        }

        public void TurnOn()
        {
            Console.WriteLine("the computer is turn on...");
        }


        public void TurnOff()
        {
            Console.WriteLine("the computer is turn off...");
        }

        public void AddProcessor()
        {
           
        }

        public override string ToString()
        {
            return ($"Model: {_model}, Price: {_price}, Number Of Processors: {_numberOfProcessors} ,ScreenSize: {_screenSize}\n");
            
        }

    }
}
