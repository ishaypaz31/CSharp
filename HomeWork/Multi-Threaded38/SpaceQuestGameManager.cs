using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Threaded38
{
    public class SpaceQuestGameManager
    {
        private int _goodSpaceShipHitPoints = 0;
        private int _shipXLocation = 0;
        private int _shipYLocation = 0;
        private int _numberOfBadShips = 0;
        private int _currentLevel = 1;


        public event EventHandler<PointsEventArgs> GoodSpaceShipHPChanged;
        public event EventHandler<LocationEventArgs> GoodSpaceShipLocationChanged;
        public event EventHandler<LocationEventArgs> GoodSpaceShipDestroyed;
        public event EventHandler<BadShipsExplodedEventArgs> BadShipsExploded;
        public event EventHandler<LevelEventArgs> LevelUpReached;

        public SpaceQuestGameManager(int goodSpaceShipHitPoints, int shipXLocation, int shipYLocation, int numberOfBadShips)
        {
            _goodSpaceShipHitPoints = goodSpaceShipHitPoints;
            _shipXLocation = shipXLocation;
            _shipYLocation = shipYLocation;
            _numberOfBadShips = numberOfBadShips;
        }
         
        public void  MoveSpaceShip(int newX,int newY)
        {
            _shipXLocation = newX;
            _shipYLocation = newY;
            OnGoodSpaceShipLocationChanged();
        }

        public void GoodSpaceShipGotDamaged(int damage)
        {
            _goodSpaceShipHitPoints -= damage;
            OnGoodSpaceShipHPChanged();

        }

        public void GoodSpaceShipGotExtraHP(int extra)
        {
            _goodSpaceShipHitPoints += extra;
            OnGoodSpaceShipHPChanged();
        }

        public void EnemyShipsDestroyed(int numberOfBadShipsDestroyed) 
        {
            OnBadShipsExploded();
        }

        private void OnGoodSpaceShipHPChanged()
        {
            if (GoodSpaceShipHPChanged != null)
            {
                GoodSpaceShipHPChanged.Invoke(this, new PointsEventArgs { HitPoins = _goodSpaceShipHitPoints});
            }
        }

        private void OnGoodSpaceShipLocationChanged()
        {
            if (GoodSpaceShipLocationChanged != null)
            {
                GoodSpaceShipLocationChanged.Invoke(this, new LocationEventArgs { X = this._shipXLocation, Y = _shipYLocation });
            }
        }
        private void OnGoodSpaceShipDestroyed()
        {
            if (GoodSpaceShipDestroyed != null)
            {
                GoodSpaceShipDestroyed.Invoke(this, new LocationEventArgs { });
            }
        }
        private void OnBadShipsExploded()
        {
            if (BadShipsExploded != null)
            {
                BadShipsExploded.Invoke(this, new BadShipsExplodedEventArgs { });
            }
        }

        private void OnLevelUpReached()
        {
            if (LevelUpReached != null)
            {
                LevelUpReached.Invoke(this, new LevelEventArgs { });
            }
        }
    }
}
