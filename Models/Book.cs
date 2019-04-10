using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        //public ICollection<int> AuthorsId { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public decimal Rate { get; set; }
        public string Description { get; set; }
        //public ICollection<string> Genres { get; set; }

        public Book(int _id, string _title, DateTime _releaseDate, decimal _rate, string _description)
        {
            Id = _id;
            Title = _title;
            ReleaseDate = _releaseDate;
            Rate = _rate;
            Description = _description;
        }
    }
}

