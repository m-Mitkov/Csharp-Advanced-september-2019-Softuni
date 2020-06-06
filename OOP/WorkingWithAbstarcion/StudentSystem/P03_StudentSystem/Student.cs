using System;
using System.Collections.Generic;
using System.Text;

namespace P03_StudentSystem
{



    public class Student
    {

        public Student(string name, int age, double grade)
        {
            this.Name = name;
            this.Age = age;
            this.Grade = grade;
        }
        public double Grade { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            string comentary = $"{0}";

            if (this.Grade >= 5.00)
            {
                comentary = "Excellent student.";
            }

            else if (this.Grade < 5.00 && this.Grade >= 3.50)
            {
               comentary = " Average student.";
            }

            else
            {
                comentary = " Very nice person.";
            }

            result.AppendLine($"{this.Name} is {this.Age} years old. {comentary}");

            return result.ToString().TrimEnd();
        }
    }
}