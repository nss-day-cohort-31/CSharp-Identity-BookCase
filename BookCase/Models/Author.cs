﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookCase.Models
{
    public class Author
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Pen Name")]
        public string PenName { get; set; }

        [Display(Name = "Genre")]
        public string Genre { get; set; }

        [NotMapped]
        [Display(Name = "Author")]
        public string FullName => $"{FirstName} {LastName}";

        public List<Book> Books { get; set; }
    }
}
