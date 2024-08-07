﻿using System.ComponentModel.DataAnnotations;
namespace JobLeet.WebApi.JobLeet.Core.Entities.Common.V1
{
    public class Address : BaseEntity
    {
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        [RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Invalid Postal Code format")]
        public string? PostalCode { get; set; }
        [Required(ErrorMessage = "Country is required")]
        public string? Country { get; set; }
    }
}
