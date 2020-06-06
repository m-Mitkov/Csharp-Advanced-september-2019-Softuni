using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace simpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfComands = int.Parse(Console.ReadLine());

            StringBuilder text = new StringBuilder();
            Stack<string> backupText = new Stack<string>();

            for (int i = 0; i < numberOfComands; i++)
            {
                string[] comand = Console.ReadLine()
                    .Split(" ");

                string toDo = comand[0];

                switch (toDo)
                {
                    case "1":
                        string textToAppend = comand[1];
                        text.Append(textToAppend);

                        backupText.Push(text.ToString());
                        break;

                    case "2":
                        int elementsToErase = int.Parse(comand[1]);
                        text.Remove(text.Length - elementsToErase, elementsToErase);

                        backupText.Push(text.ToString());
                        break;

                    case "3":
                        int indexOfElement = int.Parse(comand[1]);

                        Console.WriteLine(text[indexOfElement - 1]);

                        break;

                    case "4":
                        backupText.Pop();
                        text.Clear();
                        text.Append(backupText.Peek());
                        break;
                }
                
            }
        }
    }
}
