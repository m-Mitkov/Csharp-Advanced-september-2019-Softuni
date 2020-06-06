using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Stack
{
    class MyStack<T> : IEnumerable<T>
    {
        private Stack<T> stack;
        private int count = 0;

        public MyStack()
        {
            this.stack = new Stack<T>();
        }

        public void Push(T element)
        {
            this.stack.Push(element);
            this.count++;
        }

        public T Pop()
        {
            T elementToReturn = this.stack.Pop();
            this.count--;
            return elementToReturn;
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in stack)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
