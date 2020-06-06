using System;
using System.Collections.Generic;
using System.Linq;

namespace squareInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizeMatrix = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            char[,] matrix = new char[sizeMatrix[0], sizeMatrix[1]];
            WriteMatrix(matrix);

            int subMatrixRow = 2;
            int subMatrixCol = 2;
            int subRowXsubCol = subMatrixRow * subMatrixCol;

            //if (subMatrixRow > matrix.GetLength(0) && subMatrixCol > matrix.GetLength(1))
            //{
            //    Console.WriteLine("Submatrix is too big!");
            //    return;
            //}

            int countValidSubMatrixes = 0;

            for (int row = 0; row < matrix.GetLength(0) - subMatrixRow + 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - subMatrixCol + 1; col++)
                {
                    int countValidChars = 0;
                    char currentChar = matrix[row, col];

                    for (int subRow = row; subRow < row + subMatrixRow; subRow++)
                    {
                        for (int subCol = col; subCol < col + subMatrixCol; subCol++)
                        {
                            if (matrix[subRow, subCol] == currentChar)
                            {
                                countValidChars++;
                            }
                        }
                    }

                    if (countValidChars == subRowXsubCol)
                    {
                        countValidSubMatrixes++;
                    }
                }
            }

            Console.WriteLine(countValidSubMatrixes);

        }

        public static void WriteMatrix(char[,] matrix)
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
