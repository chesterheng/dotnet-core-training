using System;
using System.Collections.Generic;
using System.Linq;

namespace EFGetStarted
{
    class Program
    {
        private static BloggingContext _context = new BloggingContext();
        static void Main(string[] args)
        {
            // InsertData();
            // UpdateData();
            // DeleteData();
            // SaveRelatedData1();
            // SaveRelatedData2();

            Query();
        }

        private static void Query()
        {
            var results =
                from blog in _context.Blogs
                select new { Blog = blog, NbPosts = blog.Posts.Count };
            foreach (var result in results)
            {
                Console.WriteLine("Blog {0} has {1} post(s)", result.Blog.Url, result.NbPosts);
            }
        }

        private static void SaveRelatedData2()
        {
            var blog = new Blog { Url = "http://blogs.msdn.com/visualstudio" };
            var post = _context.Posts.First();
            post.Blog = blog;
            _context.SaveChanges();
        }

        private static void SaveRelatedData1()
        {
            var blog = new Blog
            {
                Url = "http://blogs.msdn.com/dotnet",
                Posts = new List<Post>
                {
                    new Post { Title = "Intro to C#" },
                    new Post { Title = "Intro to VB.NET" },
                    new Post { Title = "Intro to F#" }
                }
            };
            _context.Blogs.Add(blog);
            _context.SaveChanges();
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
