using System;
using System.Collections.Generic;

namespace GenericSwapMethod
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            List<Box<int>> items = new List<Box<int>>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                int inputItem = int.Parse(Console.ReadLine());

                Box<int> item = new Box<int>(inputItem);
                items.Add(item);
            }

            string[] indexesToSwap = Console.ReadLine()
                .Split(" ");

            int firstIndex = int.Parse(indexesToSwap[0]);
            int secondIndex = int.Parse(indexesToSwap[1]);

            DoSwapComand(items, firstIndex, secondIndex);

            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        public static void DoSwapComand(List<Box<int>> items, int firstIndex, int secondIndex)
        {
            if (CheckIndexses(items, firstIndex, secondIndex))
            {
                var temp = items[firstIndex];
                items[firstIndex] = items[secondIndex];
                items[secondIndex] = temp;
            }
        }

        public static bool CheckIndexses(List<Box<int>> items, int firstIndex, int secondIndex)
        {
            return firstIndex >= 0 && firstIndex < items.Count
                && secondIndex >= 0 && secondIndex < items.Count;
        }
    }
}
