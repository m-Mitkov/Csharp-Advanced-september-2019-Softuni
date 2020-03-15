using System;
using System.Linq;
using System.Collections.Generic;

namespace JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixRows = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[matrixRows][];

            for (int row = 0; row < jaggedArray.GetLength(0); row++)
            {
                int[] col = Console.ReadLine().Split(" ")
                    .Select(int.Parse).ToArray();

                jaggedArray[row] = col;
            }

            while (true)
            {
                string comand = Console.ReadLine();

                if (comand == "END")
                {
                    break;
                }

                string[] comandArgs = comand.Split(" ");

                string toDo = comandArgs[0];
                int row = int.Parse(comandArgs[1]);
                int col = int.Parse(comandArgs[2]);
                int value = int.Parse(comandArgs[3]);

                if (row < 0 || row > jaggedArray.Length - 1 || 
                    col < 0 || col > jaggedArray[row].Length - 1)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                if (toDo == "Add")
                {
                    jaggedArray[row][col] += value;
                }

                else if (toDo == "Subtract")
                {
                    jaggedArray[row][col] -= value;
                }
            }

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray.Length; col++)
                {
                    Console.Write(jaggedArray[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
