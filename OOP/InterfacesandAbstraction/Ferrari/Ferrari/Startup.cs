
using System;

namespace Ferrari
{
    class Startup
    {
        static void Main(string[] args)
        {
            string modelFerrari = "488-Spider";
            string driver = Console.ReadLine();

            Ferrari ferrari = new Ferrari(driver);

            Console.WriteLine($"{modelFerrari}/{ferrari.Brakes()}/{ferrari.Gas()}/{ferrari.Driver}");
        }
    }
}
