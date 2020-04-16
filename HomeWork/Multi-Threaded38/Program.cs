using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Threaded38
{
    class Program
    {
        public static Random random = new Random();

        static void Main(string[] args)
        {

            SpaceQuestGameManager SpaceQuest = new SpaceQuestGameManager(5,5,6,4);
            GameViewer Gamer = new GameViewer();
            SpaceQuest.GoodSpaceShipLocationChanged += Gamer.GoodSpaceShipLocationChangedEventHandler;
            SpaceQuest.GoodSpaceShipHPChanged += Gamer.GoodSpaceShipHPChangedEventHandler;
            SpaceQuest.GoodSpaceShipDestroyed += Gamer.GoodSpaceShipDestryedEventHandler;
            SpaceQuest.BadShipsExploded += Gamer.BadShipsExplodedEventHandler;
            SpaceQuest.LevelUpReached += Gamer.LevelUpReachedEventHandler;
        }
    }
}
