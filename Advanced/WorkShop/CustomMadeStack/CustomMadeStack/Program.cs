using System;
using System.Collections.Generic;

namespace CustomMadeStack
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomStack custamStack = new CustomStack();

            custamStack.Push(3);
            custamStack.Push(5);
            custamStack.Push(7);
            custamStack.Push(9);
            custamStack.Push(11);

            Console.WriteLine(custamStack.Count == 5); // true

            Console.WriteLine(custamStack.Pop()); // 11

            Console.WriteLine(custamStack.Count == 4); // true

            int temp = custamStack.Pop();

            Console.WriteLine(temp == 9); // true
            Console.WriteLine(custamStack.Count == 3); // true

            Stack<int> stack = new Stack<int>();

            Console.WriteLine(custamStack.Contains(7)); // true
            Console.WriteLine(custamStack.Contains(45)); // false

            custamStack.ForEach(x => Console.Write(x + " ")); // 3 5 7
            Console.WriteLine();

            int[] toArray = custamStack.ToArray();

            foreach (var item in toArray)
            {
                Console.Write(item + " ");
            }
        }
    }
}
