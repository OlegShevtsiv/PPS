using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<string> Authors { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public decimal Rate { get; set; }
        public string Description { get; set; }
        public ICollection<string> Genres { get; set; }

        public Book(int _id, string _title, ICollection<string> _authors, DateTime _releaseDate, decimal _rate, string _description, ICollection<string> _genres)
        {
            Id = _id;
            Title = _title;
            Authors = _authors;
            ReleaseDate = _releaseDate;
            Rate = _rate;
            Description = _description;
            Genres = _genres;
        }
    }
}

