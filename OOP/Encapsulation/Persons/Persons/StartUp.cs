using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var inputCount = int.Parse(Console.ReadLine());
            Team team = new Team("SoftUni");

            for (int i = 0; i < inputCount; i++)
            {
                var currentPerson = Console.ReadLine()
                    .Split(" ");
                try
                {
                    var person = new Person(currentPerson[0], currentPerson[1],
                        int.Parse(currentPerson[2]), decimal.Parse(currentPerson[3]));

                    team.AddPlayer(person);
                }

                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                }
            }

            Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
            Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");
        }
    }
}
