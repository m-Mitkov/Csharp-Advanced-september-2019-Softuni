using System;
using PlayersAndMonsters.Elfs;
using PlayersAndMonsters.Knights;
using PlayersAndMonsters.Wizards;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Knight knight = new Knight("Batman", 999);
            Console.WriteLine(knight);

            Hero wizard = new Wizard("Dumbeldore", 99);
            Console.WriteLine(wizard);
        }
    }
}
