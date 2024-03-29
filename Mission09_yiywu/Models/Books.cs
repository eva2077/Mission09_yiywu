﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

//gets info from books also makes each info required 

namespace Mission09_yiywu.Models
{
    public partial class Books
    {
        [Key]
        [Required]
        public long BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string Isbn { get; set; }
        public string Classification { get; set; }
        public string Category { get; set; }
        public long PageCount { get; set; }
        public double Price { get; set; }
    }
}
