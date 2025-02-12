using EFcore.Models;
using System.Reflection.Metadata;

namespace EFcore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var Blogs = new List<Blog>();
            var _context = new ApplictionDbContext();
            //var Blog = new Blog
            //{
            //    Content = "Hello From Belal's Pc",
            //    Title= "First Post",
            //    url= "https://blog1.com/"
            //};
            //Blogs.Add(Blog);
            //Blog = new Blog
            //{
            //    Content = "HR Department",
            //    Title= "HR",
            //    url= "https://blog1.com/"
            //};  
            //foreach (var blog in Blogs)
            //{
            //    _context.Add(blog);
            //}

            _context.SaveChanges();
        }
    }
}
