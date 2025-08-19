using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Book_Tracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            Book book2 = new Book("AOT", "ABC");
            Book book3 = new Book("BCS", "MSA", 2000);

            book1.DisplayBookInfo();
            book2.DisplayBookInfo();
            book3.DisplayBookInfo();
        }
    }
}
