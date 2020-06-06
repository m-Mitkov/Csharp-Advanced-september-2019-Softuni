using System;
using System.Linq;

namespace findEvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rangeNumbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int start = rangeNumbers[0];
            int end = rangeNumbers[1];

            Func<int, bool> predicate = null;
            int[] numbers = new int[end - start + 1];
            int count = 0;

            string evenOrOdd = Console.ReadLine();

            for (int i = start; i <= end; i++)
            {
                if (evenOrOdd == "even")
                {
                    predicate = i => i % 2 == 0;
                }

                else if (evenOrOdd == "odd")
                {
                    predicate = i => i % 2 != 0;
                }

                numbers[count] = i;
                count++;
            }

            Console.WriteLine(string.Join(" ", numbers.Where(predicate)));
        }
    }
}
