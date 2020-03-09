using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerMethods
{
    class Car
    {
        public string Name { get; protected set; }
        public int Price { get; protected set; }
        public string Color { get; protected set; }
        public string Treatment{ get; protected set; }

        public Car(string name, int price, string color, string treatment)
        {
            Name = name;
            Price = price;
            Color = color;
            Treatment = treatment;
        }



        public string getData(string fieldName)
        {
                if (fieldName == "Name")
                    return this.Name;
                if (fieldName == "Price")
                    return this.Price.ToString();
                if (fieldName == "Color")
                    return this.Color;
                if (fieldName == "Treatment")
                    return this.Treatment;
                return "Unknown";
        }
        public void setData(string fieldName,string value)
        {
            if (fieldName == "Name")
                this.Name = value;
            if (fieldName == "Price")
                this.Price = Convert.ToInt32(value);
            if (fieldName == "Color")
                this.Color = value;
            if (fieldName == "Treatment")
                this.Treatment = value;
        }
        public string this[string fieldName]
        {
            get
            {
                if (fieldName == "Name")
                    return this.Name;
                if (fieldName == "Price")
                    return this.Price.ToString();
                if (fieldName == "Color")
                    return this.Color;
                if (fieldName == "Treatment")
                    return this.Treatment;
                return "Unknown";
            }
            set
            {
                if (fieldName == "Name")
                     this.Name = value;
                if (fieldName == "Price")
                    this.Price = Convert.ToInt32(value);
                if (fieldName == "Color")
                    this.Color = value;
                if (fieldName == "Treatment")
                    this.Treatment = value;
            }
        }

        public override string ToString()
        {
            return $"Car Name: {Name} , Price: {Price}, Color: {Color}, Treatment: {Treatment}";
        }
    }
}
