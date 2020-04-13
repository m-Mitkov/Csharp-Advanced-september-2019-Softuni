using System;
using System.Collections.Generic;
using System.Linq;

namespace ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contestPassword = new Dictionary<string, string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of contests")
                {
                    break;
                }

                string[] inputArgs = input.Split(":");
                string course = inputArgs[0];
                string password = inputArgs[1];

                if (!contestPassword.ContainsKey(course))
                {
                    contestPassword.Add(course, password);
                }
            }

            var studentsDatabase = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of submissions")
                {
                    break;
                }

                string[] inputArgs = input.Split("=>");

                string contest = inputArgs[0];
                string password = inputArgs[1];
                string username = inputArgs[2];
                int points = int.Parse(inputArgs[3]);

                if (contestPassword.ContainsKey(contest) && contestPassword[contest] == password)
                {
                    if (!studentsDatabase.ContainsKey(username))
                    {
                        studentsDatabase.Add(username, new Dictionary<string, int>());
                    }

                    if (!studentsDatabase[username].ContainsKey(contest))
                    {
                        studentsDatabase[username].Add(contest, points);
                    }

                    if (studentsDatabase[username][contest] < points)
                    {
                        studentsDatabase[username][contest] = points;
                    }
                }
            }

            var topStudent = studentsDatabase
                .OrderByDescending(x => x.Value.Sum(s => s.Value))
                .FirstOrDefault();

            Console.WriteLine($"Best candidate is {topStudent.Key} with total {topStudent.Value.Sum(x => x.Value)} points.");

            Console.WriteLine($"Ranking:");

            foreach (var (username, contest) in studentsDatabase.OrderBy(x => x.Key))
            {
                Console.WriteLine(username);

                foreach (var (course, points) in contest.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {course} -> {points}");
                }
            }
        }
    }
}
