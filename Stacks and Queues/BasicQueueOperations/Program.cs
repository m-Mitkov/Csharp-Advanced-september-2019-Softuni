using System;
using System.Linq;
using System.Collections.Generic;

namespace basicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] comandsToDo = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int elementsToEnqueue = comandsToDo[0];
            int elementToDequeue = comandsToDo[1];
            int numberToCheckIfExist = comandsToDo[2];

            int[] inputNumbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            Queue<int> numbers = new Queue<int>(inputNumbers);

            if (elementsToEnqueue <= elementToDequeue)
            {
                Console.WriteLine("0");
                return;
            }

            for (int i = 0; i < elementToDequeue; i++)
            {
                numbers.Dequeue();
            }

            if (numbers.Contains(numberToCheckIfExist))
            {
                Console.WriteLine("true");
                return;
            }
            else
            {
                Console.WriteLine(numbers.Min());
                return;
            }
        }
    }
}
