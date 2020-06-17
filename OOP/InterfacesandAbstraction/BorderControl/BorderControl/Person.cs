using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    class Person : ICountable, IBithable
    {
        public Person(string name, int age, string id, DateTime birthDay)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.BirthDay = birthDay;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Id { get; set; }
        public DateTime BirthDay { get; set; }

        public bool CheckBorderControllPassed(string specificCode)
        {
            if (Id.Substring(Id.Length - specificCode.Length, specificCode.Length) == specificCode)
            {
                return true;
            }

            return false;
        }
    }
}
