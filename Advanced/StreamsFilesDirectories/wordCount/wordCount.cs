using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace wordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader wordsReader = new StreamReader("words.txt");

            Dictionary<string, int> countWords = new Dictionary<string, int>();

            while (!wordsReader.EndOfStream)
            {
                string[] words = wordsReader.ReadLine()
                    .Split(" ");

                foreach (var word in words)
                {
                    if (!countWords.ContainsKey(word))
                    {
                        countWords.Add(word, 0);
                    }
                }
            }

            StreamReader textReader = new StreamReader("text.txt");

            while (!textReader.EndOfStream)
            {
                string line = textReader.ReadLine()
                    .ToLower();

                string[] lineArgs = line
                    .Split(new char[] { '1', '?', '-', '.', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var word in lineArgs)
                {
                    if (countWords.ContainsKey(word))
                    {
                        countWords[word]++;
                    }
                }
            }

            countWords = countWords
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, y => y.Value);

            foreach (var (word, count) in countWords)
            {
                Console.WriteLine($"{word} - {count}");
            }
        }
    }
}
