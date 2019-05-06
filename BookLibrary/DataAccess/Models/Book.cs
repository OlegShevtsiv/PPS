using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class Book
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }
        public string AuthorId { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public string ImagePath { get; set; }
        public decimal Rate { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }

        public Book() { }

        public Book(string _id, string _title, Author _author, string _authorId, DateTime _releaseDate, string imagePath, decimal _rate, string _description, string _genres)
        {
            Id = _id;
            Title = _title;
            Author = _author;
            AuthorId = _authorId;
            ReleaseDate = _releaseDate;
            ImagePath = imagePath;
            Rate = _rate;
            Description = _description;
            Genre = _genres;
        }

        
    }
}

