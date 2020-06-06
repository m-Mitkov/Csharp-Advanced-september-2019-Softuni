using System;

namespace HotelReservation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ");

            double priceDay = double.Parse(input[0]);
            int numberOfDays = int.Parse(input[1]);
            Season inputSeason = (Season)Enum.Parse(typeof(Season), input[2]);
            DiscountType discountType = input.Length == 4 ? (DiscountType)Enum.Parse(typeof(DiscountType), input[3]) : DiscountType.None;

            PriceCalculator price = new PriceCalculator();
            Console.WriteLine($"{price.GetToTalPrice(priceDay, numberOfDays, inputSeason, discountType):F2}");
        }
    }
}
