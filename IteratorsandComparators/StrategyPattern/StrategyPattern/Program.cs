using System;
using System.Collections.Generic;
using System.Linq;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var sortedByName = new SortedSet<Person>(new NameComparer());
            var sortedByAge = new SortedSet<Person>(new AgeComparer());

            int numberOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] currentPerson = Console.ReadLine()
                    .Split(" ");

                string name = currentPerson[0];
                int age = int.Parse(currentPerson[1]);

                Person person = new Person(name, age);

                sortedByAge.Add(person);
                sortedByName.Add(person);
            }

            Console.WriteLine(string.Join(Environment.NewLine, sortedByName));

            Console.WriteLine(string.Join(Environment.NewLine, sortedByAge));
        }
    }
}
