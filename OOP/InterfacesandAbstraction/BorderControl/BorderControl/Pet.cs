using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    class Pet : IBithable
    {
        public Pet(string name, DateTime birthDay)
        {
            this.Name = name;
            this.BirthDay = birthDay;
        }

        public string Name { get; set; }
        public DateTime BirthDay { get; }

    }
}
