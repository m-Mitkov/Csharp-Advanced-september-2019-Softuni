using System;
using System.Linq;
using System.Collections.Generic;

namespace jaggedArrayManipulator1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());

            double[][] jaggedArr = new double[numberOfRows][];

            WriteJaggedArr(jaggedArr);
            AnalyzeJaggedArr(jaggedArr);

            while (true)
            {
                string[] comand = Console.ReadLine()
                    .Split(" ");

                string toDo = comand[0];

                if (toDo == "End")
                {
                    break;
                }

                int row = int.Parse(comand[1]);
                int col = int.Parse(comand[2]);
                int value = int.Parse(comand[3]);

                if (toDo == "Add")
                {
                    if (CheckIndexes(comand, jaggedArr))
                    {
                        jaggedArr[row][col] += value;
                    }
                }

                else if (toDo == "Subtract")
                {
                    if (CheckIndexes(comand, jaggedArr))
                    {
                        jaggedArr[row][col] -= value;
                    }
                }
            }

            for (int row = 0; row < jaggedArr.Length; row++)
            {
                for (int col = 0; col < jaggedArr[row].Length; col++)
                {
                    Console.Write(jaggedArr[row][col] + " ");
                }
                Console.WriteLine();
            }

        }
        public static bool CheckIndexes(string[] comand, double[][] jaggedArr)
        {
            int row = int.Parse(comand[1]);
            int col = int.Parse(comand[2]);

            if (row >= 0 && row < jaggedArr.Length && col >= 0 && col < jaggedArr[row].Length)
            {
                return true;
            }
            return false;
        }
        public static void AnalyzeJaggedArr(double[][] jaggedArr)
        {
            for (int row = 0; row < jaggedArr.Length - 1; row++)
            {
                if (jaggedArr[row].Length == jaggedArr[row + 1].Length)
                {
                    for (int col = 0; col < jaggedArr[row].Length; col++)
                    {
                        jaggedArr[row][col] *= 2;
                        jaggedArr[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int i = 0; i < jaggedArr[row].Length; i++)
                    {
                        jaggedArr[row][i] /= 2;
                    }
                    for (int j = 0; j < jaggedArr[row + 1].Length; j++)
                    {
                        jaggedArr[row + 1][j] /= 2;
                    }
                }
            }
        }
        public static void WriteJaggedArr(double[][] jaggedArr)
        {
            for (int row = 0; row < jaggedArr.Length; row++)
            {
                jaggedArr[row] = Console.ReadLine()
                    .Split(" ")
                    .Select(double.Parse)
                    .ToArray();
            }
        }
    }
}
