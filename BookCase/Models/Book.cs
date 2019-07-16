using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookCase.Models
{
    // NOTE: The DataAnnotations are used in migrations and/or in the views
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(13)]
        [MinLength(10)]
        [Display(Name = "ISBN")]
        public string Isbn { get; set; }
        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Genre")]
        public string Genre { get; set; }

        [Required]
        // NOTE: We use the DisplayFormat attribute to prevent displaying the time
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [Display(Name = "Published On")]
        public DateTime PublishDate { get; set; }

        [Required]
        [Display(Name = "Author")]
        public int AuthorId { get; set; }
        [Required]
        [Display(Name = "Author")]
        public Author Author { get; set; }

        [Required]
        public string OwnerId { get; set; }
        [Required]
        public ApplicationUser Owner { get; set; }
    }
}
