using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP27
{
    class Car
    {

        public string Brand { get; protected set; }
        public bool TotalLost { get; protected set; }
        public bool NeedsRepair { get; set; }

        public Car(string brand, bool totalLost, bool needsRepair)
        {
            Brand = brand;
            TotalLost = totalLost;
            NeedsRepair = needsRepair;
        }

    }
}
