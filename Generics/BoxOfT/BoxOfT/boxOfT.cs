using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        private Stack<T> items;
        public Box()
        {
            this.items = new Stack<T>();
        }
        public int Count 
        {
            get => this.items.Count;  
        }

        public void Add(T element)
        {
            this.items.Push(element);
        }
        public T Remove()
        {
            return this.items.Pop();
        }

    }
}
