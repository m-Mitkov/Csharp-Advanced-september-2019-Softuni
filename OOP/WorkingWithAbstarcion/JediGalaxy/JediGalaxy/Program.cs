using System;
using System.Linq;
using System.Collections.Generic;

namespace JediGalaxy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizeGalaxy = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int[,] galaxy = new int[sizeGalaxy[0], sizeGalaxy[1]];
            FillMatrix(galaxy);
            int sumPlayer = 0;

            string comand = Console.ReadLine();

            while (comand != "Let the Force be with you")
            {
                int[] playerCoordinates = comand
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                int rowPlayer = playerCoordinates[0];
                int colPlayer = playerCoordinates[1];

                int[] evilPowerCoordinates = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int rowEvil = evilPowerCoordinates[0];
                int colEvil = evilPowerCoordinates[1];

                sumPlayer = CalculatePlayerSumDiagonals(galaxy, rowPlayer, colPlayer, rowEvil, colEvil);

                comand = Console.ReadLine();
            }

            Console.WriteLine(sumPlayer);
        }
        public static int CalculatePlayerSumDiagonals(int[,] galaxy, int playerRow, int playerCol, int evilRow, int evilCol)
        {
            MoveEvil(galaxy, evilRow, evilCol);

            int sumPlayer = 0;
            while (playerRow >= 0 && playerCol < galaxy.GetLength(1))
            {
                if (IndexValidator(galaxy, playerRow, playerCol))
                {
                    sumPlayer += galaxy[playerRow, playerCol];

                }

                playerRow--;
                playerCol++;
            }
            return sumPlayer;

        }

        public static void MoveEvil(int[,] galaxy, int row, int col)
        {
            while (row >= 0 && col >= 0)
            {
                if (IndexValidator(galaxy, row, col))
                {
                    galaxy[row, col] = 0;
                }

                row--;
                col--;
            }
        }

        public static bool IndexValidator(int[,] galaxy, int row, int col)
        {
            return row >= 0 && row < galaxy.GetLength(0) &&
                col >= 0 && col < galaxy.GetLength(1);
        }
        public static void FillMatrix(int[,] galaxy)
        {
            int count = 0;

            for (int row = 0; row < galaxy.GetLength(0); row++)
            {
                for (int col = 0; col < galaxy.GetLength(1); col++)
                {
                    galaxy[row, col] = count;
                    count++;
                }
            }
        }
    }
}
