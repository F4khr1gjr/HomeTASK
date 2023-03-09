using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookPCount.Models
{
    internal class Book
    {
        public string Name { get; set; }
        public int PageCount { get; set; }
        public Book(string name, int pageCount, Book[] books)
        {
            Name = name;
            PageCount = pageCount;
        }
    }
}

