using System;
using System.Collections.Generic;
using System.Linq;

namespace countSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> countSymbols = new SortedDictionary<char, int>();

            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                char currentSymbol = text[i];

                if (!countSymbols.ContainsKey(currentSymbol))
                {
                    countSymbols.Add(currentSymbol, 1);
                    continue;
                }

                countSymbols[currentSymbol]++;
            }

            foreach (var (@char, count) in countSymbols)
            {
                Console.WriteLine($"{@char}: {count} time/s");
            }
        }
    }
}
