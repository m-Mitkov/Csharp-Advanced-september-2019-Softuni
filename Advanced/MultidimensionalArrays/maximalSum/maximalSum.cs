using System;
using System.Linq;
using System.Collections.Generic;

namespace maximalSum1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizeMatrix = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int rows = sizeMatrix[0];
            int cols = sizeMatrix[1];

            int[,] matrix = new int[rows, cols];

            WriteMatrix(matrix);

            int subMatrixRow = 3;
            int subMatrixCol = 3;

            int maxSumOfSubRowsCols = 0;
            int maxRow = 0;
            int maxCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - subMatrixRow + 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - subMatrixCol + 1; col++)
                {
                    int currentBestSum = 0;

                    for (int subRow = 0; subRow < subMatrixRow; subRow++)
                    {
                        for (int subCol = 0; subCol < subMatrixCol; subCol++)
                        {
                            currentBestSum += matrix[subRow + row, subCol + col];
                        }
                    }

                    if (currentBestSum > maxSumOfSubRowsCols)
                    {
                        maxSumOfSubRowsCols = currentBestSum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSumOfSubRowsCols}");
            PrintMatrix(matrix, subMatrixRow, subMatrixCol, maxRow, maxCol);
        }

        public static void PrintMatrix(int[,] matrix, int subMatrixRow, int subMatrixCol, int maxRow, int maxCol)
        {
            for (int row = 0; row < subMatrixRow; row++)
            {
                for (int col = 0; col < subMatrixCol; col++)
                {
                    Console.Write(matrix[row + maxRow, col + maxCol] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void WriteMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
        }
    }
}
