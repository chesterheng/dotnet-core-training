using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            basicExample();
            queryingOnStrings();
            queryingOnObjects();
        }

        private static void queryingOnObjects()
        {
            List<Book> books = new List<Book>() {
                new Book("Book A", 1999, new string[] { "Fantasy", "Romance" }, "Robert"),
                new Book("Book B", 2010, new string[] { "Romance" }, "Robert"),
                new Book("Book C", 2001, new string[] { "Romance" }, "Alicia"),
                new Book("Book D", 2005, new string[] { "Romance" }, "Alicia"),
                new Book("Book E", 2011, new string[] { "Romance" }, "John"),
            };

            // Get books published after 2000 ordoer by publication date
            var recentBooks = from book in books
                              where book.Year >= 2000
                              orderby book.Year
                              select book;

            foreach (var book in recentBooks)
            {
                // String interpolation
                Console.WriteLine($"Recent Book: {book.Title} - {book.Year}");
            }
            // Recent Book: Book C -2001
            // Recent Book: Book D -2005
            // Recent Book: Book B -2010
            // Recent Book: Book E -2011
        }

        private static void queryingOnStrings()
        {
            string text = "Hello Singapore!";
            var result = from c in text
                         where c != 'e' && c != 'a'
                         select c;

            foreach (char c in result)
                Console.Write(c + " ");
            Console.WriteLine();
            // H l l o   S i n g p o r !
        }

        private static void basicExample()
        {
            // The Three Parts of a LINQ Query:
            // 1. Obtain the data source.
            var scores = new int[] { 97, 92, 81, 60 };

            // 2. Create the query
            // scoreQuery is an IEnumerable<int>
            IEnumerable<int> scoreQuery = from score in scores
                                          where score > 80
                                          orderby score
                                          select score;

            // 3. Query execution.
            foreach (int i in scoreQuery)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            // Output: 97 92 81
        }
    }
}
