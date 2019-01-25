using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LoginData.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Full Name field is required"), StringLength(50, MinimumLength = 2)]
        public string FullName { get; set; }

        [StringLength(40, ErrorMessage = "Limit Email to 40 characters.")]
        public string Email { get; set; }

        [Required, StringLength(20)]
        public string Username { get; set; }

        [Range(0, 20)]
        public string Password { get; set; }
        
        public DateTime LastAccess { get; set; }
    }
}
