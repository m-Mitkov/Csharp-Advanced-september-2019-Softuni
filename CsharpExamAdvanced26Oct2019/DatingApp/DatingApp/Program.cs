using System;
using System.Collections.Generic;
using System.Linq;

namespace DatingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputMales = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int[] inputFemales = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            //3 6 9 12  males
            //12 9 6 1 25 25  females 

            inputFemales.Reverse();

            Stack<int> males = new Stack<int>(inputMales);
            Queue<int> females = new Queue<int>(inputFemales);

            int totalMatches = 0;

            while (males.Any() && females.Any())
            {
                int currentMale = males.Peek();
                int currentFemale = females.Peek();

                if (currentMale <= 0)
                {
                    if (males.TryPop(out currentMale))
                    {
                        continue;
                    }
                }

                else if (currentFemale <= 0)
                {
                    if (females.TryDequeue(out currentFemale))
                    {
                        continue;
                    }
                }

               else if (currentMale % 25 == 0)
                {
                    if (females.Count - 2 >= 0)
                    {
                        males.Pop();
                        males.Pop();
                    }
                }

                else if (currentFemale % 25 == 0)
                {
                    if (females.Count - 2 >= 0)
                    {
                        females.Dequeue();
                        females.Dequeue();
                    }
                }

               else if (currentFemale == currentMale)
                {
                    totalMatches++;

                    if (males.Any())
                    {
                        males.Pop();
                    }

                    if (females.Any())
                    {
                        females.Dequeue();
                    }
                }

                else if (currentMale != currentFemale)
                {
                    if (females.Any())
                    {
                        females.Dequeue();
                    }

                    if (males.Any())
                    {
                        int newValue = currentMale - 2;
                        males.Pop();
                        males.Push(newValue);
                    }
                }
            }

            var resultMales = males.Any()
                ? $"Males left: {string.Join(", ", males)}"
                : "Males left: none";

            var resultFemales = females.Any()
                ? $"Females left: {string.Join(", ", females)}"
                : "Females left: none";

            Console.WriteLine($"Matches: {totalMatches}");
            Console.WriteLine(resultMales);
            Console.WriteLine(resultFemales);
        }
    }
}
