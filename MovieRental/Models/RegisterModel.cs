﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRental.Models
{
    public class RegisterModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        [StringLength(100,ErrorMessage ="")]
        [DataType(DataType.Password)]      
        public string Password { get; set; }


        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Does not match.")]
        public string ConfirmPassword { get; set; }
    }
}