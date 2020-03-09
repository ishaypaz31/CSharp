using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerMethods
{
    class GarageBike : IEnumerable<Bike>
    {
        private List<Bike> carHeavyTreatmen = new List<Bike>();

        private List<Bike> carLightTreatmen = new List<Bike>();

        public Bike this[int index]
        {
            get
            {
                if (carHeavyTreatmen.Count > index)
                    return carHeavyTreatmen[index];
                return carLightTreatmen[index - carHeavyTreatmen.Count];
            }
        }

        public void AddHeavy(Bike c)
        {
            carHeavyTreatmen.Add(c);
        }

        public void AddLight(Bike c)
        {
            carLightTreatmen.Add(c);
        }

        public IEnumerator<Bike> GetEnumerator()
        {
            List<Bike> allCars = new List<Bike>(carHeavyTreatmen);
            allCars.AddRange(carLightTreatmen);

            return allCars.GetEnumerator();
        }



        IEnumerator IEnumerable.GetEnumerator()
        {
            List<Bike> allCars = new List<Bike>(carHeavyTreatmen);
            allCars.AddRange(carLightTreatmen);

            return allCars.GetEnumerator();
        }
    }
}
