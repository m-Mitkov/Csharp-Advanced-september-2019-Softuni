using System;
using System.Linq;
using System.Collections.Generic;

namespace averageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> grades = new Dictionary<string, List<double>>();

            int numberOfStudents = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] currentStudent = Console.ReadLine()
                    .Split(" ");

                string name = currentStudent[0];
                double grade = double.Parse(currentStudent[1]);

                if (!grades.ContainsKey(name))
                {
                    grades.Add(name, new List<double>());
                }

                grades[name].Add(grade);
            }

            foreach (var kvp in grades)
            {
                string name = kvp.Key;
                List<double> studentGrades = kvp.Value;
                double average = studentGrades.Average();

                Console.Write($"{name} -> ");

                foreach (var kvpValue in studentGrades)
                {
                    Console.Write($"{kvpValue:F2} ");
                }
                Console.Write($"(avg: {average:F2})");
                Console.WriteLine();
            }
        }
    }
}
