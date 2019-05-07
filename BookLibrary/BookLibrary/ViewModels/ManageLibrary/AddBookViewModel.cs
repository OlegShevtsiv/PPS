using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.ViewModels.ManageLibrary
{
    public class AddBookViewModel
    {
        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Author")]
        public string AuthorId { get; set; }

        [Required]
        [Display(Name = "Realese year")]
        public int Year { get; set; }

       //[Required]
        [Display(Name = "Image")]
        public string ImagePath { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public string Genre { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Rate")]
        public decimal Rate { get; set; }
    }
}
