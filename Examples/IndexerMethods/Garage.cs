using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerMethods
{
    class Garage<T> : IEnumerable<T>
    {
        private List<T> carHeavyTreatmen = new List<T>();

        private List<T> carLightTreatmen = new List<T>();

        public T this[int index]
        {
            get
            {
                if (carHeavyTreatmen.Count > index)
                    return carHeavyTreatmen[index];
                return carLightTreatmen[index - carHeavyTreatmen.Count];
            }
        }

        public void AddHeavy(T c)
        {
            carHeavyTreatmen.Add(c);
        }
        public void AddLight(T c)
        {
            carLightTreatmen.Add(c);
        }

        public IEnumerator<T> GetEnumerator()
        {
            List<T> allCars = new List<T>(carHeavyTreatmen);
            allCars.AddRange(carLightTreatmen);

            return allCars.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            List<T> allCars = new List<T>(carHeavyTreatmen);
            allCars.AddRange(carLightTreatmen);

            return allCars.GetEnumerator();
        }
    }
}
