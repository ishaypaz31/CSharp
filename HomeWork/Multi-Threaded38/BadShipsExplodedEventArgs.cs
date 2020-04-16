using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Threaded38
{
    public class BadShipsExplodedEventArgs : EventArgs
    {
        public int NumberOfExplodedBadShips { get; set; }
    }
}
