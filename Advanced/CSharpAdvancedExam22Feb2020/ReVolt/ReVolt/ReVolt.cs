using System;
using System.Collections.Generic;
using System.Linq;

namespace ReVolt
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixDimensions = int.Parse(Console.ReadLine());
            int countOfComand = int.Parse(Console.ReadLine());

            int rows = matrixDimensions;
            int cols = matrixDimensions;

            char[,] field = new char[rows, cols];
            int playerRow = 0;
            int playerCol = 0;
            WriteMatrix(field, ref playerRow, ref playerCol);
            bool playerWon = false;

            for (int i = 0; i < countOfComand; i++)
            {
                string direction = Console.ReadLine();

                int newPlayerRow = playerRow;
                int newPlayerCol = playerCol;

                if (direction == "down")
                {
                    newPlayerRow = playerRow + 1;

                    CheckNewIndex(field, ref newPlayerRow);

                    if (field[newPlayerRow, playerCol] == 'B')
                    {
                        newPlayerRow = newPlayerRow + 1;
                        CheckNewIndex(field, ref newPlayerRow);
                    }

                    if (field[newPlayerRow, playerCol] == 'F')
                    {
                        field[newPlayerRow, playerCol] = 'f';
                        playerWon = true;
                    }

                    if (field[newPlayerRow, playerCol] == 'T')
                    {
                        newPlayerRow = newPlayerRow - 1;
                        CheckNewIndex(field, ref newPlayerRow);
                    }
                }

                else if (direction == "up")
                {
                    newPlayerRow = playerRow - 1;

                    CheckNewIndex(field, ref newPlayerRow);

                    if (field[newPlayerRow, playerCol] == 'B')
                    {
                        newPlayerRow = newPlayerRow - 1;
                        CheckNewIndex(field, ref newPlayerRow);
                    }

                    if (field[newPlayerRow, playerCol] == 'F')
                    {
                        field[newPlayerRow, playerCol] = 'f';
                        playerWon = true;
                    }

                    if (field[newPlayerRow, playerCol] == 'T')
                    {
                        newPlayerRow = newPlayerRow + 1;
                        CheckNewIndex(field, ref newPlayerRow);
                    }
                }

                else if (direction == "left")
                {
                    newPlayerCol = playerCol - 1;

                    CheckNewIndex(field, ref newPlayerCol);

                    if (field[playerRow, newPlayerCol] == 'B')
                    {
                        newPlayerCol = newPlayerCol - 1;
                        CheckNewIndex(field, ref newPlayerCol);
                    }

                    if (field[playerRow, newPlayerCol] == 'F')
                    {
                        field[playerRow, newPlayerCol] = 'f';
                        playerWon = true;

                    }

                    if (field[playerRow, newPlayerCol] == 'T')
                    {
                        newPlayerCol = newPlayerCol + 1;
                        CheckNewIndex(field, ref newPlayerCol);
                    }
                }

                else if (direction == "right")
                {
                    newPlayerCol = playerCol + 1;

                    CheckNewIndex(field, ref newPlayerCol);

                    if (field[playerRow, newPlayerCol] == 'B')
                    {
                        newPlayerCol = newPlayerCol + 1;
                        CheckNewIndex(field, ref newPlayerCol);
                    }

                    if (field[playerRow, newPlayerCol] == 'F')
                    {
                        field[playerRow, newPlayerCol] = 'f';
                        playerWon = true;

                    }

                    if (field[playerRow, newPlayerCol] == 'T')
                    {
                        newPlayerCol = newPlayerCol - 1;
                        CheckNewIndex(field, ref newPlayerCol);
                    }
                }

                field[newPlayerRow, newPlayerCol] = 'f';
                field[playerRow, playerCol] = '-';
                playerRow = newPlayerRow;
                playerCol = newPlayerCol;

                if (playerWon)
                {
                    Console.WriteLine("Player won!");
                    PrintMatrix(field);
                    return;
                }
            }

            Console.WriteLine("Player lost!");
            PrintMatrix(field);
        }

        public static void PrintMatrix(char[,] field)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    Console.Write(field[row, col]);
                }

                Console.WriteLine();
            }
        }

        public static void CheckNewIndex(char[,] field, ref int newPossitionPlayer)
        {
            if (newPossitionPlayer > field.GetLength(0) - 1)
            {
                newPossitionPlayer = 0;
            }

            else if (newPossitionPlayer < 0)
            {
                newPossitionPlayer = field.GetLength(0) - 1;
            }
        }


        public static void WriteMatrix(char[,] matrix, ref int playerRow, ref int playerCol)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];

                    if (matrix[row, col] == 'f')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }
        }
    }
}
