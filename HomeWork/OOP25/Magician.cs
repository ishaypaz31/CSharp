using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP25
{
   class Magician : INameable, IComparable<Magician>
    {
        public string Name { get; protected set; }
        public string Birthtwon { get; protected set; }
        public string FavoriteSpell { get; protected set; }

        public Magician(string name, string birthtwon, string favoriteSpell)
        {
            Name = name;
            Birthtwon = birthtwon;
            FavoriteSpell = favoriteSpell;
        }

        public string this[string name]
        {
            get
            {
                if (name == "Name")
                    return this.Name;
                if (name == "Birthtwon")
                    return this.Birthtwon;
                if (name == "FavoriteSpell")
                    return this.FavoriteSpell;
                return "Unknown";

            }
            set
            {
                if (name == "Name")
                    this.Name = value;
                if (name == "Birthtwon")
                    this.Birthtwon = value;
                if (name == "FavoriteSpell")
                     this.FavoriteSpell = value;
            }
        }

        public override string ToString()
        {
            return $"Name : {Name} , Birthtwon: {Birthtwon}, FavoriteSpell: {FavoriteSpell}";
        }

        public int CompareTo(Magician other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }
}
