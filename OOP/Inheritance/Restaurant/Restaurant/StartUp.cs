using System;

namespace Restaurant
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            Coffee coffee = new Coffee(1, "lavazza", 1, 1);

            Console.WriteLine(coffee.Price);
        }
    }
}
