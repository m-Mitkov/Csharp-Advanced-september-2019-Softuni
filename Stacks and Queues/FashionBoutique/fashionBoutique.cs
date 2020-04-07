using System;
using System.Linq;
using System.Collections.Generic;

namespace fashionBotique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int capacitySingleRack = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(clothes);

            int countRacksUsed = 1;
            int currnetValueOfTheRack = 0;

            while (stack.Count > 0)
            {
                int currentClotheValue = stack.Peek();

                if (currnetValueOfTheRack + currentClotheValue <= capacitySingleRack)
                {
                    currnetValueOfTheRack += currentClotheValue;

                    stack.Pop();
                }

                else
                {
                    countRacksUsed++;

                    currnetValueOfTheRack = 0;

                    currnetValueOfTheRack += currentClotheValue;

                    stack.Pop();
                }
            }

            Console.WriteLine(countRacksUsed);
        }
    }
}
