using System;
using System.Collections.Generic;
using System.Linq;

namespace listOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int rangeLength = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int, int, bool> checkIfNumberIsDivisible = (n, d) => n % d == 0;

            for (int i = 1; i <= rangeLength; i++)
            {
                bool isDivisible = true;

                foreach (var number in dividers)
                {
                    if (!checkIfNumberIsDivisible(i, number))
                    {
                        isDivisible = false;
                        break;
                    }
                }

                if (isDivisible)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
