using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Threaded38
{
    public class GameViewer
    {
        public void GoodSpaceShipHPChangedEventHandler(object sender, PointsEventArgs e)
        {
            Console.WriteLine($"The ship has been hit by: {sender} The ship points are now:{e.HitPoins}");

        }
        public void GoodSpaceShipLocationChangedEventHandler(object sender, LocationEventArgs e)
        {
            Console.WriteLine($"The ship has been moved by:{sender} The ship is now at{e.X} and {e.Y}");
        }
        public void GoodSpaceShipDestryedEventHandler(object sender, LocationEventArgs e)
        {
            Console.WriteLine("Good spaceship destroyed - Game Over!");

            Console.WriteLine($"The ship has been destroyed by: {sender} The ship position reset to {e.X} and {e.Y}");
        }
        public void BadShipsExplodedEventHandler(object sender, BadShipsExplodedEventArgs e)
        {
            Console.WriteLine($"Enemy Destroyed by {sender} Remaining bad ships:{e.NumberOfExplodedBadShips}");

        }
        public void LevelUpReachedEventHandler(object sender, LevelEventArgs e)
        {
            Console.WriteLine($"WELL DONE LEVEL UP! Level up by {sender} You are now in Level {e.CurrentLevel}");

        }

    }
}
