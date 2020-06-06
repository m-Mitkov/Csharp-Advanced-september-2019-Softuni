using System;
using System.Collections.Generic;
using System.Linq;

namespace customMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> findMinNumber = n => n.Min();

            var inputNumbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(findMinNumber(inputNumbers));
        }
    }
}
