using System;
using System.Linq;
using System.Collections.Generic;

namespace citiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> database = new Dictionary<string, Dictionary<string, List<string>>>();

            int numberOfInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInputs; i++)
            {
                string[] currentInput = Console.ReadLine()
                    .Split(" ");

                string continent = currentInput[0];
                string country = currentInput[1];
                string city = currentInput[2];

                if (!database.ContainsKey(continent))
                {
                    database.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!database[continent].ContainsKey(country))
                {
                    database[continent].Add(country, new List<string>());
                }

                database[continent][country].Add(city);
            }

            foreach (var kvp in database)
            {
                Console.WriteLine($"{kvp.Key}:");

                foreach (var (country, city) in kvp.Value)
                {
                    Console.WriteLine($"{country} -> {string.Join(", ", city)}");
                }
            }
        }
    }
}