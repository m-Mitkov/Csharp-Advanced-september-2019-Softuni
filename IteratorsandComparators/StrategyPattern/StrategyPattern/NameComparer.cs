using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace StrategyPattern
{
    class NameComparer : IComparer<Person>
    {
        public int Compare(Person firstPerson, Person secondPerson)
        {
            int result = firstPerson.Name.Length.CompareTo(secondPerson.Name.Length);

            if (result == 0)
            {
                return firstPerson.Name.ToLower()[0].CompareTo(secondPerson.Name.ToLower()[0]);
            }

            return result;
        }
    }
}
