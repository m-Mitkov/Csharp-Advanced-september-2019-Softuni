using System;
using System.Collections.Generic;

namespace P03_StudentSystem
{
    public class StudentSystem
    {
        private Dictionary<string, Student> repo;

        public StudentSystem()
        {
            this.repo = new Dictionary<string, Student>();
        }

        public void ParseCommand()
        {
            string[] args = Console.ReadLine().Split();
            var toDo = args[0];

            if (toDo == "Create")
            {
                var name = args[1];
                var age = int.Parse(args[2]);
                var grade = double.Parse(args[3]);

                if (!repo.ContainsKey(name))
                {
                    var student = new Student(name, age, grade);
                    repo.Add(name, student);
                }
            }
            else if (toDo == "Show")
            {
                var name = args[1];

                if (repo.ContainsKey(name))
                {
                    var student = repo[name];
                    
                    Console.WriteLine(student);
                }

            }
            else if (toDo == "Exit")
            {
                Environment.Exit(0);
            }
        }
    }
}