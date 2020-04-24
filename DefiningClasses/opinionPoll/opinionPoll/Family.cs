using System;
using System.Collections.Generic;
using System.Linq;

namespace opinionPoll
{
    class Family
    {
        private List<Person> family;

        public Family()
        {
            this.family = new List<Person>();
        }

        public void AddMember(Person person)
        {
            this.family.Add(person);
        }

        public List<Person> GetPeopleOverThirty()
        {
            return this.family.Where(x => x.Age > 30)
                .ToList();
        }
    }
}
