﻿using JobLeet.WebApi.JobLeet.Core.Entities.Common.V1;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
namespace JobLeet.WebApi.JobLeet.Core.Entities.Accounts.V1
{
    public class RegisterUser : BaseEntity
    {
        [JsonIgnore]
        public string? Salt { get; set; }
        [Required(ErrorMessage = "personName is a required field")]
        public PersonName PersonName {get; set;}
        [Required(ErrorMessage = "userEmail is a required field")]
        public Email UserEmail { get; set; }
        
        [Required(ErrorMessage = "Password is required")]
        [StringLength(101, ErrorMessage = "Password must be between 8 and 100 characters", MinimumLength = 8)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$",
            ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, one digit, and one special character")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords do not match")]
        [StringLength(101, ErrorMessage = "Password must be between 8 and 100 characters", MinimumLength = 8)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$",
            ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, one digit, and one special character")]
        public string ConfirmPassword { get; set; }
        
    }
}
