using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Threaded39_40
{
    [Flags]
    enum ElevatorState
    {
        Going_Up = 0,
        Going_Down = 1,
        Open_Doors = 2,
        Resting = 3,
    }
}
