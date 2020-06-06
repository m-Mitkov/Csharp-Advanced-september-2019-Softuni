using System;
using System.Linq;
using System.Collections.Generic;

namespace sumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizeInput = Console.ReadLine()
                .Split(", ")
                .Select(x => int.Parse(x))
                .ToArray();

            int[,] matrix = new int[sizeInput[0], sizeInput[1]];

            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split(", ")
                    .Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];

                    sum += matrix[row, col];
                }
            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
