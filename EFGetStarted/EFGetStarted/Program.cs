using System;

namespace EFGetStarted
{
    class Program
    {
        private static BloggingContext _context = new BloggingContext();
        static void Main(string[] args)
        {
            InsertData();
        }

        private static void InsertData()
        {
            var blog = new Blog { Url = "http://sample.com" };
            _context.Blogs.Add(blog);
            _context.SaveChanges();
        }
    }
}
