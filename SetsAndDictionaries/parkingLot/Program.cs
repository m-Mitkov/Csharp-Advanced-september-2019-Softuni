using System;
using System.Collections.Generic;

namespace parkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> parking = new HashSet<string>();

            while (true)
            {
                string[] inputComand = Console.ReadLine()
                    .Split(", ");

                if (inputComand[0] == "END")
                {
                    break;
                }

                string inOrOut = inputComand[0];
                string carPlate = inputComand[1];

                if (inOrOut == "IN")
                {
                    parking.Add(carPlate);
                }

                else if (inOrOut == "OUT")
                {
                    if (parking.Contains(carPlate))
                    {
                        parking.Remove(carPlate);
                    }
                }
            }

            if (parking.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
                return;
            }

            Console.WriteLine($"{string.Join(Environment.NewLine, parking)}");
        }
    }
}
