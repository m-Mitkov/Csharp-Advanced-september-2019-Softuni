using System;
using System.Text.RegularExpressions;

namespace Telephony
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone();

            string[] contactListToCall = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var number in contactListToCall)
            {
                Console.WriteLine(smartphone.Call(number));
            }

            string[] URLToBrowse = Console.ReadLine()
                  .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var website in URLToBrowse)
            {
                Console.WriteLine(smartphone.LoadPage(website));
            }
        }
    }
}
