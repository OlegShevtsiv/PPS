using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Author> Authors { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public string ImagePath { get; set; }
        public decimal Rate { get; set; }
        public string Description { get; set; }
        public List<string> Genres { get; set; }

        public Book() { }

        public Book(int _id, string _title, List<Author> _authors, DateTime _releaseDate, string imagePath, decimal _rate, string _description, List<string> _genres)
        {
            Id = _id;
            Title = _title;
            Authors = _authors;
            ReleaseDate = _releaseDate;
            ImagePath = imagePath;
            Rate = _rate;
            Description = _description;
            Genres = _genres;
        }

        
    }
}

