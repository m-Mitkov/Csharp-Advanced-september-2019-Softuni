using System;
using System.Collections.Generic;

namespace softUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> VIPguests = new HashSet<string>();
            HashSet<string> regularGuest = new HashSet<string>();

            while (true)
            {
                string currentGuest = Console.ReadLine();
                char firstCharGuest = currentGuest[0];

                if (currentGuest == "PARTY")
                {
                    break;
                }

                if (char.IsDigit(firstCharGuest))
                {
                    VIPguests.Add(currentGuest);
                }

                else
                {
                    regularGuest.Add(currentGuest);
                }
              
            }

            while (true)
            {
                string guestToCome = Console.ReadLine();

                if (guestToCome == "END")
                {
                    break;
                }

                if (VIPguests.Contains(guestToCome) && guestToCome.Length == 8)
                {
                    VIPguests.Remove(guestToCome);
                }

                else if(regularGuest.Contains(guestToCome) && guestToCome .Length == 8)
                {
                    regularGuest.Remove(guestToCome);
                }
            }

            Console.WriteLine(VIPguests.Count + regularGuest.Count);

            if (VIPguests.Count > 0)
            {
                Console.WriteLine($"{string.Join(Environment.NewLine, VIPguests)}");
            }

            if (regularGuest.Count > 0)
            {
                Console.WriteLine($"{string.Join(Environment.NewLine, regularGuest)}");
            }
        }
    }
}
