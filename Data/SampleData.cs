//using DataAccess.Models;

namespace Library.Data
{
    public class SampleData
    {
        public static void Initialize(LibraryContext context)
        {
            // fill database



            context.SaveChanges();
        }
    }
}
