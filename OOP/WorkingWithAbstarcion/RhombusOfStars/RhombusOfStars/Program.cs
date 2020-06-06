using System;
using System.Text;

namespace RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStars = int.Parse(Console.ReadLine());

            RhombusDrawer rhombusDrawer = new RhombusDrawer();
            string rhombusAsString = rhombusDrawer.Draw(numberOfStars);

            Console.WriteLine(rhombusAsString);
        }
        
    }
}
