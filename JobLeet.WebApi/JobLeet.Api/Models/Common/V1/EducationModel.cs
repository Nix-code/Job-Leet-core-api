﻿namespace JobLeet.WebApi.JobLeet.Api.Models.Common.V1
{
    public class EducationModel : BaseModel
    {
        public string Degree { get; set; }
        public string Major { get; set; }
        public string Institution { get; set; }
        public DateOnly GraduationDate { get; set; }
        public decimal Cgpa { get; set; }
    }
}
