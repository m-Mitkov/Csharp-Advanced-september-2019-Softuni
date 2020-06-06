using System;
using System.Collections.Generic;
using System.Linq;

namespace partyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> filtersToApply = new List<string>();

            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split(";", 2)
                    .ToArray();

                if (input[0] == "Print")
                {
                    break;
                }

                string comand = input[0];
                string filterType = input[1];

                if (comand == "Add filter")
                {
                    filtersToApply.Add(filterType);
                }

                else if (comand == "Remove filter")
                {
                    filtersToApply.Remove(filterType);
                }
            }

            foreach (var filters in filtersToApply)
            {
                string[] currentFilter = filters
                    .Split(";");

                string filterType = currentFilter[0];
                string filterParameter = currentFilter[1];

                Func<string, string, bool> filter = FunctionType(filterType);

                guests = guests
                    .Where(x => !filter(x, filterParameter))
                    .ToList();
            }

            Console.WriteLine(string.Join(" ", guests));
        }

        static Func<string, string, bool> FunctionType(string filterType)
        {
            if (filterType == "Starts with")
            {
                return (name, parameter) => name.StartsWith(parameter);
            }
            else if (filterType == "Ends with")
            {
                return (name, parameter) => name.EndsWith(parameter);
            }
            else if (filterType == "Length")
            {
                return (name, parameter) => name.Length == int.Parse(parameter);
            }
            else if (filterType == "Contains")
            {
                return (name, parameter) => name.Contains(parameter);
            }
            return null;
        }
    }
}
