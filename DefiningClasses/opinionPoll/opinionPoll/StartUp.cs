using System;
using System.Collections.Generic;
using System.Linq;

namespace opinionPoll
{
   public class StartUp
    {
       public static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] currentPerson = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = currentPerson[0];
                int age = int.Parse(currentPerson[1]);

                Person person = new Person(name, age);

                family.AddMember(person);
            }

            List<Person> peopleOverThirty = family.GetPeopleOverThirty()
                .OrderBy(x => x.Name)
                .ToList();

            foreach (var person in peopleOverThirty)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
