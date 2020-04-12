using System;
using System.Collections.Generic;

namespace uniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfUsernames = int.Parse(Console.ReadLine());
            HashSet<string> usernames = new HashSet<string>();

            for (int i = 0; i < numberOfUsernames; i++)
            {
                string curentUsername = Console.ReadLine();

                usernames.Add(curentUsername);
            }

            Console.WriteLine($"{string.Join(Environment.NewLine, usernames)}");
        }
    }
}
