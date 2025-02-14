using EFcore.Models;
using Microsoft.Data.SqlClient;
using System.Reflection.Metadata;

namespace EFcore
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using (var _context = new ApplictionDbContext())
            {
                var Blog = new Blog()
                {
                    Content = "welcome to my project",
                    Title = "Belal",
                    Url = "http\\microsoft.NetFramework",
                }
                ;
                //_context.Add(Blog);
                _context.Update(Blog);
                _context.SaveChanges();
            }




        }
    }
}
