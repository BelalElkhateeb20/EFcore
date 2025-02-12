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


            _context.SaveChanges();
        }
    }
}
