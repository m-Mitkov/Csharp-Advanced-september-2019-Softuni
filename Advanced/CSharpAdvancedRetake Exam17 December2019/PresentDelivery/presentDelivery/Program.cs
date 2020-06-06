using System;
using System.Collections.Generic;
using System.Linq;

namespace presentDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfGifts = int.Parse(Console.ReadLine());

            int sizeMatrix = int.Parse(Console.ReadLine());

            char[,] matrix = new char[sizeMatrix, sizeMatrix];
            int startRowSanta = 0;
            int startColSanta = 0;

            int receivedGiftNiceKid = 0;
            int countNiceKids = 0;
            int countGivenGifts = 0;

            WriteMatrix(matrix, ref startRowSanta, ref startColSanta, ref countNiceKids);

            while (countOfGifts != 0)
            {
                string comand = Console.ReadLine();

                if (comand == "Christmas morning")
                {
                    break;
                }

                int newSantaRow = startRowSanta;
                int newSantaCol = startColSanta;

                bool santaOutMatrix = false;

                if (comand == "up")
                {
                    newSantaRow -= 1;

                    if (CheckIndex(matrix, newSantaRow, newSantaCol))
                    {
                        DoMovement(matrix, newSantaRow, newSantaCol, ref countGivenGifts,
                            ref receivedGiftNiceKid, ref countOfGifts);
                    }

                    else
                    {
                        newSantaRow = startRowSanta;
                        santaOutMatrix = true;
                    }
                }

                else if (comand == "down")
                {
                    newSantaRow += 1;

                    if (CheckIndex(matrix, newSantaRow, newSantaCol))
                    {
                        DoMovement(matrix, newSantaRow, newSantaCol, ref countGivenGifts,
                            ref receivedGiftNiceKid, ref countOfGifts);
                    }

                    else
                    {
                        newSantaRow = startRowSanta;
                        santaOutMatrix = true;
                    }
                }

                else if (comand == "right")
                {
                    newSantaCol += 1;

                    if (CheckIndex(matrix, newSantaRow, newSantaCol))
                    {
                        DoMovement(matrix, newSantaRow, newSantaCol, ref countGivenGifts,
                            ref receivedGiftNiceKid, ref countOfGifts);
                    }

                    else
                    {
                        newSantaCol = startColSanta;
                        santaOutMatrix = true;
                    }
                }

                else if (comand == "left")
                {
                    newSantaCol -= 1;

                    if (CheckIndex(matrix, newSantaRow, newSantaCol))
                    {
                        DoMovement(matrix, newSantaRow, newSantaCol, ref countGivenGifts,
                            ref receivedGiftNiceKid, ref countOfGifts);
                    }

                    else
                    {
                        newSantaCol = startColSanta;
                        santaOutMatrix = true;
                    }
                }

                if (santaOutMatrix)
                {
                    Console.WriteLine("Santa ran out of presents!");
                    break;
                }

                matrix[startRowSanta, startColSanta] = '-';
                matrix[newSantaRow, newSantaCol] = 'S';

                startRowSanta = newSantaRow;
                startColSanta = newSantaCol;

                if (countOfGifts == 0)
                {
                    Console.WriteLine("Santa ran out of presents!");
                    break;
                }
            }

            PrintMatrix(matrix);

            if (receivedGiftNiceKid == countNiceKids)
            {
                Console.WriteLine($"Good job, Santa! {receivedGiftNiceKid} happy nice kid/s.");
            }

            else
            {
                int niceKidsWtihoutPresent = countNiceKids - receivedGiftNiceKid;
                Console.WriteLine($"No presents for {niceKidsWtihoutPresent} nice kid/s.");
            }
        }

        public static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }
        public static void DoMovement(char[,] matrix, int row, int col, ref int countGivenGifts,
            ref int receivedGiftNiceKid, ref int numberOfGifts)
        {
            if (matrix[row, col] != '-')
            {
                if (matrix[row, col] == 'C')
                {
                    DoCockieComand(matrix, row, col, ref countGivenGifts, ref receivedGiftNiceKid,
                        ref numberOfGifts);
                }

                else if (matrix[row, col] == 'V')
                {
                    countGivenGifts++;
                    receivedGiftNiceKid++;
                    numberOfGifts--;

                }

                else if (matrix[row, col] == 'X')
                {
                    countGivenGifts++;
                    numberOfGifts--;
                }
            }
        }

        public static void DoCockieComand(char[,] matrix, int row, int col,
            ref int countGivenGifts, ref int receivedGiftNiceKid, ref int numberOfGifts)
        {
            for (int rows = -1; rows <= 1; rows += 2)
            {
                if (CheckIndex(matrix, row + rows, col))
                {
                    if (matrix[row + rows, col] == 'V')
                    {
                        countGivenGifts++;
                        receivedGiftNiceKid++;
                        numberOfGifts--;
                        matrix[row + rows, col] = '-';
                    }

                    else if (matrix[row + rows, col] == 'X')
                    {
                        countGivenGifts++;
                        numberOfGifts--;
                        matrix[row + rows, col] = '-';
                    }
                }
            }

            for (int cols = -1; cols <= 1; cols += 2)
            {
                if (CheckIndex(matrix, row, col + cols))
                {
                    if (matrix[row, col + cols] == 'V')
                    {
                        countGivenGifts++;
                        receivedGiftNiceKid++;
                        numberOfGifts--;
                        matrix[row, col + cols] = '-';
                    }

                    else if (matrix[row, col + cols] == 'X')
                    {
                        countGivenGifts++;
                        numberOfGifts--;
                        matrix[row, col + cols] = '-';
                    }
                }
            }
        }
        public static bool CheckIndex(char[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0)
                && col >= 0 && col < matrix.GetLength(1);
        }
        public static void WriteMatrix(char[,] matrix, ref int rowSanta, ref int colSanta, ref int countNiceKid)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ")
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = char.Parse(input[col]);

                    if (matrix[row, col] == 'S')
                    {
                        rowSanta = row;
                        colSanta = col;
                    }

                    if (matrix[row, col] == 'V')
                    {
                        countNiceKid++;
                    }
                }
            }
        }
    }
}
