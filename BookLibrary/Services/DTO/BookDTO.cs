using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Services.DTO
{
    public class BookDTO
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string AuthorId { get; set; }

        public int Year { get; set; }

        public string ImagePath { get; set; }
        public decimal Rate { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
    }
}
