using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmpregosYoyotaAPI.Models
{
    public class Job
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string Province { get; set; }
        public DateTime PublicationDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }

        public List<JobCategory> JobCategories { get; set; }
    }
}