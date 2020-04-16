using System;
using System.Linq;
using System.Collections.Generic;

namespace predicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxAllowedLength = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine()
                .Split(" ");

            Func<string, int, bool> checkIfLengthIsValid = (n, l) => n.Length <= l;

            foreach (var name in names)
            {
                if (checkIfLengthIsValid(name, maxAllowedLength))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
