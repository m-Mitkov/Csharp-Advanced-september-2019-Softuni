using System;
using System.Linq;
using System.Collections.Generic;

namespace bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeMatrix = int.Parse(Console.ReadLine());

            int[,] matrix = new int[sizeMatrix, sizeMatrix];

            WriteMatrix(matrix);

            string[] bombsCoordinates = Console.ReadLine()
                .Split(" ")
                .ToArray();

            foreach (var bomb in bombsCoordinates)
            {
                string[] coordinates = bomb
                    .Split(",");

                int bombRow = int.Parse(coordinates[0]);
                int bombCol = int.Parse(coordinates[1]);

                int bombPower = matrix[bombRow, bombCol];
                matrix[bombRow, bombCol] = 0;

                Queue<int> bombRange = BombRange();

                while (bombRange.Count > 0)
                {
                    int rowExplosion = bombRange.Dequeue();
                    int colExplosion = bombRange.Dequeue();

                    if (CheckCoordinates(matrix, rowExplosion + bombRow, colExplosion + bombCol) && bombPower > 0)
                    {
                        if (matrix[bombRow + rowExplosion, bombCol + colExplosion] > 0)
                        {
                            matrix[rowExplosion + bombRow, colExplosion + bombCol] -= bombPower;
                        }
                    }
                }
            }
            int sumAlliveCells = 0;
            int countAlliveCells = 0;

            foreach (var aliveCell in matrix)
            {
                if (aliveCell > 0)
                {
                    countAlliveCells++;
                    sumAlliveCells += aliveCell;
                }
            }

            Console.WriteLine($"Alive cells: {countAlliveCells}");
            Console.WriteLine($"Sum: {sumAlliveCells}");

            PrintMatrix(matrix);
        }

        public static void PrintMatrix(int[,] matrix)
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

        public static bool CheckCoordinates(int[,] matrix, int row, int col)
        {
            return 0 <= row && row < matrix.GetLength(0) &&
                   0 <= col && col < matrix.GetLength(1);
        }
        public static Queue<int> BombRange()
        {
            Queue<int> bombRange = new Queue<int>();
            // row                  // col
            bombRange.Enqueue(-1); bombRange.Enqueue(-1);
            bombRange.Enqueue(-1); bombRange.Enqueue(0);
            bombRange.Enqueue(-1); bombRange.Enqueue(+1);
            bombRange.Enqueue(0); bombRange.Enqueue(-1);
            bombRange.Enqueue(0); bombRange.Enqueue(+1);
            bombRange.Enqueue(+1); bombRange.Enqueue(-1);
            bombRange.Enqueue(+1); bombRange.Enqueue(0);
            bombRange.Enqueue(+1); bombRange.Enqueue(+1);

            return bombRange;

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
