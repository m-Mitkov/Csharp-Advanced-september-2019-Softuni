using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace IteratorsAndComparators
{
    public class Book
    {
        public Book(string title, int year, params string[] authors)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = new List<string>(authors.ToList());
        }
        public string Title { get; set; }
        public int Year { get; set; }
        public List<string> Authors { get; set; }
    }
}
