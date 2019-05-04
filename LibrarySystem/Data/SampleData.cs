using DataAccess;
using System.Linq;
using DataAccess.Models;
using System.Collections.Generic;
using System;
using System.Xml.Linq;

namespace Library.Data
{
    public class SampleData
    {
        public static void Initialize(LibraryContext context)
        {
            if (!context.Authors.Any())
            {
                context.Authors.AddRange(
                new Author
                {
                    Name = "Taras",
                    Surname = "Shevchenko",
                    Description = "Ukrainian poet, painter."
                },
                new Author
                {
                    Name = "Ivan",
                    Surname = "Franko",
                    Description = "Ukrainian writer, public and political figure."
                }
                );
            }
            if (!context.Books.Any() && !context.BookStorages.Any())
            {
                context.Books.AddRange(
                new Book
                {
                    Title = "Kobzar",
                    Authors = new List<Author> { new Author
                        (
                            1,
                            "Taras",
                            "Shevchenko",
                            "Ukrainian poet, painter."
                         )
                    },
                    ReleaseDate = new DateTime(1837, 12, 12),
                    Rate = 5,
                    Description = "The most popular Shevchenko's book.",
                    Genres = new List<string> { "poetry" }
                },
                new Book
                {
                    Title = "Lis Mykita",
                    Authors = new List<Author> { new Author
                        (
                            2,
                           "Ivan",
                            "Franko",
                            "Ukrainian writer, public and political figure."
                        )
                    },
                    ReleaseDate = new DateTime(1891, 7, 10),
                    Rate = 4,
                    Description = "Was filmed in middle of last centuries.",
                    Genres = new List<string> { "poem", "tale" }
                }
                );
            }
            if (!context.Users.Any())
            {


            }
          
            context.SaveChanges();
        }
    }
}
