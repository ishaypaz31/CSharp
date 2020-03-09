using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP20
{
    class Person : IComparable<Person>
    {
        public int ID { get; private set; }

        public int Age { get; private set; } 

        public float Height { get; private set; }

        public string Name { get; private set; }

        private static readonly IComparer<Person> _compareById;
        private static readonly IComparer<Person> _compareByAge;
        private static readonly IComparer<Person> _compareByName;
        private static readonly IComparer<Person> _compareByHeight;

        public static IComparer<Person> IDComparer
        {
            get
            {
                return _compareById;
            }
        }

        public static IComparer<Person> AgeComparer
        {
            get
            {
                return _compareByAge;
            }
        }

        public static IComparer<Person> HeightComparer
        {
            get
            {
                return _compareByHeight;
            }
        }


        public static IComparer<Person> NameComparer
        {
            get
            {
                return _compareByName;
            }
        }

        private static IComparer<Person> DefaultComparer;
        public static void ModifyDefaultComparer(IComparer<Person> newComparer)
        {
            DefaultComparer = newComparer;
        }
        private static IComparer<Person> GetDefaultComparer()
        {
            return DefaultComparer;
        }


        static Person()
        {

            DefaultComparer = _compareById; // Etgar metoraf!!!
        }

        /// <summary>
        /// Default sort is by ID
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Person other)
        {
            //---- without Etgar
            // return this.Id - other.Id;

            // with Etgar metoraf!
            return DefaultComparer.Compare(this, other);
        }

        public Person(int iD, int age, float height, string name)
        {
            ID = iD;
            Age = age;
            Height = height;
            Name = name;
        }

        
        public override string ToString()
        {
            return $"ID: {ID,8} , Age: {Age,14} , Height: {Height,15} , Name: {Name,12}";
        }


    }
}
