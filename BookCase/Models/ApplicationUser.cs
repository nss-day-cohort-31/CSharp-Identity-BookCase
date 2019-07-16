using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookCase.Models
{
    // NOTE: IdentityUser doesn't have all the properties we want, so we inherit from them and add them
    //       to our class
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        // NOTE: Not mapped means Entity won't try to create a column for this property
        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";
    }
}
