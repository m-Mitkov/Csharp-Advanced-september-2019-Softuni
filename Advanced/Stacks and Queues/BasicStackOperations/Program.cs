using System;
using System.Linq;
using System.Collections.Generic;

namespace basicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int countNumbersToPush = input[0];

            Stack<int> numbers = new Stack<int>();

            int[] numberToPush = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < countNumbersToPush; i++)
            {
                numbers.Push(numberToPush[i]);
            }

            int countNumbersToPop = input[1];

            if (countNumbersToPop <= numbers.Count)
            {
                for (int i = 0; i < countNumbersToPop; i++)
                {
                    numbers.Pop();
                }
            }

            if (numbers.Count != 0)
            {
                int elementToCkeck = input[2];

                if (numbers.Contains(elementToCkeck))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(numbers.Min());
                }
            }
            else if (numbers.Count == 0)
            {
                Console.WriteLine("0");
            }
        }
    }
}
