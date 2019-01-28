﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LoginData.Models
{
    public class Role
    {
        public int Id { get; set; }

        [StringLength(50, ErrorMessage = "Limit Description to 50 characters.")]
        public string Name{ get; set; }

        [StringLength(100, ErrorMessage = "Limit Description to 100 characters.")]
        public string Description { get; set; }
    }
}
