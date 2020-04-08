using System;
using System.IO;

namespace lineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("text.txt");

            StreamWriter writer = new StreamWriter("result.txt");

            int count = 1;

            while (true)
            {
                string currentLine = reader.ReadLine();

                if (currentLine == null)
                {
                    break;
                }

                writer.WriteLine($"{count}. {currentLine}");

                count++;

                writer.Flush();
            }
        }
    }
}
