using System;
using System.Linq;
using System.Collections.Generic;

namespace SquarewithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[matrixSize[0], matrixSize[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] elementsCol = Console.ReadLine().Split(", ")
                    .Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elementsCol[col];
                }
            }

            // find biggest by sum 2x2 submatrix in matrix!

            int maxSum = int.MinValue;
            int subMatrixRow = 2;
            int subMatrixCol = 2;

            int maxSumRow = -1;
            int maxSumCol = -1;

            for (int row = 0; row < matrix.GetLength(0) - subMatrixRow + 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - subMatrixCol + 1; col++)
                {
                    int sum2x2Matrix = 0;

                    for (int subRow = 0; subRow < subMatrixRow; subRow++)
                    {
                        for (int subCol = 0; subCol < subMatrixCol; subCol++)
                        {
                            sum2x2Matrix += matrix[row + subRow, col + subCol];
                        }
                    }

                    if (sum2x2Matrix > maxSum)
                    {
                        maxSum = sum2x2Matrix;
                        maxSumRow = row;
                        maxSumCol = col;
                    }
                }
            }

            for (int row = 0; row < subMatrixRow; row++)
            {
                for (int col = 0; col < subMatrixCol; col++)
                {
                    Console.Write(matrix[maxSumRow + row, maxSumCol + col] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(maxSum);
        }
    }
}
