﻿using System.ComponentModel.DataAnnotations;

namespace UniversityAPI.Models.DataModels
{
    public class User : BaseEntity
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required] 
        public string Password { get; set; } = string.Empty;

    }
}