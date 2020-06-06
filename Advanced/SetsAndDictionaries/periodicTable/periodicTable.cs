using System;
using System.Collections.Generic;

namespace periodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> periodicTable = new SortedSet<string>();

            int numberOfInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInputs; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ");

                for (int j = 0; j < input.Length; j++)
                {
                    periodicTable.Add(input[j]);
                }
            }

            Console.WriteLine($"{string.Join(" ", periodicTable)}");
        }
    }
}
