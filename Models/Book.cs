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
        public int AuthorId { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public decimal Rate { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
    }
}

