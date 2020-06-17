using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    class Citizen : Buyer, IPerson
    {
        public Citizen(string name, int age, string id, DateTime birthDay)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.BirthDay = birthDay;
        }
        public string Id { get; set; }

        public DateTime BirthDay { get; set; }

        public int Food { get; private set; } = 0;

        protected override int DefaultFood => 10;
    }
}
