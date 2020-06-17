using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Buyer> database = new List<Buyer>();

            int numberOfInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInputs; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ");

                if (input.Length == 4)
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string id = input[2];

                    DateTime birthdate = DateTime.ParseExact(input[3], "dd/MM/yyyy", null);

                    database.Add(new Citizen(name, age, id, birthdate));
                }

                else if (input.Length == 3)
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string group = input[2];

                    database.Add(new Rebel(name, age, group));
                }
            }

            while (true)
            {
                string buyer = Console.ReadLine();

                if (buyer == "End")
                {
                    break;
                }

                Buyer currentBuyer = database.FirstOrDefault(x => x.Name == buyer);

                if (currentBuyer != default)
                {
                    currentBuyer.BuyFood();
                }
            }

            int totalFoodBought = database.Sum(x => x.Food);
            Console.WriteLine(totalFoodBought);
        }
    }
}
