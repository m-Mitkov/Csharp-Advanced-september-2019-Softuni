using System;

namespace PersonInfo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string id = Console.ReadLine();
            string birthDate = Console.ReadLine();
            IIdentifiable person = new Citizen(name, age, birthDate, id);
            IBirthable person2 = new Citizen(name, age, birthDate, id);
            Console.WriteLine(person.Id);
            Console.WriteLine(person2.Birthdate);
        }
    }
}
