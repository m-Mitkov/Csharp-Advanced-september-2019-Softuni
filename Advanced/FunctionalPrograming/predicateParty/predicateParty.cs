using System;
using System.Linq;
using System.Collections.Generic;

namespace predicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine()
                .Split(" ")
                .ToList();

            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "Party!")
                {
                    break;
                }

                string comand = input[0];
                string criteria = input[1];

                if (criteria == "StartsWith")
                {
                    string basedCriteria = input[2];

                    Predicate<string> checkIfStartWith = name => name.StartsWith(basedCriteria);
                    guests = DoubleOrRemove(guests, comand, checkIfStartWith);
                }

                else if (criteria == "EndsWith")
                {
                    string basedCriteria = input[2];
                    Predicate<string> endsWith = name => name.EndsWith(basedCriteria);
                    guests = DoubleOrRemove(guests, comand, endsWith);
                }

                else if (criteria == "Length")
                {
                    int lenghtCriteria = int.Parse(input[2]);
                    Predicate<string> lenghtIsCorrect = name => name.Length == lenghtCriteria;
                    guests = DoubleOrRemove(guests, comand, lenghtIsCorrect);
                }
            }

            Console.WriteLine(guests.Any() ? $"{string.Join(", ", guests)} are going to the party!" : 
                "Nobody is going to the party!");
        }

        static List<string> DoubleOrRemove(List<string> guests, string comand,Predicate<string> filter)
        {
            List<string> newList = new List<string>();

            foreach (var guest in guests)
            {
                if (filter(guest))
                {
                    if (comand == "Double")
                    {
                        newList.Add(guest);
                    }

                    else if (comand == "Remove")
                    {
                        continue;
                    }
                }
                newList.Add(guest);
            }

            return newList;
        }
    }
}
