using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP21
{
    public class Car
    {
        public string Model { get; set; }

        public string Brand { get; set; }

        public int Year { get; set; }

        public string Color { get;  set; }


        private int codan = 0;

        protected int numberOfSeats = 10;

        public Car()
        {

        }

        public Car(string model, string brand, int year, string color, int codan, int numberOfSeats)
        {
            Model = model;
            Brand = brand;
            Year = year;
            Color = color;
            this.codan = codan;
            this.numberOfSeats = numberOfSeats;
        }

        public int GetCodan(int Coden)
        {
            return this.codan;
        }

        public int GetNumberOfSeats()
        {
            return this.numberOfSeats;
        }

        protected void cahngeNumberOfSeats(int newNumberOfSeats)
        {
            if(newNumberOfSeats > 0)
            {
                this.numberOfSeats = newNumberOfSeats;
            }
        }

        public override string ToString()
        {
            return $"Model: {Model} , Brand: {Brand} , Year: {Year} , Color: {Color}";
        }
    }
}
