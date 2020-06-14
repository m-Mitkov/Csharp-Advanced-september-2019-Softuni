using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        private const decimal minimalSalary = 460.00M;

        private string firsName;
        private string lastNAme;
        private int age;
        private decimal salary;
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public string FirstName
        {
            get => this.firsName;
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }

                this.firsName = value;
            }
        }
        public string LastName
        {
            get => this.lastNAme;
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }

                this.lastNAme = value;
            }
        }
        public int Age
        {
            get => this.age;
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }

                this.age = value;
            }
        }
        public decimal Salary 
        { 
            get => this.salary;
            private set
            {
                if (value < minimalSalary)
                {
                    throw new ArgumentException($"Salary cannot be less than {minimalSalary} leva!");
                }

                this.salary = value;
            } 
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age < 30)
            {
                decimal increasePercentage = percentage / 2;
                this.Salary = this.Salary + (this.Salary * (increasePercentage / 100));
            }

            else
            {
                this.Salary = this.Salary + (this.Salary * (percentage / 100));
            }
        }
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} gets {this.Salary:F2} leva.";
        }
    }
}
