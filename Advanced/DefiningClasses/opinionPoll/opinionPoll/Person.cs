

namespace opinionPoll
{
    using System.Collections.Generic;
    using System.Linq;
    public class Person
    {
        private string name;
        private int age;
        public Person(int age) : this("No name", age)
        {
            this.Age = age;
        }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public Person() : this("No name", 1)
        {
        }
        public string Name { get; set; }
        public int Age { get; set; }

    }
}

