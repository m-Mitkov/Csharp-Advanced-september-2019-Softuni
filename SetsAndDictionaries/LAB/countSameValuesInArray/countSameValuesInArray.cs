using System;
using System.Collections.Generic;
using System.Linq;

namespace countSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> count = new Dictionary<double, int>();

            double[] input = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                double currentNumber = input[i];

                if (!count.ContainsKey(currentNumber))
                {
                    count.Add(currentNumber, 0);
                }

                count[currentNumber]++;
            }

            foreach (var kvp in count)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }
        }
    }
}
