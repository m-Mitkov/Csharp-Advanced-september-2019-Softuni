using System;
using System.Collections.Generic;
using System.Linq;

namespace Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputData = Console.ReadLine()
                 .Split(", ")
                 .Select(int.Parse)
                 .ToArray();

            Lake lake = new Lake(inputData);
            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
