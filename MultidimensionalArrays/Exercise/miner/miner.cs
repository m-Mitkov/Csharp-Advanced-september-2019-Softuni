using System;
using System.Linq;
using System.Collections.Generic;

namespace miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeField = int.Parse(Console.ReadLine());

            int rows = sizeField;
            int cols = sizeField;

            char[,] field = new char[rows, cols];

            int totalCoals = 0;
            int startMinerRow = 0;
            int startMinerCol = 0;

            bool gameIsOver = false;

            string[] comands = Console.ReadLine()
                .Split(" ");

            WriteMatrix(field, ref totalCoals, ref startMinerRow, ref startMinerCol);

            int collectedCoal = 0;

            // '*' - regular position, 'e' - end of game, 'c' - find coal, 's' - start positon

            for (int i = 0; i < comands.Length; i++)
            {
                string currentComand = comands[i];
                int moveRow = 0;
                int moveCol = 0;


                if (currentComand == "up")
                {
                    moveRow = -1;
                    moveCol = 0;

                    if (CheckIndexes(field, ref startMinerRow, ref startMinerCol, moveRow, moveCol))
                    {
                        MoveMiner(field, ref startMinerRow, ref startMinerCol,
                                 moveRow, moveCol, ref collectedCoal, ref gameIsOver);
                    }
                }

                else if (currentComand == "down")
                {
                    moveRow = +1;
                    moveCol = 0;

                    if (CheckIndexes(field, ref startMinerRow, ref startMinerCol, moveRow, moveCol))
                    {
                        MoveMiner(field, ref startMinerRow, ref startMinerCol,
                                 moveRow, moveCol, ref collectedCoal, ref gameIsOver);
                    }
                }

                else if (currentComand == "right")
                {
                    moveRow = 0;
                    moveCol = +1;

                    if (CheckIndexes(field, ref startMinerRow, ref startMinerCol, moveRow, moveCol))
                    {
                        MoveMiner(field, ref startMinerRow, ref startMinerCol,
                                 moveRow, moveCol, ref collectedCoal, ref gameIsOver);
                    }
                }

                else if (currentComand == "left")
                {
                    moveRow = 0;
                    moveCol = -1;

                    if (CheckIndexes(field, ref startMinerRow, ref startMinerCol, moveRow, moveCol))
                    {
                        MoveMiner(field, ref startMinerRow, ref startMinerCol,
                                 moveRow, moveCol, ref collectedCoal, ref gameIsOver);
                    }
                }

                if (gameIsOver == true)
                {
                    Console.WriteLine($"Game over! ({startMinerRow}, {startMinerCol})");
                    return;
                }

                if (collectedCoal == totalCoals)
                {
                    Console.WriteLine($"You collected all coals! ({startMinerRow}, {startMinerCol})");
                    return;
                }

            }

            int coalsLeft = totalCoals - collectedCoal;

            Console.WriteLine($"{coalsLeft} coals left. ({startMinerRow}, {startMinerCol})");
        }
        public static void MoveMiner(char[,] field, ref int startRow, ref int startCol,
                        int moveRow, int moveCol, ref int collectedCoal, ref bool gameIsOver)
        {
            if (field[startRow + moveRow, startCol + moveCol] == 'c')
            {
                collectedCoal++;

                field[startRow + moveRow, startCol + moveCol] = 's';
                field[startRow, startCol] = '*';

                startRow = startRow + moveRow;
                startCol = startCol + moveCol;
            }

            else if (field[startRow + moveRow, startCol + moveCol] == 'e')
            {
                gameIsOver = true;

                field[startRow + moveRow, startCol + moveCol] = 's';
                field[startRow, startCol] = '*';

                startRow = startRow + moveRow;
                startCol = startCol + moveCol;
            }

            else if (field[startRow + moveRow, startCol + moveCol] == '*')
            {
                field[startRow + moveRow, startCol + moveCol] = 's';
                field[startRow, startCol] = '*';

                startRow = startRow + moveRow;
                startCol = startCol + moveCol;
            }
        }
        public static bool CheckIndexes(char[,] field, ref int startRow, ref int startCol, int rowMove, int colMove)
        {
            if ((startRow + rowMove < field.GetLength(0) && startRow + rowMove >= 0) &&
                  (startCol + colMove < field.GetLength(1) && startCol + colMove >= 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void WriteMatrix(char[,] field, ref int totalCoals, ref int startRow, ref int startCol)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                char[] input = Console.ReadLine()
                    .Split(' ')
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < field.GetLength(1); col++)
                {
                    field[row, col] = input[col];

                    if (input[col] == 's')
                    {
                        startRow = row;
                        startCol = col;
                    }

                    if (input[col] == 'c')
                    {
                        totalCoals++;
                    }
                }
            }
        }
    }
}
