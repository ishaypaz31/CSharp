using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multi_Threaded39_40
{
    class ElevatorMessages
    {
        public void ElevatorOrderedSuccessfullyEventHandler(object sorce, EventArgs e)
        {
            Console.WriteLine("Elevator ordered successfully");
            Thread.Sleep(3000);
            Console.WriteLine();
        }
        public void FloorReachedSuccessfullyEventHandler(object sorce, EventArgs e)
        {
            Console.WriteLine("the Elevator have reached the Floor successfully");
            Thread.Sleep(2000);
            Console.WriteLine();
            Console.WriteLine("the Elevator is opening the Doors");
            Thread.Sleep(3000);
            Console.WriteLine();
        }
        public void CloseDoorsSuccessfullyEventHandler(object sorce, EventArgs e)
        {
            Console.WriteLine("the Elevator is closing the Doors");
            Thread.Sleep(3000);
        }
    }
}
