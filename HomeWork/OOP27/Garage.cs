using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP27
{
    class Garage : IGarage, IEnumerable<Car>
    {
        private List<Car> cars = new List<Car>();
        private List<string> carTypes = new List<string>() { "Mazda","Ford"};



        public Garage(List<string> carTypes)
        {
           
            this.carTypes = carTypes;
        }

        public Garage()
        {
        }

        public Garage(List<Car> cars)
        {
            this.cars = cars;
        }

        public void AddCar(Car car)
        {

            Console.WriteLine("");

            if (car == null)
            {
                throw new CarNullException(car);
            }

            if (!carTypes.Contains(car.Brand))
            {
                throw new WrongGarageException($"{car.Brand} is not a part of our cars");
            }


            if (car.NeedsRepair == false)
            {
                throw new RepairMismatchException($"Unable To Fix : {car.Brand} doesn't need repair");
            }

            if (car.TotalLost == true)
            {
                throw new WeDoNotFixTotalLostException($"Unable to fix {car.Brand} total loss");
            }

            cars.Add(car);
            Console.WriteLine($"{car.Brand} added to list");
        }

        public void RemoveCar(Car car)
        {
            Console.WriteLine($"Removing/Fixing {car.Brand} form the list/garage");
            Console.WriteLine("");
            if (car == null)
            {
                throw new CarNullException(car);
            }
            if (!carTypes.Contains(car.Brand))
            {
                throw new WrongGarageException($"{car.Brand} is not a part of our cars");
            }
            if (car.NeedsRepair == true)
            {
                throw new RepairMismatchException($"Unable To release : {car.Brand}car still need repair");
            }
            if (car.TotalLost == false)
            {
                throw new WeDoNotFixTotalLostException($"Unable to fix {car.Brand} total loss");
            }
            cars.Remove(car);
        }

        public void FixCar(Car car)
        {
            if (car == null)
            {
                throw new CarNullException(car);
            }
            if (!carTypes.Contains(car.Brand))
            {
                throw new WrongGarageException($"{car.Brand} is not a part of our cars");
            }
            if (car.NeedsRepair == true)
            {
                throw new RepairMismatchException($"Unable To Fix : {car.Brand}car still need repair");
            }
            if (car.TotalLost == false)
            {
                throw new WeDoNotFixTotalLostException($"Unable to fix {car.Brand} total loss");
            }
            
        }



        public IEnumerator<Car> GetEnumerator()
        {
            List<Car> allCars = new List<Car>();
            allCars.AddRange(cars);
            return allCars.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

    }
}
