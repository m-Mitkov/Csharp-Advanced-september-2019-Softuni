    using System;
    using System.Collections.Generic;
    using System.Linq;

    namespace countUppercaseWords
    {
        class Program
        {
            static void Main(string[] args)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Func<string, bool> checkWord = w => w[0] == w.ToUpper()[0];

                foreach (var word in input)
                {
                    if (checkWord(word))
                    {
                        Console.WriteLine(word);
                    }
                }
            }
        }
    }
