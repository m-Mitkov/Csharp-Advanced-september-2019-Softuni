using System;
using System.Linq;
using System.Collections.Generic;

namespace maxAndMinElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfComandToFollow = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < numbersOfComandToFollow; i++)
            {
                string[] comandToDo = Console.ReadLine().Split(" ");

                if (comandToDo[0] == "1")
                {
                    int numberToAdd = int.Parse(comandToDo[1]);

                    stack.Push(numberToAdd);
                }

                if (stack.Count >= 1)
                {
                    switch (comandToDo[0])
                    {
                        case "2":
                            stack.Pop();
                            break;

                        case "3":
                            Console.WriteLine(stack.Max());
                            break;

                        case "4":
                            Console.WriteLine(stack.Min());
                            break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", stack));
        }
    }
}
