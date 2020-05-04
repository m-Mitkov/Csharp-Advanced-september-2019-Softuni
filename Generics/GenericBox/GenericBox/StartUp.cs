using System;

namespace GenericBox
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            //for (int i = 0; i < numberOfInputs; i++)
            //{
            //    string inputItem = Console.ReadLine();
            //    Box<string> item = new Box<string>(inputItem);
            //    Console.WriteLine(item.ToString());
            //}

            for (int i = 0; i < numberOfInputs; i++)
            {
                int inputItem = int.Parse(Console.ReadLine());
                Box<int> item = new Box<int>(inputItem);
                Console.WriteLine(item.ToString());
            }
        }
    }
}
