using System;
using System.Linq;
using System.Collections.Generic;

namespace symbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowInput = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowInput[col];
                }
            }

            char symbolFind = char.Parse(Console.ReadLine());

            int[] coordinates = new int[2];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    char currentSymbol = matrix[row, col];

                    if (currentSymbol == symbolFind)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{symbolFind} does not occur in the matrix ");
        }
    }
}
