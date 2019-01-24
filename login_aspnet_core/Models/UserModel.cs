using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace login_aspnet_core.Models
{
    public class UserModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Full Name field is required"), StringLength(50, MinimumLength = 2)]
        public string FullName { get; set; }

        [Required, StringLength(20)]
        public string Username { get; set; }

        [Required, StringLength(50)]
        public string Password { get; set; }

        public string Email { get; set; }
    }
}
