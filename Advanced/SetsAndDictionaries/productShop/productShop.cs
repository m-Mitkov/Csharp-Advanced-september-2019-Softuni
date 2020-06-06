using System;
using System.Linq;
using System.Collections.Generic;

namespace productShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> databaseShops =
                   new Dictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split(", ");

                if (input[0] == "Revision")
                {
                    break;
                }

                string shop = input[0];
                string product = input[1];
                double price = double.Parse(input[2]);

                if (!databaseShops.ContainsKey(shop))
                {
                    databaseShops.Add(shop, new Dictionary<string, double>());
                }

                if (databaseShops.ContainsKey(shop))
                {
                    databaseShops[shop].Add(product, price);
                }
            }

            databaseShops = databaseShops.OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            foreach (var kvp in databaseShops)
            {
                Console.WriteLine($"{ kvp.Key}->");

                foreach (var kvpValue in kvp.Value)
                {
                    Console.WriteLine($"Product: {kvpValue.Key}, Price: {kvpValue.Value}");
                }
            }
        }
    }
}
