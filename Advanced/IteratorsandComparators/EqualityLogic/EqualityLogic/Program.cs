using System;
using System.Collections.Generic;
using System.Linq;

namespace EqualityLogic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HashSet<Person> people = new HashSet<Person>();
            SortedSet<Person> sortedPeople = new SortedSet<Person>();

            int numberOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] currentPerson = Console.ReadLine()
                    .Split(" ");

                string name = currentPerson[0];
                int age = int.Parse(currentPerson[1]);

                Person person = new Person(name, age);

                people.Add(person);
                sortedPeople.Add(person);
            }

            Console.WriteLine(people.Count());
            Console.WriteLine(sortedPeople.Count());
        }
    }
}
