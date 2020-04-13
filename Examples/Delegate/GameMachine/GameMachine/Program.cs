using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conductor
            GameMachine game = new GameMachine();

            HigeScorer higeScorer = new HigeScorer();

            game.NewMaxScore = higeScorer.NewHigeScoreReached;
            game.IncreaseCore(100000);
        }
    }
}
