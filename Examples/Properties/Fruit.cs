using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropExample
{
    class Fruit
    {
        private int _calories;


        //Getter
        public int GetCalories()
        {
            return _calories;
        }

        //Setter
        internal void SetCalories(int calories)
        {
            if (calories > 0)
            {
                _calories = calories;
            }
        }

        // Property
        // 1 - access my data private

        public int Calories
        {
            get
            {
                return _calories;
            }
            internal set // (int Value)
            {
                if (value > 0)
                {
                    _calories = value;
                }
            }

        }

        //2 create and access data
        public string Name
        {
            get; //this create backing field
            internal set;
        }


        //3 - Method like
        public string Description
        {
            get
            {
                return $"{Name} + {Calories}";
            }

        }

        //private string _name;
        ////Getter
        //public string GetName()
        //{
        //    return _name;
        //}

        ////Setter
        //internal void SetName(string name)
        //{
        //    _name = name;

        public Fruit(string name, int calories)
        {
            _calories = calories;
             this.Name = name;
            //_name = name;
        }
    }
}
