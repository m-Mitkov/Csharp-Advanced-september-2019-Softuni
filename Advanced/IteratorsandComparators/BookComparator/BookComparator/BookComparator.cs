using System;
using System.Collections.Generic;
using System.Text;
using IteratorsAndComparators;
using System.Linq;

namespace IteratorsAndComparators
{
    public class BookComparator : IComparer<Book>
    {
        public int Compare(Book current, Book other)
        {
            int resutl = current.Title.CompareTo(other.Title);

            if (resutl == 0)
            {
                resutl = current.Year.CompareTo(other.Year);
            }

            return resutl;
        }
    }
}
