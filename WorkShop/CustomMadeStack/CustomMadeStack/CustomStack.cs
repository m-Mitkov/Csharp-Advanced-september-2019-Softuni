using System;
using System.Collections.Generic;
using System.Text;

namespace CustomMadeStack
{
    public class CustomStack
    {
        private const int initialCapacity = 2;
        private int[] items;

        public CustomStack()
        {
            this.items = new int[initialCapacity];
        }

        public int Count { get; set; }

        public void Push(int element)
        {
            if (this.Count >= this.items.Length)
            {
                Resize();
            }

            this.items[this.Count] = element;
            this.Count++;
        }

        public int Pop()
        {
            CheckStackIsNotEmpty();
            int elementToReturn = this.items[this.Count - 1];
            this.Count--;
            Shrink();

            return elementToReturn;
        }

        public int Peek()
        {
            CheckStackIsNotEmpty();
            int elementToReturn = this.items[this.Count - 1];

            return elementToReturn;
        }

        public void Clear()
        {
            this.items = new int[initialCapacity];
            this.Count = 0;
        }

        public bool Contains(int numberToLookFor)
        {
            bool isContained = false;
            int currentCount = 0;

            while (currentCount != this.Count)
            {
                int currentNumber = this.items[currentCount];

                if (currentNumber.Equals(numberToLookFor))
                {
                    isContained = true;
                    return isContained;
                }

                currentCount++;
            }

            return isContained;
        }

        public void ForEach(Action<int> action)
        {
            int currentCount = 0;

            while (currentCount != this.Count)
            {
                action(this.items[currentCount]);
                currentCount++;
            }
        }

        public int[] ToArray()
        {
            int[] arrayToReturn = new int[this.Count];
            int currentCount = 0;

            while (currentCount != this.Count)
            {
                arrayToReturn[currentCount] = items[currentCount];
                currentCount++;
            }

            return arrayToReturn;
        }

        private void Shrink()
        {
            if (this.Count <= this.items.Length / 4)
            {
                int[] newArr = new int[this.items.Length / 4];

                for (int i = 0; i < this.items.Length; i++)
                {
                    newArr[i] = this.items[i];
                }

                this.items = newArr;
            }
        }
        private void CheckStackIsNotEmpty()
        {
            if (this.Count == 0)
            {
                throw new IndexOutOfRangeException("Stack is empty.");
            }
        }
        private void Resize()
        {
            int[] newArr = new int[this.items.Length * 2];

            for (int i = 0; i < this.items.Length; i++)
            {
                newArr[i] = this.items[i];
            }

            this.items = newArr;
        }
    }
}
