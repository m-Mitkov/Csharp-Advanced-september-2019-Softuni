using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (value == null)
                {
                    throw new Exception("Invalid input!");
                }

                this.name = value;
            }
        }


        public int Age
        {
            get { return age; }
            set 
            {
                if (value <= 0)
                {
                    throw new Exception("Invalid input!");
                }

                this.age = value;
            }
        }


        public string Gender
        {
            get { return gender; }
            set 
            {
                if (value == null)
                {
                    throw new Exception("Invalid input!");
                }

                this.gender = value; 
            }
        }

        public string Sound { get; set; }

        public string ProduceSound()
        {
            return $"{this.Sound}";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{GetType().Name}");
            sb.AppendLine($"{this.Name} {this.Age} {this.Gender}");
            sb.AppendLine($"{this.ProduceSound()}");

            return sb.ToString().TrimEnd();
        }
    }
}
