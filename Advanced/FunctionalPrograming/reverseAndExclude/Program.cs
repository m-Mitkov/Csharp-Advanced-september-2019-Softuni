using System;
using System.Collections.Generic;
using System.Linq;

namespace reverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //Array.Reverse(numbers);
            numbers.Reverse();

            int criteriaNumToDivide = int.Parse(Console.ReadLine());


            Func<int, int, bool> division = (n, d) => n % d != 0;

            foreach (var number in numbers)
            {
                if (division(number, criteriaNumToDivide))
                {
                    Console.Write(number + " ");
                }
            }
        }
    }
}
