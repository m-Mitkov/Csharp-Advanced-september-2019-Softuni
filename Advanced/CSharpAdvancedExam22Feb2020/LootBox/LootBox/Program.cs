using System;
using System.Collections.Generic;
using System.Linq;

namespace LootBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> firstBox = new Queue<int>();

            int[] firstBoxNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            foreach (var number in firstBoxNumbers)
            {
                firstBox.Enqueue(number);
            }

            Stack<int> secondBox = new Stack<int>();

            int[] secondBoxNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            foreach (var number in secondBoxNumbers)
            {
                secondBox.Push(number);
            }

            int totalCountItems = 0;

            while (true)
            {
                if (firstBox.Count == 0)
                {
                    Console.WriteLine("First lootbox is empty");
                    break;
                }

                if (secondBox.Count == 0)
                {
                    Console.WriteLine("Second lootbox is empty");
                    break;
                }

                int itemFirstBox = firstBox.Peek();
                int itemSecondBox = secondBox.Peek();

                int sumCurrentElement = itemFirstBox + itemSecondBox;

                if (sumCurrentElement % 2 == 0)
                {
                    totalCountItems += sumCurrentElement;
                    firstBox.Dequeue();
                    secondBox.Pop();
                }

                else
                {
                    int numberToMove = secondBox.Pop();
                    firstBox.Enqueue(numberToMove);
                }
            }

            if (totalCountItems >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {totalCountItems}");
            }

            else
            {
                Console.WriteLine($"Your loot was poor... Value: {totalCountItems}");
            }
        }
    }
}
