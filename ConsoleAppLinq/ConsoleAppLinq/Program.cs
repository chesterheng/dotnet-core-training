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
