using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow
{
    class MyMobileStack 
    {
        private List<Mobile> _mobiles = new List<Mobile>();

        public MyMobileStack()
        {

        }

        public Mobile Pop()// deleting an element form the top.
        {
            Mobile ithem = _mobiles[0];
            _mobiles.RemoveAt(0);
            return ithem;
        }

        public void Push(Mobile mobile) //adding an element at the top list.
        {
            _mobiles.Insert(0, mobile);
        }

        public int Size// get list size
        {
            get;
        }

        public void Clear()// clear the list
        {
            _mobiles.Clear();
        }

        public void Init(List<Mobile> newList)// change the alternate list
        {
            _mobiles = newList;
        }

        public void Sort()// Sorting
        {
            _mobiles.Sort();
        }

        public Mobile Peep() // checking the top element form the list.
        {
            Mobile ithem = _mobiles[0];
            return ithem;
        }
    }
}
