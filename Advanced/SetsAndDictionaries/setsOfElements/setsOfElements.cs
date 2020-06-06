using System;
using System.Collections.Generic;
using System.Linq;

namespace setsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberOfElements = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int firstSetLenght = numberOfElements[0];
            int secondSetLenght = numberOfElements[1];

            int totalElements = firstSetLenght + secondSetLenght;

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 1; i <= totalElements; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (i <= firstSetLenght)
                {
                    firstSet.Add(currentNumber);
                    continue;
                }

                secondSet.Add(currentNumber);
            }

            foreach (var number in firstSet)
            {
                if (secondSet.Contains(number))
                {
                    Console.Write(number + " ");
                }
            }
        }
    }
}
