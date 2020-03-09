using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP25
{
     class Knight : INameable, IComparable<Knight>
    {
        public string Name { get; protected set; }
        public string Birthtwon { get; protected set; }
        public string Title { get; protected set; }

        public Knight()
        {
                
        }

        public Knight(string name, string birthtwon, string title)
        {
            Name = name;
            Birthtwon = birthtwon;
            Title = title;
        }

        public string this[string name]
        {
            get
            {
                if (name == "Name")
                    return this.Name;
                if (name == "Birthtwon")
                    return this.Birthtwon;
                if (name == "Title")
                    return this.Title;
                return "Unknown";
            }
            set
            {
                if (name == "Name")
                    this.Name = value;
                if (name == "Birthtwon")
                    this.Birthtwon = value;
                if (name == "Title")
                    this.Title = value;
                 
            }
        }



        public override string ToString()
        {
            return $"Name : {Name} , Birthtwon: {Birthtwon}, Title: {Title}";
        }

        public int CompareTo(Knight other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }
}
