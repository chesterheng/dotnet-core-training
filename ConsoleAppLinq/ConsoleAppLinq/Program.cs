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
