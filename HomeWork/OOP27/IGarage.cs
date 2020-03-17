using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP27
{
    interface IGarage
    {
        void AddCar(Car car);

        void FixCar(Car car);

        void RemoveCar(Car car);


    }
}
