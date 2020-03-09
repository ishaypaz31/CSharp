using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP25
{
    class RoundTable<T> : IEnumerable<T> where T : INameable, IComparable<T>
    {
        private List<T> entities = new List<T>();


        public void Add(T Entity)
        {
            entities.Add(Entity);
        }

        public void RemoveAt(int index)
        {
            if (entities.Count == 0)
                return;
            entities.RemoveAt(index % entities.Count);
        }

        public void Clear()
        {
            entities.Clear();
        }

        public void InsertAt(int index,T item)
        {
            entities.Insert(index % entities.Count, item);
        }

        public void Sort()
        {
            entities.Sort();
        }


        public T this[int index]
        {
            get
            {
                if (entities.Count == 0)
                    return default(T);
                return entities[index % entities.Count];
            }
        }

        public T this[string name]
        {
            get
            {
                if (entities.Count == 0)
                    return default(T);
                foreach (T entity in entities)
                {
                    if (entity.Name == name)
                        return entity;
                }
                return default(T);
            }
        }

        public List<T> GetRunded(int length)
        {
            List<T> result = new List<T>();

            int counter = 0;
            int index = 0;

            while (counter++ < length)
            {
                result.Add(entities[index++]);
                if (index >= entities.Count)
                    index = 0;
            }
            return result;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return entities.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return entities.GetEnumerator();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
