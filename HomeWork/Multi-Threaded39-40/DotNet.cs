using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Threaded39_40
{
    static class DotNet
    {
        public static bool DayAppears(DaysOfTheWeek listOfDays, DaysOfTheWeek singleDay)
        {
            return listOfDays.HasFlag(singleDay);
        }

        public static DaysOfTheWeek AddDay(DaysOfTheWeek listOfDays, DaysOfTheWeek singleDay)
        {
            return listOfDays | singleDay;
        }

        public static DaysOfTheWeek RemoveDay(DaysOfTheWeek listOfDays, DaysOfTheWeek singleDay)
        {
            return listOfDays & ~ singleDay;
        }

        public static void PrintDaysWhichDoesNotAppear(DaysOfTheWeek listOfDays)
        {

            foreach (DaysOfTheWeek day in Enum.GetValues(typeof(DaysOfTheWeek)))
            {
                if (!listOfDays.HasFlag(day))
                {
                    Console.WriteLine(day);
                }
            }
        }
    }
}
