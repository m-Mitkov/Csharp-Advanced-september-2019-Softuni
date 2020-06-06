using System;
using System.Linq;
using System.Collections.Generic;

namespace snakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            string snake = Console.ReadLine();

            char[,] matrix = new char[matrixSize[0], matrixSize[1]];

            Queue<char> snakeQueue = new Queue<char>();

            for (int i = 0; i < snake.Length; i++)
            {
                snakeQueue.Enqueue(snake[i]);
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        char currentChar = snakeQueue.Dequeue();

                        matrix[row, col] = currentChar;

                        snakeQueue.Enqueue(currentChar);

                    }
                }

                else if (row % 2 != 0)
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        char currentChar = snakeQueue.Dequeue();

                        matrix[row, col] = currentChar;

                        snakeQueue.Enqueue(currentChar);
                    }
                }
            }


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
