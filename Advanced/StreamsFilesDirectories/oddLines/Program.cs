using System;
using System.IO;

namespace oddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using StreamReader reader = new StreamReader("text.txt");

            int count = 0;

            while (true)
            {
                string line = reader.ReadLine();

                if (line == null)
                {
                    break;
                }

                if (count % 2 == 1)
                {
                    Console.WriteLine(line);
                }

                count++;
            }
        }
    }
}
