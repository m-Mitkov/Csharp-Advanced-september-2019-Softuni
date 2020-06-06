using System;
using System.Linq;
using System.Collections.Generic;

namespace balancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();

            if (expression.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }

            Dictionary<char, char> pairsParentheses = new Dictionary<char, char>
            {
                {'(', ')'}, {'[', ']'}, {'{', '}'}
            };

            Stack<char> openingBrackets = new Stack<char>();
            string alowedOpeningBrackets = "([{";

            for (int i = 0; i < expression.Length; i++)
            {
                char currentCh = expression[i];

                if (alowedOpeningBrackets.Contains(currentCh))
                {
                    openingBrackets.Push(currentCh);
                }

                else if (openingBrackets.Count == 0) // if it starts with a closing bracket
                                                      // or if it starts with other symobls the
                                                      // count remains 0 and the program should end
                {
                    Console.WriteLine("NO");
                    return;
                }

                else
                {
                    char currentOpeningBracket = openingBrackets.Pop();

                    if (pairsParentheses[currentOpeningBracket] != currentCh)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
            }

            Console.WriteLine(openingBrackets.Count == 0 ?"YES" : "NO");
        }
    }
}
