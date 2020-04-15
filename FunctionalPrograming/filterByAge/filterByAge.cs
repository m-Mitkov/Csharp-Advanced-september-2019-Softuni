using System;
using System.Collections.Generic;
using System.Linq;

namespace filterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            int numberOfPeoples = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPeoples; i++)
            {
                string[] currentPerson = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string name = currentPerson[0];
                int age = int.Parse(currentPerson[1]);

                Person person = new Person(name, age);
                people.Add(person);
            }

            string condition = Console.ReadLine();
            int conditionParameter = int.Parse(Console.ReadLine());

            Func<Person, bool> predicate = null;

            if (condition == "younger")
            {
                predicate = p => p.Age < conditionParameter;
            }

            else if (condition == "older")
            {
                predicate = p => p.Age >= conditionParameter;
            }

            var filteredPeople = people.Where(predicate);

            string outputFormat = Console.ReadLine();

            foreach (var peron in filteredPeople)
            {
                if (outputFormat == "name age")
                {
                    Console.WriteLine($"{peron.Name} - {peron.Age}");
                }
                else if (outputFormat == "age")
                {
                    Console.WriteLine($"{peron.Age}");
                }
                else if (outputFormat == "name")
                {
                    Console.WriteLine($"{peron.Name}");
                }
            }
        }
    }
}
