using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace songsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");

            Queue<string> queue = new Queue<string>(songs);

            while (queue.Count > 0)
            {
                string comand = Console.ReadLine();

                string[] splitedComand = comand.Split(" ");

                string toDo = splitedComand[0];

                if (toDo == "Play")
                {
                    queue.Dequeue();
                }

                else if (toDo == "Add")
                {
                    string songToAdd = comand.Substring(toDo.Length + 1);

                    if (!queue.Contains(songToAdd))
                    {
                        queue.Enqueue(songToAdd);
                    }
                    else
                    {
                        Console.WriteLine($"{songToAdd} is already contained!");
                    }
                }

                else if (toDo == "Show")
                {
                    Console.WriteLine(string.Join(", ", queue));
                }
            }
            if (queue.Count == 0)
            {
                Console.WriteLine($"No more songs!");
            }
        }
    }
}
