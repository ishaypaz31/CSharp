using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Threaded39_40
{
    class Elevator
    {
        private ElevatorState _elevatorState;
        private int _currentFloor;
        private int _gotoFloor;

        public event EventHandler ElevatorOrderedSuccessfullyEvents;
        public event EventHandler FloorReachedSuccessfullyEvent;
        public event EventHandler CloseDoorsSuccessfullyEvent;

        public Elevator(ElevatorState elevatorState, int currentFloor)
        {
            _elevatorState = elevatorState;
            _currentFloor = currentFloor;
        }

        public bool GoToFloor(int newFloor)
        {
            //if the elevator is in a resting state and is already on the desired floor, then the elevator mode should be changed to open doors
            if (_elevatorState == ElevatorState.Resting && this._currentFloor == newFloor)
            {
                _elevatorState = ElevatorState.Open_Doors;
                _gotoFloor = newFloor;
                if (ElevatorOrderedSuccessfullyEvents != null)
                {
                    ElevatorOrderedSuccessfullyEvents.Invoke(this, EventArgs.Empty);
                }
                return true;
            }
            //if the elevator is in a resting position and is not on the requested floor, 
            //then the status of the elevator must be updated, if the elevator is below the requested floor then change to Going Up
            if (_elevatorState == ElevatorState.Resting && this._currentFloor < newFloor)
            {
                _elevatorState = ElevatorState.Going_Up;
                _gotoFloor = newFloor;
                if (ElevatorOrderedSuccessfullyEvents != null)
                {
                    ElevatorOrderedSuccessfullyEvents.Invoke(this, EventArgs.Empty);
                }
                return true;
            }
            //if the elevator above the requested floor then change to Going Down
            if (_elevatorState == ElevatorState.Resting && this._currentFloor > newFloor)
            {
                _elevatorState = ElevatorState.Going_Down;
                _gotoFloor = newFloor;
                if (ElevatorOrderedSuccessfullyEvents != null)
                {
                    ElevatorOrderedSuccessfullyEvents.Invoke(this, EventArgs.Empty);
                }
                return true;
            }
            //if the elevator in another situation, the request must be ignored and a false boolean returned
            return false;
        }

        public bool FloorReached()
        {
            if (_elevatorState == ElevatorState.Going_Up)
            {
                _elevatorState = ElevatorState.Open_Doors;
                _currentFloor = _gotoFloor;
                if (FloorReachedSuccessfullyEvent != null)
                {
                    FloorReachedSuccessfullyEvent.Invoke(this, EventArgs.Empty);
                }
                return true;
            }

            if (_elevatorState == ElevatorState.Going_Down)
            {
                _elevatorState = ElevatorState.Open_Doors;
                _currentFloor = _gotoFloor;
                if (FloorReachedSuccessfullyEvent != null)
                {
                    FloorReachedSuccessfullyEvent.Invoke(this, EventArgs.Empty);
                }
                return true;
            }

            return false;
        }

        public bool CloseDoors()
        {
            if (_elevatorState == ElevatorState.Open_Doors)
            {
                _elevatorState = ElevatorState.Resting;
                _gotoFloor = 0;
                if (CloseDoorsSuccessfullyEvent != null)
                {
                    CloseDoorsSuccessfullyEvent.Invoke(this, EventArgs.Empty);
                }
                return true;
            }
            return false;
        }
    }
}
