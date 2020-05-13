using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> myStack = new MyStack<int>();

            while (true)
            {
                string inputComand = Console.ReadLine();

                if (inputComand == "END")
                {
                    break;
                }

                if (inputComand.StartsWith("Push"))
                {
                    var itemsToPush = inputComand
                        .Substring(inputComand.IndexOf(" ") + 1)
                        .Split(", ");

                    foreach (var item in itemsToPush)
                    {
                        myStack.Push(int.Parse(item));
                    }
                }

                else if (inputComand.StartsWith("Pop"))
                {
                    if (!myStack.Any())
                    {
                        Console.WriteLine("No elements");
                        continue;
                    }

                    myStack.Pop();
                }
            }

            for (int i = 0; i < 2; i++)
            {
                foreach (var item in myStack)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
