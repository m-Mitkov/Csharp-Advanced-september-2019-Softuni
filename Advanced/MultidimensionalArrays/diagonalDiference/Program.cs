using System;
using System.Linq;
using System.Collections.Generic;

namespace diagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixSize = int.Parse(Console.ReadLine());

            var matrix = new int[matrixSize, matrixSize];

            int firstDiagonalSum = 0;
            int secondDiagonalSum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var input = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                firstDiagonalSum += matrix[row, row];
            }
            int countCol = 0;

            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                for (int col = countCol; col < matrix.GetLength(1); col++)
                {
                    countCol++;
                    secondDiagonalSum += matrix[row, col];
                    break;
                }
            }
            int result = Math.Abs(firstDiagonalSum - secondDiagonalSum);

            Console.WriteLine(result);
        }
    }
}
