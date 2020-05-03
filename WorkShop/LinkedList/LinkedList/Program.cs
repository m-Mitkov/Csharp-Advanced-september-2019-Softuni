using System;
using System.Collections.Generic;
using System.Transactions;
using System.Linq;

namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new DoubleLindedList<int>();

            linkedList.AddFirst(5);
            linkedList.AddFirst(10);
            linkedList.AddFirst(15);

            Console.WriteLine(linkedList.Count == 3); // true

            linkedList.AddLast(10);
            linkedList.AddLast(5);

            Console.WriteLine(linkedList.Count == 5); // true

            //linedList == 15 10 5 10 5

            Console.WriteLine(linkedList.Head.Value == 15); // 15 true
            Console.WriteLine(linkedList.Tail.Value == 5); // 5 true

            linkedList.RemoveFirst(); // 15
            linkedList.RemoveFirst(); //10

            //LinkedList == 5 10 5

            Console.WriteLine(linkedList.Count == 4); // false
            Console.WriteLine(linkedList.Count == 3); // true

            Console.WriteLine(linkedList.Head.Value == 5); // 5 true
            Console.WriteLine(linkedList.Tail.Value == 5); // 5 true

            Console.WriteLine(linkedList.Count == 0); // false

            linkedList.RemoveLast();

            Console.WriteLine(linkedList.Count == 2); // true
            Console.WriteLine(linkedList.Head.Value == 5); // 5 true
            Console.WriteLine(linkedList.Tail.Value == 10); // 10 true

            linkedList.ForEach(x => Console.Write(x + " ")); // 5 10
            Console.WriteLine();

            Console.WriteLine(linkedList.Count == 2);

            linkedList.AddFirst(9);
            linkedList.AddFirst(7);

            // linked list 7 9 5 10

            linkedList.Remove(10);

            Console.WriteLine(linkedList.Head.Value); // 7
            Console.WriteLine(linkedList.Tail.Value); // 5
            Console.WriteLine(linkedList.Count == 3); // true

            linkedList.ForEach(x => Console.Write(x));

            // linked list 7 9 5

            // Console.WriteLine(linkedList.Contains(7));
        }
    }
}
