﻿using System.ComponentModel.DataAnnotations;

namespace JobLeet.WebApi.JobLeet.Api.Models.Accounts.V1
{
    public class LoginUserModel : BaseModel
    {

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(101, ErrorMessage = "Password must be between 8 and 100 characters", MinimumLength = 8)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$",
            ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, one digit, and one special character")]
        public string Password { get; set; }
        public AccountCategory AccountStatus { get; set; }
        public bool AccountCreated { get; set; } = false;
        public DateTime LoginTime { get; set; } = DateTime.UtcNow;
        public string? IPAddress { get; set; }
        public RoleCategory Role { get; set; }
    }

    public enum AccountCategory
    {
        [Display(Name = "Active")]
        Active = 1,
        [Display(Name = "Inactive")]
        Inactive = 2,
        [Display(Name = "Suspended")]
        Suspended = 3,
        [Display(Name = "Locked")]
        Locked = 4,
        [Display(Name = "Pending")]
        Pending = 5
    }
}
