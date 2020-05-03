using System;
using System.Collections.Generic;
using System.Text;


namespace LinkedList
{
    public class DoubleLindedList<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        public int Count { get; private set; } = 0;

        public void AddFirst(T value)
        {
            Node<T> newNode = new Node<T>(value);

            if (this.Count == 0)
            {
                this.Head = this.Tail = newNode;
            }

            else
            {
                Node<T> oldHead = this.Head;
                this.Head = newNode;
                this.Head.NextNode = oldHead;
                oldHead.PreviousNode = this.Head;
            }

            this.Count++;
        }

        public void AddLast(T element)
        {
            Node<T> newNode = new Node<T>(element);

            if (this.Count == 0)
            {
                this.Head = this.Tail = newNode;
            }

            else
            {
                this.Tail.NextNode = newNode;
                newNode.PreviousNode = this.Tail;
                this.Tail = newNode;
            }

            this.Count++;
        }

        public object RemoveFirst()
        {
            if (this.Count == 0)
            {
                throw new ArgumentOutOfRangeException("Linked list is empty.");
            }

            Node<T> elementToRemove = this.Head;

            if (this.Count == 1)
            {
                this.Head = this.Tail;
            }
            else
            {
                this.Head = this.Head.NextNode;
                this.Head.PreviousNode = null;
            }

            this.Count--;
            return elementToRemove;
        }

        public object RemoveLast()
        {
            Node<T> elementToReturn = this.Tail;

            if (this.Count == 0)
            {
                throw new IndexOutOfRangeException("Linked list is empty.");
            }

            if (this.Count == 1)
            {
                this.Head = this.Tail;
            }

            else
            {
                this.Tail = this.Tail.PreviousNode;
                this.Tail.NextNode = null;
            }

            this.Count--;
            return elementToReturn;
        }

        public void ForEach(Action<T> action)
        {
            Node<T> currentNode = this.Head;

            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.NextNode;
            }
        }

        public object ToArray()
        {
            Node<T> currentNode = this.Head;
            object[] arrayToReturn = new object[this.Count];
            int indexCount = 0;

            while (currentNode != null)
            {
                arrayToReturn[indexCount] = currentNode;
                currentNode = currentNode.NextNode;
                indexCount++;
            }
            return arrayToReturn;
        }

        public bool Contains(T element)
        {
            Node<T> currentNode = this.Head;
            bool contains = false;

            while (currentNode != null)
            {
                if (currentNode.Value.Equals(element))
                {
                    contains = true;
                    break;
                }

                currentNode = currentNode.NextNode;
            }

            return contains;
        }

        public void Remove(object element)
        {
            Node<T> currentNode = this.Head;

            while (currentNode != null)
            {
                if (currentNode.Value.Equals(element))
                {
                    
                    // Node<T> prevNode = currentNode.PreviousNode;
                    Node<T> nextNode = currentNode.NextNode;
                    currentNode.NextNode = null;
                    currentNode.PreviousNode = null;
                    currentNode = null; 

                    if (currentNode.PreviousNode == null)
                    {
                        this.Head = nextNode;
                        this.Head.NextNode = nextNode.PreviousNode;
                    }

                    if (nextNode == null)
                    {
                        this.Tail = currentNode;
                        this.Tail.PreviousNode = currentNode.PreviousNode;
                    }

                    this.Count--;

                    if (this.Count == 1)
                    {
                        this.Head = this.Tail;
                    }

                    if (this.Count == 0)
                    {
                        throw new IndexOutOfRangeException("no more elements.");
                    }
                }

                currentNode = currentNode.NextNode;
            }
        }
    }
}
