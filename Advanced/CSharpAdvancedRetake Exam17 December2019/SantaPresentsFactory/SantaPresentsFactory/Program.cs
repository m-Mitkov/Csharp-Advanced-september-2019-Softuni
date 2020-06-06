using System;
using System.Collections.Generic;
using System.Linq;

namespace SantaPresentsFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputMaterials = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int[] magicValuesInput = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            Stack<int> materials = new Stack<int>(inputMaterials);
            Queue<int> magicValues = new Queue<int>(magicValuesInput);

            Dictionary<string, int> countPresentsMade = new Dictionary<string, int>();
            countPresentsMade.Add("Doll", 0);
            countPresentsMade.Add("Wooden train", 0);
            countPresentsMade.Add("Teddy bear", 0);
            countPresentsMade.Add("Bicycle", 0);

            Dictionary<int, string> magicNeedForPresent = new Dictionary<int, string>();
            magicNeedForPresent.Add(150, "Doll");
            magicNeedForPresent.Add(250, "Wooden train");
            magicNeedForPresent.Add(300, "Teddy bear");
            magicNeedForPresent.Add(400, "Bicycle");


            while (true)
            {
                int materail;
                int magicValue;

                bool hasMaterialLeft = materials.TryPeek(out materail);
                bool hasMagicLeft = magicValues.TryPeek(out magicValue);

                if (hasMagicLeft && hasMaterialLeft)
                {
                    int totalMagicLevel = materail * magicValue;

                    if (materail == 0)
                    {
                        materials.Pop();
                    }

                    else if (magicValue == 0)
                    {
                        magicValues.Dequeue();
                    }

                    else if (totalMagicLevel < 0)
                    {
                        int materialToAdd = materail + magicValue;
                        materials.Pop();
                        magicValues.Dequeue();

                        materials.Push(materialToAdd);
                        continue;
                    }

                   else if (magicNeedForPresent.ContainsKey(totalMagicLevel))
                    {
                        string craftedToy = magicNeedForPresent[totalMagicLevel];
                        countPresentsMade[craftedToy]++;

                        materials.Pop();
                        magicValues.Dequeue();
                        continue;
                    }

                    else if(!magicNeedForPresent.ContainsKey(totalMagicLevel))
                    {
                        magicValues.Dequeue();

                        int materialToIncrease;
                        bool materialsLeft = materials.TryPop(out materialToIncrease);

                        if (materialsLeft)
                        {
                            materialToIncrease += 15;
                            materials.Push(materialToIncrease);
                        }
                        // increase the value by 15 if the totalMagic does not
                        // correspond to any gift
                    }
                }

                else
                {
                    break;
                }
            }

            if (countPresentsMade["Doll"] != 0 && countPresentsMade["Wooden train"] != 0)
            {
                Console.WriteLine($"The presents are crafted! Merry Christmas!");
            }

            else if (countPresentsMade["Teddy bear"] != 0 && countPresentsMade["Bicycle"] != 0)
            {
                Console.WriteLine($"The presents are crafted! Merry Christmas!");
            }

            else
            {
                Console.WriteLine("No presents this Christmas!");
            }

            if (materials.Any())
            {
                Console.Write($"Materials left: {string.Join(", ", materials)}");
            }

            if (magicValues.Any())
            {
                Console.Write($"Magic left: {string.Join(", ", magicValues)}");
            }

            Console.WriteLine();

            countPresentsMade = countPresentsMade.OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            foreach (var (present, count) in countPresentsMade)
            {
                if (count != 0)
                {
                    Console.WriteLine($"{present}: {count}");
                }
            }
        }
    }
}
