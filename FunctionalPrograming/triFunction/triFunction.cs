using System;
using System.Collections.Generic;
using System.Linq;

namespace triFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int parameterNumber = int.Parse(Console.ReadLine());

            Func<string, char[]> toCharArray = x => x.ToCharArray();
            Func<char, int> castChar = x => (int)x;
            Func<string, bool> result = x => toCharArray(x).Select(castChar).Sum() >= parameterNumber;

            Console.WriteLine
                (Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .FirstOrDefault(result));
        }
    }
}
