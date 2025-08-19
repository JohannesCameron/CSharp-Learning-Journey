using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Book_Tracker
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearPublished { get; set; }

        public Book()
        {
            Title = "Unknown";
            Author = "Unknown";
            YearPublished = 0;
        }
        public Book (string title, string author)
        {
            Title = title;
            Author = author;
        }

        public Book (string title, string author, int yearPublished)
        {
            Title = title;
            Author = author;
            YearPublished = yearPublished;
        }

        public void DisplayBookInfo()
        {
            Console.WriteLine($"{Title} {Author} ({YearPublished})");
        }
    }
}
