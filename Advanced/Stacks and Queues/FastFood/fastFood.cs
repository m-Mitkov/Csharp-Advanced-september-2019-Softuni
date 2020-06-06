using System;
using System.Linq;
using System.Collections.Generic;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityPreparedFood = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            Queue<int> customers = new Queue<int>(orders);

            Console.WriteLine(customers.Max());

            for (int i = 0; i < orders.Length; i++)
            {
                int foodToServe = customers.Peek();

                if (quantityPreparedFood - foodToServe >= 0)
                {
                    customers.Dequeue();

                    quantityPreparedFood -= foodToServe;
                }

                else if (quantityPreparedFood - foodToServe < 0)
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", customers)}");
                    return;

                }
            }

            Console.WriteLine("Orders complete");
        }
    }
}
