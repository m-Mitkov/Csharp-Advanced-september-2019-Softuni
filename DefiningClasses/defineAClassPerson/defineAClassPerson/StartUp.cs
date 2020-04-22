using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int numberOfFamilyMembers = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < numberOfFamilyMembers; i++)
            {
                string[] member = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = member[0];
                int age = int.Parse(member[1]);

                Person person = new Person(name, age);

                family.AddMember(person);
            }

            Person oldestMember = family.GetOldestMember();

            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
         }
    }
}
