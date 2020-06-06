using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collection
{
   public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> collection;
        private int currentIndex;

        public ListyIterator(params T[] items)
        {
            this.collection = items.ToList();
        }

        public bool HasNext()
        {
            if (currentIndex + 1 < collection.Count)
            {
                return true;
            }

            return false;
        }
        public bool Move()
        {
            if (HasNext())
            {
                currentIndex++;
                return true;
            }

            return false;
        }

        public string Print()
        {
            if (this.collection.Count != 0)
            {
                return collection[currentIndex].ToString();
            }

            return null;
        }

        public string PrintAll()
        {
            StringBuilder returnCollection = new StringBuilder();

            foreach (var element in collection)
            {
                returnCollection.Append(element + " ");
            }

            return returnCollection.ToString().TrimEnd();
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var element in collection)
            {
                yield return element;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
