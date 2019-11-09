using System.Linq;

namespace EFGetStarted
{
    class Program
    {
        private static BloggingContext _context = new BloggingContext();
        static void Main(string[] args)
        {
            InsertData();
            UpdateData();
            DeleteData();
        }

        private static void DeleteData()
        {
            var blog = _context.Blogs.First();
            _context.Blogs.Remove(blog);
            _context.SaveChanges();
        }

        private static void UpdateData()
        {
            var blog = _context.Blogs.First();
            blog.Url = "http://sample.com/blognewnew";
            _context.SaveChanges();
        }

        private static void InsertData()
        {
            var blog = new Blog { Url = "http://sample.com" };
            _context.Blogs.Add(blog);
            _context.SaveChanges();
        }
    }
}
