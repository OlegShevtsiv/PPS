using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
