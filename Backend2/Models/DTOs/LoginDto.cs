﻿using System.ComponentModel.DataAnnotations;

namespace Project1.Models.DTOs
{
    public class LoginDto
    {
        [Required(ErrorMessage = "Please enter an email address.")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Please enter your password.")]
        public string? Password { get; set; }
    }
}
