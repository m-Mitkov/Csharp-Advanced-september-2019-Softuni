using System;
using System.Linq;
using System.Collections.Generic;

namespace _2x2SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizeMatrix = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = sizeMatrix[0];
            int cols = sizeMatrix[1];

            char[,] matrix = new char[rows, cols];

            MatrixWrite(matrix);

            int subRows = 2;
            int subCols = 2;

            int coutEqualPairs = 0;

            for (int row = 0; row <= matrix.GetLength(0) - subRows; row++)
            {
                for (int col = 0; col <= matrix.GetLength(1) - subCols; col++)
                {
                    bool charIsEqual = false;
                    bool charIsDifferent = true;
                    char currentChar = matrix[row, col];

                    for (int subRow = 0; subRow < subRows; subRow++)
                    {
                        for (int subCol = 0; subCol < subCols; subCol++)
                        {
                            if (charIsDifferent)
                            {
                                if (matrix[row + subRow, col + subCol] == currentChar)
                                {
                                    charIsEqual = true;
                                }
                                else
                                {
                                    charIsEqual = false;
                                    charIsDifferent = false;
                                }
                            }
                        }
                    }
                    if (charIsEqual)
                    {
                        coutEqualPairs++;
                    }
                }
            }

            Console.WriteLine(coutEqualPairs);

        }

        static void MatrixWrite(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
        }
    }
}
