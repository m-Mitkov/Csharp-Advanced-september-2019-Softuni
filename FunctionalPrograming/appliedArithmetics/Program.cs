using System;
using System.Collections.Generic;
using System.Linq;

namespace appliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int, int> predicate = null;

            while (true)
            {
                string comand = Console.ReadLine();

                if (comand == "end")
                {
                    break;
                }

                switch (comand)
                {
                    case "add":
                        predicate = n => n + 1;
                        break;
                    case "multiply":
                        predicate = n => n * 2;
                        break;
                    case "subtract":
                        predicate = n => n - 1;
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", numbers));
                        break;
                }
                if (predicate != null)
                {
                    numbers = numbers.Select(n => predicate(n)).ToArray();
                }
            }
        }
    }
}
