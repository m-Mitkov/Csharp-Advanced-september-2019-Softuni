using System;

namespace Person
{
    public class Program
    {
        public static void Main()
        {
            var name = Console.ReadLine();
            var isAge = int.TryParse(Console.ReadLine(), out int age);

            try
            {
                var child = new Child(name, age);
                Console.WriteLine(child);
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
