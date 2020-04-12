using System;
using System.Collections.Generic;
using System.Linq;

namespace evenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            Dictionary<int, int> numbers = new Dictionary<int, int>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                int currentNumeber = int.Parse(Console.ReadLine());

                if (!numbers.ContainsKey(currentNumeber))
                {
                    numbers.Add(currentNumeber, 1);
                    continue;
                }

                numbers[currentNumeber]++;
            }

            foreach (var (number, count) in numbers)
            {
                if (count % 2 == 0)
                {
                    Console.WriteLine(number);
                    break;
                }
            }
        }
    }
}
