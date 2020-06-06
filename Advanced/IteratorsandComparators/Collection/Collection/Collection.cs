using System;
using System.Collections.Generic;
using System.Linq;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            ListyIterator<string> collection = null;

            while (true)
            {
                string[] comandInput = Console.ReadLine()
                    .Split(" ");

                if (comandInput[0] == "END")
                {
                    break;
                }

                if (comandInput[0] == "Create")
                {
                    collection = new ListyIterator<string>(comandInput.Skip(1).ToArray());
                }

                else if (comandInput[0] == "Move")
                {
                    Console.WriteLine(collection.Move());
                }

                else if (comandInput[0] == "HasNext")
                {
                    Console.WriteLine(collection.HasNext());
                }

                else if (comandInput[0] == "Print")
                {
                    Console.WriteLine(collection.Print());
                }

                else if (comandInput[0] == "PrintAll")
                {
                    Console.WriteLine(collection.PrintAll());
                }
            }
        }
    }
}
