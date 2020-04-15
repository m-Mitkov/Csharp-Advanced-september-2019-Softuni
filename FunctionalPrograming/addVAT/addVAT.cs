using System;
using System.Collections.Generic;
using System.Linq;

namespace addVAT
{
    class Program
    {
        static void Main(string[] args)
        {
                        Console.WriteLine(string.Join(Environment.NewLine,
                Console.ReadLine()
                .Split(", ")
                .Select(n => double.Parse(n))
                .Select(n => n * 1.2)
                .Select(n => $"{n:F2}")));
        }
    }
}
