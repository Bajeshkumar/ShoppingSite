﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping_Site.Models
{
    public class SignUpUserModel
    {
        [Required(ErrorMessage ="Please enter your first name")]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter your last name")]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter your email")]
        [Display(Name ="Email Address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter strong password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please confirm your password")]
        [Display(Name ="Confirm Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

    }
}
