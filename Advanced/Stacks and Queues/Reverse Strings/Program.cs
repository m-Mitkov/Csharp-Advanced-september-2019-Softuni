using System;
using System.Linq;
using System.Collections.Generic;

namespace reverseString2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            Stack<string> reversedInput = new Stack<string>();

            for (int i = 0; i < inputText.Length; i++)
            {
                reversedInput.Push(inputText[i].ToString());
            }
            while (reversedInput.Count != 0)
            {
                Console.Write(reversedInput.Pop());
            }
        }
    }
}
