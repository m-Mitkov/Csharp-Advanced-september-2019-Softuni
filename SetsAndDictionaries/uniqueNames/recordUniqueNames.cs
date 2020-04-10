using System;
using System.Collections.Generic;

namespace recordUniqueNames
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> uniqueNames = new HashSet<string>();

            int namesToFollow = int.Parse(Console.ReadLine());

            for (int i = 0; i < namesToFollow; i++)
            {
                string currentName = Console.ReadLine();

                uniqueNames.Add(currentName);
            }

            Console.WriteLine($"{string.Join(Environment.NewLine, uniqueNames)}");
        }
    }
}
