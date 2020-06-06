using System;
using System.Collections.Generic;
using System.Linq;

namespace BookWorm
{
    class Program
    {
        static void Main(string[] args)
        {
            string initialWord = Console.ReadLine();
            int sizeField = int.Parse(Console.ReadLine());

            char[,] matrix = new char[sizeField, sizeField];
            int playerRow = 0;
            int playerCol = 0;

            WriteMatrrix(ref playerRow, ref playerCol, matrix);

            while (true)
            {
                string comand = Console.ReadLine();

                int newRow = playerRow;
                int newCol = playerCol;

                if (comand == "end")
                {
                    break;
                }

                if (comand == "up")
                {
                    newRow -= 1;

                    if (newRow >= 0)
                    {
                        if (char.IsLetter(matrix[newRow, newCol]))
                        {
                            initialWord += matrix[newRow, newCol];
                        }
                    }

                    else
                    {
                        newRow = playerRow;

                        if (initialWord.Length > 1)
                        {
                            initialWord = initialWord.Remove(initialWord.Length - 1);
                        }
                    }
                }

                else if (comand == "down")
                {
                    newRow += 1;

                    if (newRow <= matrix.GetLength(0) - 1)
                    {
                        if (char.IsLetter(matrix[newRow, newCol]))
                        {
                            initialWord += matrix[newRow, newCol];
                        }
                    }

                    else
                    {
                        newRow = playerRow;

                        if (initialWord.Length > 1)
                        {
                            initialWord = initialWord.Remove(initialWord.Length - 1);
                        }
                    }
                }

                else if (comand == "left")
                {
                    newCol -= 1;

                    if (newCol >= 0)
                    {
                        if (char.IsLetter(matrix[newRow, newCol]))
                        {
                            initialWord += matrix[newRow, newCol];
                        }
                    }

                    else
                    {
                        newCol = playerCol;

                        if (initialWord.Length > 1)
                        {
                            initialWord = initialWord.Remove(initialWord.Length - 1);
                        }
                    }
                }

                else if (comand == "right")
                {
                    newCol += 1;

                    if (newCol <= matrix.GetLength(1) - 1)
                    {
                        if (char.IsLetter(matrix[newRow, newCol]))
                        {
                            initialWord += matrix[newRow, newCol];
                        }
                    }

                    else
                    {
                        newCol = playerCol;

                        if (initialWord.Length > 1)
                        {
                            initialWord = initialWord.Remove(initialWord.Length - 1);
                        }
                    }
                }

                matrix[playerRow, playerCol] = '-';
                matrix[newRow, newCol] = 'P';

                playerRow = newRow;
                playerCol = newCol;
            }

            Console.WriteLine(initialWord);
            PrintMatrix(matrix);
        }

        public static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }

        public static void WriteMatrrix(ref int playerRow, ref int playerCol, char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (input[col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }

                    matrix[row, col] = input[col];
                }
            }
        }
    }
}
