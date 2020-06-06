using System;
using System.Collections.Generic;
using System.Linq;

namespace knightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> appendSIR = s => Console.WriteLine($"Sir {s}");

            Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .ToList()
                 .ForEach(appendSIR);

        }
    }
}
