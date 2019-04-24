using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Services.DTO
{
    public class BookDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public decimal Rate { get; set; }
        public string Description { get; set; }
        public ICollection<string> Genres { get; set; }
    }
}
