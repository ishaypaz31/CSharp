using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP26
{
    class MyProtectedUniqueList : IEnumerable<string>
    {
        private List<string> words;
        private string password;

        public MyProtectedUniqueList(string password)
        {
            words = new List<string>();
            this.password = password;
        }

        public void Add(string item)
        {
            if (item == null || item == string.Empty)
            {
                throw new ArgumentNullException("string is empty.");
            }

            if (words.Contains(item))
            {
                throw new InvalidOperationException($"{item} already exists");
            }

            words.Add(item);
        }
        public void Remove(string item)
        {
            if (item == null || item == string.Empty)
            {
                throw new ArgumentNullException("string is empty");
            }
            if (!words.Contains(item))
            {
                throw new InvalidOperationException($"{item} does not exists");
            }
            words.Remove(item);
        }

        public void RemoveAt(int index)
        {
            if (index < 0)
            {
                throw new IndexOutOfRangeException("index cannot be negative");
            }
            if (index >= words.Count())
            {
                throw new IndexOutOfRangeException("index to big");
            }
            words.RemoveAt(index);
        }

        public void Clear(string pass)
        {
            if (this.password != pass)
            {
                throw new AccessViolationException($"{password} is not the correct password!");
            }
            else
            {
                words.Clear();
            }
        }

        public void Sort(string pass)
        {
            if (this.password != pass)
            {
                throw new AccessViolationException($"{password} is not the correct password!");
            }
            else
            {
                words.Sort();
            }        
        }

        public override string ToString()
        {
            string result = $"list value {words.Count}";

            foreach (string w in words)
            {
                result += $"\n{w}";
            }
            return result;
        }

        public IEnumerator<string> GetEnumerator()
        {
            return words.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return words.GetEnumerator();
        }
    }
}
