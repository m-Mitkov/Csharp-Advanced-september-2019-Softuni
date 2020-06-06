using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private const int internalIndexInitialValue = 0;

        private List<T> collection;
        private int internalIndex;
        public ListyIterator()
        {
            this.collection = new List<T>();
            this.internalIndex = internalIndexInitialValue;
        }

        public ListyIterator(IEnumerable<T> initialData)
        {
            this.collection = new List<T>(initialData);
        }

        public bool Move()
        {
            if (HasNext())
            {
                internalIndex++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            if (internalIndex + 1 < this.collection.Count)
            {
                return true;
            }

            return false;
        }

        public string Print()
        {
            if (collection.Count == 0 )
            {
                throw new IndexOutOfRangeException("Invalid Operation!");
            }

            else
            {
                return collection[internalIndex].ToString();
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in collection)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
