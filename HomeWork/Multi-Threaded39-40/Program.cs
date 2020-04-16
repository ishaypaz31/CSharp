using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Threaded39_40
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator = new Elevator(ElevatorState.Resting, 0);
            ElevatorMessages EM = new ElevatorMessages();
            elevator.ElevatorOrderedSuccessfullyEvents += EM.ElevatorOrderedSuccessfullyEventHandler;
            elevator.FloorReachedSuccessfullyEvent += EM.FloorReachedSuccessfullyEventHandler;
            elevator.CloseDoorsSuccessfullyEvent += EM.CloseDoorsSuccessfullyEventHandler;

            elevator.GoToFloor(2);
            elevator.FloorReached();
            elevator.CloseDoors();

            DaysOfTheWeek Sunday = DaysOfTheWeek.Sunday;
            DaysOfTheWeek Monday = DaysOfTheWeek.Monday;
            DaysOfTheWeek Thursdayc = DaysOfTheWeek.Thursday;
            DaysOfTheWeek Wednesday = DaysOfTheWeek.Wednesday;

            Console.WriteLine(DotNet.DayAppears(Sunday, Monday));
            Console.WriteLine("-------------------------------");
            Console.WriteLine(DotNet.RemoveDay(Sunday, Monday));

            Console.WriteLine(DotNet.AddDay(Thursdayc, Wednesday));
        }
    }
}
