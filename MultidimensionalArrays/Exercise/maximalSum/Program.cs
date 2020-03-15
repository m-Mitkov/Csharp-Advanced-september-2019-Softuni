using System;
using System.Linq;
using System.Collections.Generic;

namespace maximalSum
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

            int sumMatrixRow = 3;
            int subMatrixCol = 3;

            WriteMatrix(matrix);

            int biggestSum = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;

            for (int row = 0; row <= matrix.GetLength(0) - sumMatrixRow; row++)
            {

                for (int col = 0; col <= matrix.GetLength(1) - subMatrixCol; col++)
                {
                    int currentSum = 0;

                    for (int subRow = 0; subRow < sumMatrixRow; subRow++)
                    {
                        for (int subCol = 0; subCol < subMatrixCol; subCol++)
                        {
                            currentSum += matrix[row + subRow, col + subCol];
                        }
                    }

                    if (currentSum > biggestSum)
                    {
                        biggestSum = currentSum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {biggestSum}");

            for (int row = 0; row < sumMatrixRow; row++)
            {
                for (int col = 0; col < subMatrixCol; col++)
                {
                    Console.Write(matrix[row + maxRow, col + maxCol] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void WriteMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine()
                    .Split()
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
