
namespace EFcore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var _context = new ApplictionDbContext();

            _context.SaveChanges();
        }
    }
}
