using System;
using System.Collections.Generic;
using System.Linq;

namespace theVLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            var vlogers = new Dictionary<string, Dictionary<string, SortedSet<string>>>();

            while (true)
            {
                string[] comand = Console.ReadLine()
                    .Split(" ");

                if (comand[0] == "Statistics")
                {
                    break;
                }
                string toDo = comand[1];

                if (toDo == "joined")
                {
                    string vloger = comand[0];

                    if (!vlogers.ContainsKey(vloger))
                    {
                        vlogers.Add(vloger, new Dictionary<string, SortedSet<string>>());
                        vlogers[vloger].Add("followers", new SortedSet<string>());
                        vlogers[vloger].Add("following", new SortedSet<string>());
                    }
                }

                else if (toDo == "followed")
                {
                    string firstVloger = comand[0];
                    string followedVloger = comand[2];

                    if (vlogers.ContainsKey(firstVloger) && vlogers.ContainsKey(followedVloger)
                        && firstVloger != followedVloger)
                    {
                        vlogers[firstVloger]["following"].Add(followedVloger);
                        vlogers[followedVloger]["followers"].Add(firstVloger);
                    }
                }
            }

            vlogers = vlogers
                 .OrderByDescending(x => x.Value["followers"].Count)
                .ThenBy(x => x.Value["following"].Count)
                .ToDictionary(k => k.Key, v => v.Value);

            Console.WriteLine($"The V-Logger has a total of {vlogers.Count} vloggers in its logs.");

            int count = 0;
            foreach (var (vloger, people) in vlogers)
            {
                Console.WriteLine($"{++count}. {vloger} : {people["followers"].Count} followers, " +
                    $"{people["following"].Count} following");

                if (count == 1)
                {
                    foreach (var follower in people["followers"])
                    {
                        Console.WriteLine($"* {follower}");
                    }
                }
            }
        }
    }
}
