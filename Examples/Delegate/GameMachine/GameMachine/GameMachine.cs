using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMachine
{
    class GameMachine
    {
        public Action<int> CoinInsertedFunction { get; set; }

        public Func<int,string> NewMaxScore { get; set; }

        private int Score = 0;
        private int CurrentMaxSocre = 100;

        public void CoinSensorTriggered(int Money)
        {
            if(CoinInsertedFunction != null)
            {
                CoinInsertedFunction.Invoke(Money);
            }
        }

        public void IncreaseCore(int morePoints)
        {
            Score += morePoints;
            if (Score > CurrentMaxSocre)
            {
                if (NewMaxScore != null)
                {
                    Console.WriteLine(NewMaxScore(Score));
                }

            }
        }

    }
}
