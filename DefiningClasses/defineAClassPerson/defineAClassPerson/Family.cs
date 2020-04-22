

namespace DefiningClasses
{
    using DefiningClasses;
    using System.Collections.Generic;
    using System.Linq;
    public class Family
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

        public Person GetOldestMember()
        {
            int oldestAge = int.MinValue;
            Person oldestPerson = null;

            foreach (var person in family)
            {
                if (person.Age > oldestAge)
                {
                    oldestAge = person.Age;
                    oldestPerson = person;
                }
            }
            return oldestPerson;
        }
    }
}
